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

        private void btn_login_Click(object sender, EventArgs e)
        {
            Analyse_page newAnalysePage = new Analyse_page();
            this.Visible = false;
            newAnalysePage.Visible = true;
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
    }
}
