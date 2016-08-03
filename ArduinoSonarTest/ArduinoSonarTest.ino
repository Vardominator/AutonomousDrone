// Ultrasonic - Library for HR-SC04 Ultrasonic Ranging Module.
// Rev.4 (06/2012)
// J.Rodrigo ( www.jrodrigo.net )
// more info at www.ardublog.com

#include <Ultrasonic.h>

Ultrasonic ultraleft(11,10);   // (Trig PIN,Echo PIN)
//Ultrasonic ultraright(6,7);  // (Trig PIN,Echo PIN)

void setup() {
  Serial.begin(9600); 
}

void loop()
{
  //Serial.print("Left: ");
  Serial.print("S:");
  Serial.print(ultraleft.Ranging(CM)); Serial.print(",");
  Serial.print(ultraleft.Ranging(CM)); Serial.print(",");
  Serial.print(ultraleft.Ranging(CM)); Serial.print(",");
  Serial.print(ultraleft.Ranging(CM)); Serial.print(",");
  Serial.print(ultraleft.Ranging(CM)); Serial.println(";");
  //Serial.print(" cm     " );
  delay(40);
  //Serial.print("Right: ");
  //Serial.print(ultraright.Ranging(CM)); // CM or INC
  //Serial.println(" cm" );
  //delay(50);
}
