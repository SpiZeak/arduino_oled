#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <SimpleTimer.h>

#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 32 // OLED display height, in pixels

// Declaration for an SSD1306 display connected to I2C (SDA, SCL pins)
#define OLED_RESET     4 // Reset pin # (or -1 if sharing Arduino reset pin)

Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);
Adafruit_SSD1306 display2(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

SimpleTimer timer;
int T;

int temp;
int clk;
int load;
int fps;
String data;
String gpu;
String cpu;

void setup() {
  Serial.begin(9600);

  // Start sleep timer
  T = timer.setInterval(3000, clearDisplays);

  // SSD1306_SWITCHCAPVCC = generate display voltage from 3.3V internally
  if (!display.begin(SSD1306_SWITCHCAPVCC, 0x3C)) { // Address 0x3C for 128x32
    Serial.println(F("SSD1306 allocation failed"));
    for (;;); // Don't proceed, loop forever
  }

  if (!display2.begin(SSD1306_SWITCHCAPVCC, 0x3D)) { // Address 0x3D for 128x32
    Serial.println(F("SSD1306 allocation failed"));
    for (;;); // Don't proceed, loop forever
  }

  // Show initial display buffer contents on the screen --
  // the library initializes this with an Adafruit splash screen.
  display.display();
  display2.display();
  delay(2000); // Pause for 2 seconds

  // Clear the buffer
  display.clearDisplay();
  display2.clearDisplay();

  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(0, 0);
  display2.setTextSize(1);
  display2.setTextColor(SSD1306_WHITE);
  display2.setCursor(0, 0);
}

void loop() {
  if (Serial.available() > 0) {
    // Prevent sleep
    timer.restartTimer(T);

    display.clearDisplay();
    display2.clearDisplay();

    clk = Serial.parseInt();
    temp = Serial.parseInt();
    load = Serial.parseInt();
    fps = Serial.parseInt();
    data = Serial.readString();
    gpu = getValue(data, ',', 1);
    cpu = getValue(data, ',', 2);

    display.setTextSize(2);
    display.setCursor(0, 0);
    display.print(clk);
    display.println(" MHz");
    display.setCursor(0, 16);
    display.print(load);
    display.print("% ");
    display.print(temp);
    display.println(" C");

    display2.setTextSize(4);
    display2.setCursor(25, 0);
    display2.println(fps);
  }

  display.display();
  display2.display();

  timer.run();
}

String getValue(String data, char separator, int index)
{
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length() - 1;

  for (int i = 0; i <= maxIndex && found <= index; i++) {
    if (data.charAt(i) == separator || i == maxIndex) {
      found++;
      strIndex[0] = strIndex[1] + 1;
      strIndex[1] = (i == maxIndex) ? i + 1 : i;
    }
  }

  return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void clearDisplays() {
  display.clearDisplay();
  display2.clearDisplay();
}
