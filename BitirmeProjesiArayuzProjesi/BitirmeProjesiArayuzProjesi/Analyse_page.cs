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
using ZedGraph;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
        
        string MyConnection2 = "Server=127.0.0.1;Database=new_schema;Uid=root;Pwd=BlVH5thGSFfHE209Nt4E;";
        int testId = 0;
        string Gelen = string.Empty;
        string[] ports = SerialPort.GetPortNames();
        // 1
        GraphPane myPane = new GraphPane();
        RollingPointPairList listPointsOne = new RollingPointPairList(40);
        LineItem myCurveOne;
        RollingPointPairList listPointsTwo = new RollingPointPairList(40);
        LineItem myCurveTwo;
        RollingPointPairList listPointsThree = new RollingPointPairList(40);
        LineItem myCurveThree;

        int old_test_id;
        int hataliPaketSayisi = 0;
        int counter = 0;
        static Byte[] cozulen_paket = new Byte[8];
        SerialPort mySerialPort;
        static int gelenveri;
        static char gelen_veri;
        public SerialPort _serialPort;
        public Analyse_page()
        {
          
   
            InitializeComponent();
            timer_arduino.Enabled = false;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 25;
            zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            dataGridView_test_history.Visible = false;
            


            try
            {
                mySerialPort = new SerialPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }





        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            SerialPort sp = (SerialPort)sender;
            try
            {
                mySerialPort.Read(cozulen_paket, 0, 8);
            }
            catch (Exception ex)
            {

                MessageBox.Show((string)("Please wait..."));
                return;

            }
            paketCozme myVar = paketCozme.BirinciDogrulama;
            for (int i = 0; i < cozulen_paket.Length; i++)
            {


                if (myVar == paketCozme.Veriler)
                {
                    if (i >= 7)
                    {
                        hataliPaketSayisi++;
                    }
                    else
                    {
                        gelenveri = cozulen_paket[i];
                    }
                    myVar = paketCozme.BirinciDogrulama;
                    continue;
                }

                if (myVar == paketCozme.BirinciDogrulama && cozulen_paket[i] == 0xAB)
                {
                    myVar = paketCozme.İkinciDogrulama;
                }
                else if (myVar == paketCozme.İkinciDogrulama && cozulen_paket[i] == 0xFD)
                {
                    myVar = paketCozme.Veriler;
                }
                else
                {
                    myVar = paketCozme.BirinciDogrulama;
                }



                /*switch (myVar)
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
                        if (i >= 7)
                        {
                            hataliPaketSayisi++;
                        }
                        else
                        {
                            gelenveri = cozulen_paket[i];

                            // gelenveri = cozulen_paket[i];
                        }
                        myVar = paketCozme.BirinciDogrulama;
                        break;
                }*/
            }



        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_arduino_Tick(object sender, EventArgs e)
        {
            
            try
            {
               MySqlConnection connection = new MySqlConnection(MyConnection2);
                connection.Open();            
                //Add incoming datas to database_data.
                MySqlCommand dataCmd = new MySqlCommand();
                dataCmd.Connection = connection;
                dataCmd.CommandText = "INSERT INTO data(velocity,tests_test_id) VALUES(@velocity,@test_test_id)";
                dataCmd.Prepare();
                dataCmd.Parameters.AddWithValue("@velocity", gelenveri);
                dataCmd.Parameters.AddWithValue("@test_test_id", testId);
                dataCmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


          
            
            labelGuncelleme();
            counter++;
            double x = Convert.ToDouble(counter);
            double y1 = Convert.ToDouble(gelenveri);
            listPointsOne.Add(x, y1);
            myCurveOne = myPane.AddCurve(null, listPointsOne, Color.Blue, SymbolType.Circle);
            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void lbl_arduino_raw_data_Click(object sender, EventArgs e)
        {

        }
        private void labelGuncelleme()
        {
            lbl_arduino_raw_data.Text = "X koordinati : " + gelenveri.ToString();
        }

        private void Analyse_page_Load(object sender, EventArgs e)
        {
            //1
            myPane = zedGraphControl1.GraphPane;

            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Data";
            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();


            /* Adding connected ports */
            foreach (string port in ports)
            {
                cbComPort.Items.Add(port);
            }
            /* Baudrates are added */
            cbBaud.Items.Add("2400");
            cbBaud.Items.Add("4800");
            cbBaud.Items.Add("9600");
            cbBaud.Items.Add("19200");
            cbBaud.Items.Add("38400");
            cbBaud.Items.Add("57600");
            cbBaud.Items.Add("115200");
            cbBaud.SelectedIndex = 2;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen == false)
            {
                if (cbComPort.Text == "")
                    return;
                mySerialPort.PortName = cbComPort.Text;
                mySerialPort.BaudRate = Convert.ToInt32(cbBaud.Text);
                try
                {
                    mySerialPort.Parity = Parity.None;
                    mySerialPort.StopBits = StopBits.One;
                    mySerialPort.DataBits = 8;
                    mySerialPort.Handshake = Handshake.None;
                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    mySerialPort.Open();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error:" + er.Message);
                }
            }
            else
            {
                //rtbEkran.Text = "seriport already open";
            }
        }

        private void Analyse_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mySerialPort.IsOpen == true)
            {
                mySerialPort.Close();
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen == true)
            {
                mySerialPort.Close();
            }
        }

        private void timer_yedekleme_Tick(object sender, EventArgs e)
        {

        }

        private void btn_speed_start_Click(object sender, EventArgs e)
        {
            
             MySqlConnection connection = new MySqlConnection(MyConnection2);
           
       

            try
            {
               
                connection.Open();
                MySqlCommand testCmd = new MySqlCommand();
                testCmd.Connection = connection;
                testCmd.CommandText = "INSERT INTO tests( start_time, test_status) VALUES(@start_time,@test_status)";
                testCmd.Prepare();
                //   testCmd.Parameters.AddWithValue("@test_id", testId);
                testCmd.Parameters.AddWithValue("@start_time", DateTime.Now);
                testCmd.Parameters.AddWithValue("@test_status", 1);
                testCmd.ExecuteNonQuery();
                testId = (int)testCmd.LastInsertedId;    //Eklenen son ID'Li şey
                connection.Close();
                timer_arduino.Enabled = true;
                //timer_arduino.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            
        }

        private void btn_speed_stop_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnection2);

            try
            {
                //timer_arduino.Stop();
                timer_arduino.Enabled = false;
                connection.Open();
                MySqlCommand testCmd = new MySqlCommand();
                testCmd.Connection = connection;
                testCmd.CommandText = "UPDATE tests SET test_status=@status, end_time=@end_time WHERE test_status=1";
                testCmd.Prepare();
                testCmd.Parameters.AddWithValue("@status", 0);
                testCmd.Parameters.AddWithValue("@end_time", DateTime.Now);
                testCmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        private void btn_current_test_Click(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = true;
            btn_speed_start.Visible = true;
            btn_speed_stop.Visible = true;
            btn_reset_speed.Visible = true;
            dataGridView_test_history.Visible = false;

        }

        private void btn_test_history_Click(object sender, EventArgs e)
        {

            zedGraphControl1.Visible = false;
            btn_speed_start.Visible = false;
            btn_speed_stop.Visible = false;
            btn_reset_speed.Visible = false;
            dataGridView_test_history.Visible = true;


            MySqlConnection connection = new MySqlConnection(MyConnection2);

            try
            {
                connection.Open();
                string stm = "SELECT test_id, start_time, end_time FROM tests Where test_status=0";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(stm, connection);
                DataSet table = new DataSet();
                dataAdapter.Fill(table, "tests");


                dataGridView_test_history.DataSource = table.Tables["tests"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }





        }

      

        private void dataGridView_test_history_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_test_history.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                old_test_id = Convert.ToInt32(dataGridView_test_history.Rows[e.RowIndex].Cells[0].Value);
            }

            MySqlConnection connection = new MySqlConnection(MyConnection2);

            try
            {
                connection.Open();
                string query = "SELECT data_id, velocity FROM data Where tests_test_id=@old_test_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                //sorguma bir parametre ekliyorum o da bu olsun diyorum
                myCommand.Parameters.Add(new MySqlParameter("@old_test_id", old_test_id));
                dataAdapter.SelectCommand = myCommand;
                DataSet table = new DataSet();
                dataAdapter.Fill(table, "data");
                dataGridView_test_history.DataSource = table.Tables["data"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
        }

     
    }
}
