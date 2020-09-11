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
        Form loginPage;

        public AdminPage(Form form)
        {
            InitializeComponent();
            Size = new Size(470, 280);

            panel_showuser.Size = panel_adduser.Size;
            panel_showuser.Location = panel_adduser.Location;
            changePanel(panel_adduser);
            loginPage = form;
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
            MySqlCommand userCMD = new MySqlCommand();
            userCMD.Connection = connection;
            userCMD.CommandText = "INSERT INTO users(username,password) VALUES(@username,@password)";
            userCMD.Prepare();
            userCMD.Parameters.AddWithValue("@username", username);
            userCMD.Parameters.AddWithValue("@password", password);
            userCMD.ExecuteNonQuery();
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
                dataAdapter.Fill(table, "users");

                dataGridView_showuser.DataSource = table.Tables["users"];
                dataGridView_showuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }

        }
        int user_id;
        private void dataGridView_showuser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              if (e.ColumnIndex < 0 || e.RowIndex < 0)
              {
                  return;
              }

            //dataGridView_clickable = false;

            if (dataGridView_showuser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                user_id = Convert.ToInt32(dataGridView_showuser.Rows[e.RowIndex].Cells[0].Value);
            }

           

        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MyConnection2);

            try
            {

                connection.Open();
                MySqlCommand deleteUserCMD = new MySqlCommand();
                deleteUserCMD.Connection = connection;
                deleteUserCMD.CommandText = "delete from users where user_id=@userid";
                deleteUserCMD.Prepare();
                //   testCmd.Parameters.AddWithValue("@test_id", testId);
                deleteUserCMD.Parameters.AddWithValue("@userid", user_id);
                deleteUserCMD.ExecuteNonQuery();
                

               
                string stm = "SELECT user_id,username , password FROM users";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(stm, connection);
                DataSet table = new DataSet();
                dataAdapter.Fill(table, "users");
                dataGridView_showuser.DataSource = table.Tables["users"];
                dataGridView_showuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPage.Visible = true;
        }
    }
}
