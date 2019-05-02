#include <LCD4Bit_mod.h>
#include <string.h>
#include <Servo.h>

LCD4Bit_mod lcd = LCD4Bit_mod(2);
Servo servo1, servo2;

//Key message
char msgs[5][16] = { "Motor 1",                   // text messages displayed
                     "Motor 2",
                     "Increment level" };
int adc_key_val[5] = { 30, 150, 360, 535, 760 }; //analog levels of the buttons
int NUM_KEYS = 5;                                //number of keys avilable       
int adc_key_in;                                  //the analog value read
int key = -1;                                    //the number of the pressed key
int oldkey = -1;                                 //the number of previously pressed key 
int m1, m2 = 0;                                  //motor angle
int base = 1;                                    //angle increment level

void setup()
{
  lcd.init();     //initialize LCD
  lcd.printIn("2 DoF tilt stage");      //print on display
  
  servo1.attach(3);                     //attatch motors to pins
  servo2.attach(11);

  Serial.begin(9600);                   // start serial communication
}

void loop()
{
  adc_key_in = analogRead(0);    //read the analog value of the buttons
  key = get_key(adc_key_in);     //convert into key press

  if (key != oldkey)                   //if keypress is detected
  {
    delay(30);                        //debounce delay
    adc_key_in = analogRead(0);       // read the analog value of the buttons
    key = get_key(adc_key_in);        // convert into key press

    if (msgs[key] == msgs[0])        //each if statment is for a diffirent button
    {
      m1 = angleInc(m1, base, 1);   //sets the new angle of the motor to the variable
      if(m1<90)                     //bounds the first motor between 0 and 90 degrees
      m1=90;
      displayRefresh(0, m1);        //display the new angle on LCD
    }
    else if (msgs[key] == msgs[1])
    {
      m2 = angleInc(m2, base, 1);
      displayRefresh(1, m2);
    }
    else if (msgs[key] == msgs[2])
    {
      m2 = angleInc(m2, base, -1);
      displayRefresh(1, m2);
    }
    else if (msgs[key] == msgs[3])
    {
      m1 = angleInc(m1, base, -1);
      if(m1<90)
      m1=90;
      displayRefresh(0, m1);
    }
    else if (msgs[key] == msgs[4])
    {
      base++;
      if (base > 3)
        base = 1;

      displayRefresh(2, base+90);
    }
  }

  motorSerialRead();      //reads values from the serial port

  servo1.write(m1);       //sets the motors values
  servo2.write(m2);
}



int get_key(unsigned int input)     //Convert ADC value to key number
{
  int k;
  for (k = 0; k < NUM_KEYS; k++)
  {
    if (input < adc_key_val[k])   //if  ADC value < keys threshold value 
    {
      return k;
    }
  }

  if (k >= NUM_KEYS)            //if k is above keys threshold the condition accurs
  {
    k = -1;                    // No valid key pressed
    return k;
  }
}

int angleInc(int Val, int Base, int arth)     //takes previous value, base and arth to decide increment or decrement 
{
  int val = Val;
  int base;

  if (Base <= 1)        //sets the base of increment to 1
    base = Base * arth;
  else if (Base == 2)   //sets the base of increment to 5
    base = 5 * arth;
  else if (Base >= 3)   //sets the base of increment to 10
    base = 10 * arth;

  val = Val + base;     //increments the previous value

  if (val > 180)        //bound 0 <= value <= 180
    val = 180;
  else if (val < 0)
    val = 0;

  motorSerialWrite();   //sends the new value through the serial port
  return val;
}

void displayRefresh(int msgIndx, int val)   //refreshes the LCD with the new message and angle value
{
  char int2Char[4];                         //char array to hold the int value for conversion
  String(val-90).toCharArray(int2Char, 4);  //int to string conversion

  lcd.clear();                              //clears the LCD from previous message
  lcd.cursorTo(1, 0);                       //sets the curser to the first row
  lcd.printIn(msgs[msgIndx]);               //prints the message from the messages array

  lcd.cursorTo(2, 0);                       //sets the curser to the second row
  lcd.printIn(int2Char);                    //prints the angle value
}

void motorSerialRead()                      //reads the angle values form the serial port
{
  if(Serial.available()>0)
  {
    if (Serial.peek() == 'm')        //distinguishes the value of m1 from m2
    {
      Serial.read();                //deletes m
      m1 = Serial.parseInt()+90;    //sets the variable
      displayRefresh(0, (m1));      //refreshes the LCD
    }
    else if (Serial.peek() == 'M')
    {
      Serial.read();                //deletes M
      m2 = Serial.parseInt()+90;
      displayRefresh(1, (m2));
    }
    motorSerialWrite();
  }
}

void motorSerialWrite()     //sends the motor values through the serial port
{
  Serial.print('m');        //m and M are for the GUI to distinguish between the variables
  Serial.print(m1-90);
  Serial.print("\n");
  
  Serial.print('M');
  Serial.print(m2-90);
  Serial.print("\n");
}
