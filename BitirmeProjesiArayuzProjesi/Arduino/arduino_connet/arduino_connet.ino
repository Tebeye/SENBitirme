int analogPin = A3; // potentiometer wiper (middle terminal) connected to analog pin 3
                    // outside leads to ground and +5V
int val = 0;  // variable to store the value read
int valMapped = 0;
long metre_saniye = 0;
void setup() {
  Serial.begin(9600);           //  setup serial
  TCNT1 = 63974;   // for 1 sec at 16 MHz 

  TCCR1A = 0x00;
  TCCR1B = (1<<CS10) | (1<<CS12);  // Timer mode with 1024 prescler
  TIMSK1 = (1 << TOIE1) ;   // Enable timer1 overflow interrupt(TOIE1)
  sei();        // Enable global interrupts by setting global interrupt enable bit in SREG
  
}

void loop() {
    val = analogRead(analogPin);  // read the input pin
    valMapped=  map(val,83,142,0,22);    // Analog sinyal değerini 0-255 aralığına daraltıyoruz.
    if(valMapped < 0){

      valMapped = 0;
    }

}

ISR (TIMER1_OVF_vect)    // Timer1 ISR
{
  //Serial.write(0xAB);
//Serial.write(0xFD);
Serial.write(valMapped);
  TCNT1 = 63974;   // for 1 sec at 16 MHz
}
