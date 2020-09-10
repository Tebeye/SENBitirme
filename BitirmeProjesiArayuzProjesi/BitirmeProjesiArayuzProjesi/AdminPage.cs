using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BitirmeProjesiArayuzProjesi
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            Size = new Size(470, 280);

            panel_showuser.Location = panel_adduser.Location;

        }


        private void changePanel(Panel panel)
        {
            panel_adduser.Visible = false;
            panel_showuser.Visible = false;
            panel.Visible = true;

        }






        string MyConnection2 = "Server=127.0.0.1;Database=new_schema;Uid=root;Pwd=BlVH5thGSFfHE209Nt4E;";

        private void btn_add_user_Click(object sender, EventArgs e)
        {

           
            string username = textBox_username.Text;
            string password = textBox_password.Text;


           

            MySqlConnection connection = new MySqlConnection(MyConnection2);
            connection.Open();
            //Add incoming datas to database_data.
            MySqlCommand dataCmd = new MySqlCommand();
            dataCmd.Connection = connection;
            dataCmd.CommandText = "INSERT INTO users(username,password) VALUES(@username,@password)";
            dataCmd.Prepare();
            dataCmd.Parameters.AddWithValue("@username", username);
            dataCmd.Parameters.AddWithValue("@password", password);
            dataCmd.ExecuteNonQuery();
            connection.Close();
            textBox_username.Text = "";
            textBox_password.Text = "";
            MessageBox.Show("User Added!");
            


        }


        private void btn_add_user_tab_Click(object sender, EventArgs e)
        {
            changePanel(panel_adduser);
        }

        private void btn_users_tab_Click_1(object sender, EventArgs e)
        {
            changePanel(panel_showuser);
            MySqlConnection connection = new MySqlConnection(MyConnection2);

            try
            {
                connection.Open();
                string stm = "SELECT user_id,username , password FROM users";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(stm, connection);
                DataSet table = new DataSet();
                dataAdapter.Fill(table, "tests");

                dataGridView_showuser.DataSource = table.Tables["tests"];
                dataGridView_showuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }

        }
    }
}
