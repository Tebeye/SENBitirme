# SENBitirme
A GUI has been created purpose of analyzing data of an analog sensor which is a wind sensor and record that data in a SQL Database.
The microcontroller selected as an Arduino UNO. Microcontroller takes the data from sensor via Analog Pins (in our project A3),
then It sends the packets to a certain "Serial port" with the connection cable to the computer at regular intervals by 
means of the timer programmed inside.
The GUI analyzes the incoming analog data after a certain verification, draws it graphically and saves it to the database. 
