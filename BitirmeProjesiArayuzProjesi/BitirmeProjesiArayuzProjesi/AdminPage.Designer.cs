namespace BitirmeProjesiArayuzProjesi
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_adminPage = new System.Windows.Forms.Panel();
            this.panel_adduser = new System.Windows.Forms.Panel();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_users_tab = new System.Windows.Forms.Button();
            this.btn_add_user_tab = new System.Windows.Forms.Button();
            this.panel_showuser = new System.Windows.Forms.Panel();
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.dataGridView_showuser = new System.Windows.Forms.DataGridView();
            this.pnl_adminPage.SuspendLayout();
            this.panel_adduser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_showuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showuser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_adminPage
            // 
            this.pnl_adminPage.Controls.Add(this.panel_adduser);
            this.pnl_adminPage.Controls.Add(this.panel1);
            this.pnl_adminPage.Location = new System.Drawing.Point(12, 12);
            this.pnl_adminPage.Name = "pnl_adminPage";
            this.pnl_adminPage.Size = new System.Drawing.Size(436, 217);
            this.pnl_adminPage.TabIndex = 0;
            // 
            // panel_adduser
            // 
            this.panel_adduser.Controls.Add(this.btn_add_user);
            this.panel_adduser.Controls.Add(this.lbl_password);
            this.panel_adduser.Controls.Add(this.textBox_password);
            this.panel_adduser.Controls.Add(this.lbl_username);
            this.panel_adduser.Controls.Add(this.textBox_username);
            this.panel_adduser.Location = new System.Drawing.Point(101, 6);
            this.panel_adduser.Name = "panel_adduser";
            this.panel_adduser.Size = new System.Drawing.Size(328, 204);
            this.panel_adduser.TabIndex = 1;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(110, 84);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(100, 23);
            this.btn_add_user.TabIndex = 4;
            this.btn_add_user.Text = "Add User to Database";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(41, 48);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(110, 45);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(41, 22);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(63, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User Name:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(110, 19);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_users_tab);
            this.panel1.Controls.Add(this.btn_add_user_tab);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 207);
            this.panel1.TabIndex = 0;
            // 
            // btn_users_tab
            // 
            this.btn_users_tab.Location = new System.Drawing.Point(3, 41);
            this.btn_users_tab.Name = "btn_users_tab";
            this.btn_users_tab.Size = new System.Drawing.Size(86, 23);
            this.btn_users_tab.TabIndex = 2;
            this.btn_users_tab.Text = "Users";
            this.btn_users_tab.UseVisualStyleBackColor = true;
            this.btn_users_tab.Click += new System.EventHandler(this.btn_users_tab_Click_1);
            // 
            // btn_add_user_tab
            // 
            this.btn_add_user_tab.Location = new System.Drawing.Point(3, 3);
            this.btn_add_user_tab.Name = "btn_add_user_tab";
            this.btn_add_user_tab.Size = new System.Drawing.Size(86, 23);
            this.btn_add_user_tab.TabIndex = 1;
            this.btn_add_user_tab.Text = "Add User";
            this.btn_add_user_tab.UseVisualStyleBackColor = true;
            this.btn_add_user_tab.Click += new System.EventHandler(this.btn_add_user_tab_Click);
            // 
            // panel_showuser
            // 
            this.panel_showuser.Controls.Add(this.btn_delete_user);
            this.panel_showuser.Controls.Add(this.dataGridView_showuser);
            this.panel_showuser.Location = new System.Drawing.Point(472, 18);
            this.panel_showuser.Name = "panel_showuser";
            this.panel_showuser.Size = new System.Drawing.Size(328, 204);
            this.panel_showuser.TabIndex = 5;
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.Location = new System.Drawing.Point(22, 176);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_user.TabIndex = 1;
            this.btn_delete_user.Text = "Detele User";
            this.btn_delete_user.UseVisualStyleBackColor = true;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // dataGridView_showuser
            // 
            this.dataGridView_showuser.AllowUserToAddRows = false;
            this.dataGridView_showuser.AllowUserToDeleteRows = false;
            this.dataGridView_showuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showuser.Location = new System.Drawing.Point(22, 19);
            this.dataGridView_showuser.Name = "dataGridView_showuser";
            this.dataGridView_showuser.ReadOnly = true;
            this.dataGridView_showuser.Size = new System.Drawing.Size(287, 150);
            this.dataGridView_showuser.TabIndex = 0;
            this.dataGridView_showuser.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_showuser_CellMouseClick);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 241);
            this.Controls.Add(this.panel_showuser);
            this.Controls.Add(this.pnl_adminPage);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.pnl_adminPage.ResumeLayout(false);
            this.panel_adduser.ResumeLayout(false);
            this.panel_adduser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_showuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_adminPage;
        private System.Windows.Forms.Panel panel_adduser;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_user_tab;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Panel panel_showuser;
        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.DataGridView dataGridView_showuser;
        private System.Windows.Forms.Button btn_users_tab;
    }
}