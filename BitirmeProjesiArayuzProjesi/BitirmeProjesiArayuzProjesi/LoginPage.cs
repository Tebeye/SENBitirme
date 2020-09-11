using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BitirmeProjesiArayuzProjesi
{
    public partial class LoginPage : Form
    {

        string RecoveryMain = "OdpWgnthH0xD2zJpUmd51DqBs1wy9sBqxdIhmFBycTQ9usNKui";
        public LoginPage()
        {
            InitializeComponent();
        }


        Pen p = new Pen(Color.Red);

        public static Boolean userLogged = false;

        public class UserIsNotValidException : Exception
        {
            public UserIsNotValidException(string message) : base(message)
            {
            }
        }
        public class UserNamePassword
        {
            public void checkUserNamePassword(object username, object password ,string usernameDB ,string passDB)
            {
                

 

                if (username.ToString() == usernameDB && password.ToString() == passDB)
                {
                    userLogged = true;
                }
                else
                {
                    throw (new UserIsNotValidException("Username or password is wrong"));
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            string MyConnection2 = "Server=127.0.0.1;Database=new_schema;Uid=root;Pwd=BlVH5thGSFfHE209Nt4E;";
            string query = "SELECT * FROM users where username=@username";
            MySqlConnection connection = new MySqlConnection(MyConnection2);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            command.Parameters.AddWithValue("@username", textBox4.Text);
            myAdapter.SelectCommand = command;
            DataTable table = new DataTable();
            myAdapter.Fill(table);

            // Bütün tabloyu alıp aynı mysql "where" kısmı gibi içinden veri aratabilirsin
            DataRow[] row = table.Select();
            // altta row[0] var. Burası sürekli böyle kalıcak içinden username veya başka bir sütun çekebilirsin
             


            string password = row[0]["password"].ToString();
            string username = row[0]["username"].ToString();

            try
            {
                UserNamePassword user = new UserNamePassword();
                user.checkUserNamePassword(textBox4.Text, textBox3.Text,username, password);
            }
            catch (UserIsNotValidException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (userLogged)
                {
                    Analyse_page newAnalysePage = new Analyse_page();
                    this.Visible = false;
                    newAnalysePage.Visible = true;
                }
            }
        }

        private void LoginPage_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                Analyse_page newAnalysePage = new Analyse_page();
                this.Visible = false;
                newAnalysePage.Visible = true;
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Analyse_page newAnalysePage = new Analyse_page();
                this.Visible = false;
                newAnalysePage.Visible = true;
            }
        }

        private void btn_adminPage_Click(object sender, EventArgs e)
        {

            string pathUsb="Path";
            DriveInfo[] mydrives = DriveInfo.GetDrives();
            foreach (DriveInfo mydrive in mydrives)
            {
                //Check for removable devices like USB's
                if (mydrive.DriveType == DriveType.Removable)
                {
                    //Check for that specific USB
                    if (mydrive.VolumeLabel.Equals("WINDTUNNEL"))
                    {
                        DirectoryInfo path = mydrive.RootDirectory;
                        pathUsb= Path.GetFullPath(path.ToString());
                       
                    }
                }
            }
            string usbRecovery = System.IO.File.ReadAllText(@pathUsb + "RecoveryKey.txt");







            if (usbRecovery==RecoveryMain)
            {

                AdminPage newAdminPage = new AdminPage();
                this.Visible = true;
                newAdminPage.Visible = true;
            }
            else
            {
                MessageBox.Show("Recovery key does not match!");
            }





        }
    }
}
