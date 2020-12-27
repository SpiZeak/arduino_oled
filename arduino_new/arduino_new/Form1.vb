Imports OpenHardwareMonitor.Collections
Imports OpenHardwareMonitor.Hardware
Imports System.Math
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.ComponentModel
Imports RTSSSharedMemoryNET

Public Class Form1
    Dim flag As Boolean
    Dim cp As New Computer()

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        cp.GPUEnabled = True
        cp.CPUEnabled = True
        cp.Open()
    End Sub


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim appEntries = OSD.GetAppEntries().Where(Function(x) (x.Flags And AppFlags.MASK) <> AppFlags.None).ToArray()

        FPS.Text = ""

        For Each app In appEntries
            If app.InstantaneousFrames > 0 Then
                FPS.Text = app.InstantaneousFrames
            End If
        Next

        For Each hw In cp.Hardware

            If hw.HardwareType = HardwareType.CPU Then
                CPU.Text = hw.Name
            End If

            If hw.HardwareType = HardwareType.GpuNvidia Then
                GPU.Text = hw.Name
                hw.Update()
                For Each sensor In hw.Sensors
                    If sensor.SensorType = SensorType.Temperature Then
                        GTEMP.Text = Convert.ToInt64(sensor.Value)
                    End If
                    If sensor.Name = "GPU Core" Then
                        GLOAD.Text = Convert.ToInt64(sensor.Value)
                    End If
                    If sensor.SensorType = SensorType.Clock Then
                        If sensor.Name.Contains("Core") Then
                            GCCLK.Text = Convert.ToInt64(sensor.Value)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Do While flag = True
            SerialPort1.Write(GCCLK.Text + "," + GTEMP.Text + "," + GLOAD.Text + "," + FPS.Text + "," + GPU.Text + "," + CPU.Text) 'this sends values to arduino
            delay(1500)
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag = True Then
            Button1.Text = "Start"
            flag = False
            SerialPort1.Close()
        Else
            Button1.Text = "Stop"
            SerialPort1.PortName = TextBox1.Text
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.Open()
            flag = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    'delay function
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    Public lngStartTime As Long
    Public Sub delay(msdelay As Long)
        lngStartTime = timeGetTime()
        Do Until (timeGetTime() - lngStartTime) > msdelay
        Loop
    End Sub
    'End delay function
End Class