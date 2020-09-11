using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitirmeProjesiArayuzProjesi
{
    public partial class LoginPage : Form
    {
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
            public void checkUserNamePassword(object username, object password)
            {

                if (username.ToString() == "username" && password.ToString() == "password")
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

            try
            {
                UserNamePassword user = new UserNamePassword();
                user.checkUserNamePassword(textBox4.Text, textBox3.Text);
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
            
            AdminPage newAdminPage = new AdminPage();
            this.Visible = false;
            newAdminPage.Visible = true;
        }
    }
}
