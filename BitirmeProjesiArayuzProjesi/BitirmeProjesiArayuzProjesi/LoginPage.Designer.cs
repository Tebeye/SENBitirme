using System.Drawing;

namespace BitirmeProjesiArayuzProjesi
{
    partial class LoginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_guest = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_adminPage = new System.Windows.Forms.Button();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.LightBlue;
            this.pnl_login.Controls.Add(this.btn_adminPage);
            this.pnl_login.Controls.Add(this.lbl_guest);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.textBox3);
            this.pnl_login.Controls.Add(this.textBox4);
            this.pnl_login.Controls.Add(this.label2);
            this.pnl_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(240, 320);
            this.pnl_login.TabIndex = 6;
            // 
            // lbl_guest
            // 
            this.lbl_guest.AutoSize = true;
            this.lbl_guest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_guest.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_guest.Location = new System.Drawing.Point(44, 213);
            this.lbl_guest.Name = "lbl_guest";
            this.lbl_guest.Size = new System.Drawing.Size(158, 19);
            this.lbl_guest.TabIndex = 10;
            this.lbl_guest.Text = "continue as a guest";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(72, 161);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(99, 29);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(60, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "password";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(60, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "username";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(204, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wind Tunnel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_adminPage
            // 
            this.btn_adminPage.BackColor = System.Drawing.Color.DarkRed;
            this.btn_adminPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adminPage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adminPage.Location = new System.Drawing.Point(12, 280);
            this.btn_adminPage.Name = "btn_adminPage";
            this.btn_adminPage.Size = new System.Drawing.Size(73, 21);
            this.btn_adminPage.TabIndex = 11;
            this.btn_adminPage.Text = "Admin Page";
            this.btn_adminPage.UseVisualStyleBackColor = false;
            this.btn_adminPage.Click += new System.EventHandler(this.btn_adminPage_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 313);
            this.Controls.Add(this.pnl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginPage_KeyPress);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_guest;
        private System.Windows.Forms.Button btn_adminPage;
    }
}

