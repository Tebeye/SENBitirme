using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
enum paketCozme
{
    BirinciDogrulama,
    İkinciDogrulama,
    Veriler
}

namespace BitirmeProjesiArayuzProjesi
{
    public partial class Analyse_page : Form
    {
        static Byte[] cozulen_paket = new Byte[8];
        static int gelenveri;
        static char gelen_veri;
        public SerialPort _serialPort;
        public Analyse_page()
        {
            InitializeComponent();
            SerialPort mySerialPort = new SerialPort("COM4");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();
        }

 


    
    private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

        SerialPort sp = (SerialPort)sender;

            sp.Read(cozulen_paket,0,8);

            paketCozme myVar = paketCozme.BirinciDogrulama;
            for(int i = 0; i < cozulen_paket.Length; i++)
            {
                switch (myVar)
                {
                    case paketCozme.BirinciDogrulama:
                        if (cozulen_paket[i] == 0xAB)
                        {
                            myVar = paketCozme.İkinciDogrulama;
                        }
                        else
                        {
                            myVar = paketCozme.BirinciDogrulama;
                        }
                        break;

                    case paketCozme.İkinciDogrulama:
                        if (cozulen_paket[i] == 0xFD)
                        {
                            myVar = paketCozme.Veriler;
                        }
                        else
                        {
                            myVar = paketCozme.BirinciDogrulama;
                        }
                        break;
                    case paketCozme.Veriler:
                        gelenveri = cozulen_paket[i];
                        gelenveri |= cozulen_paket[i + 1] << 8;

                        myVar = paketCozme.BirinciDogrulama;
                        break;
                }
            }



        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_arduino_Tick(object sender, EventArgs e)
        {
            labelGuncelleme();


        }

        private void lbl_arduino_raw_data_Click(object sender, EventArgs e)
        {
           
        }
        private void labelGuncelleme()
        {
            lbl_arduino_raw_data.Text =   "X koordinati : " + gelenveri.ToString() ;
        }
    }
}
