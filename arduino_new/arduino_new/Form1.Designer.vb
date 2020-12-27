<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GTEMP = New System.Windows.Forms.Label()
        Me.GLOAD = New System.Windows.Forms.Label()
        Me.GCCLK = New System.Windows.Forms.Label()
        Me.GPU = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.Label()
        Me.FPS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GTEMP
        '
        Me.GTEMP.AutoSize = True
        Me.GTEMP.Location = New System.Drawing.Point(68, 35)
        Me.GTEMP.Name = "GTEMP"
        Me.GTEMP.Size = New System.Drawing.Size(45, 13)
        Me.GTEMP.TabIndex = 0
        Me.GTEMP.Text = "GTEMP"
        '
        'GLOAD
        '
        Me.GLOAD.AutoSize = True
        Me.GLOAD.Location = New System.Drawing.Point(68, 61)
        Me.GLOAD.Name = "GLOAD"
        Me.GLOAD.Size = New System.Drawing.Size(44, 13)
        Me.GLOAD.TabIndex = 0
        Me.GLOAD.Text = "GLOAD"
        '
        'GCCLK
        '
        Me.GCCLK.AutoSize = True
        Me.GCCLK.Location = New System.Drawing.Point(71, 88)
        Me.GCCLK.Name = "GCCLK"
        Me.GCCLK.Size = New System.Drawing.Size(42, 13)
        Me.GCCLK.TabIndex = 0
        Me.GCCLK.Text = "GCCLK"
        '
        'GPU
        '
        Me.GPU.AutoSize = True
        Me.GPU.Location = New System.Drawing.Point(13, 9)
        Me.GPU.Name = "GPU"
        Me.GPU.Size = New System.Drawing.Size(30, 13)
        Me.GPU.TabIndex = 0
        Me.GPU.Text = "GPU"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "COM3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Port name"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'BackgroundWorker1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Temp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Load:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Clock:"
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.Location = New System.Drawing.Point(12, 125)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(29, 13)
        Me.CPU.TabIndex = 0
        Me.CPU.Text = "CPU"
        '
        'FPS
        '
        Me.FPS.AutoSize = True
        Me.FPS.Location = New System.Drawing.Point(12, 153)
        Me.FPS.Name = "FPS"
        Me.FPS.Size = New System.Drawing.Size(27, 13)
        Me.FPS.TabIndex = 6
        Me.FPS.Text = "FPS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 214)
        Me.Controls.Add(Me.FPS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.GPU)
        Me.Controls.Add(Me.GCCLK)
        Me.Controls.Add(Me.GLOAD)
        Me.Controls.Add(Me.GTEMP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GTEMP As Label
    Friend WithEvents GLOAD As Label
    Friend WithEvents GCCLK As Label
    Friend WithEvents GPU As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CPU As Label
    Friend WithEvents FPS As Label
End Class
