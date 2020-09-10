namespace BitirmeProjesiArayuzProjesi
{
    partial class Analyse_page
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_closeApplication = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_test_history = new System.Windows.Forms.Button();
            this.btn_volt_amper = new System.Windows.Forms.Button();
            this.btn_current_test = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btn_reset_speed = new System.Windows.Forms.Button();
            this.btn_speed_stop = new System.Windows.Forms.Button();
            this.btn_speed_start = new System.Windows.Forms.Button();
            this.btn_changeLanguage = new System.Windows.Forms.Button();
            this.lbl_arduino_raw_data = new System.Windows.Forms.Label();
            this.timer_arduino = new System.Windows.Forms.Timer(this.components);
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_baudrate = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.timer_yedekleme = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_current_test = new System.Windows.Forms.Panel();
            this.debugLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_test_history = new System.Windows.Forms.DataGridView();
            this.panel_test_history = new System.Windows.Forms.Panel();
            this.return_click = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_current_test.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test_history)).BeginInit();
            this.panel_test_history.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(349, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wind Tunnel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_closeApplication
            // 
            this.btn_closeApplication.Location = new System.Drawing.Point(3, 147);
            this.btn_closeApplication.Name = "btn_closeApplication";
            this.btn_closeApplication.Size = new System.Drawing.Size(145, 30);
            this.btn_closeApplication.TabIndex = 4;
            this.btn_closeApplication.Text = "Close Application";
            this.btn_closeApplication.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(3, 111);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(145, 30);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_test_history
            // 
            this.btn_test_history.Location = new System.Drawing.Point(3, 75);
            this.btn_test_history.Name = "btn_test_history";
            this.btn_test_history.Size = new System.Drawing.Size(145, 30);
            this.btn_test_history.TabIndex = 2;
            this.btn_test_history.Text = "Test History";
            this.btn_test_history.UseVisualStyleBackColor = true;
            this.btn_test_history.Click += new System.EventHandler(this.btn_test_history_Click);
            // 
            // btn_volt_amper
            // 
            this.btn_volt_amper.Location = new System.Drawing.Point(3, 39);
            this.btn_volt_amper.Name = "btn_volt_amper";
            this.btn_volt_amper.Size = new System.Drawing.Size(145, 30);
            this.btn_volt_amper.TabIndex = 1;
            this.btn_volt_amper.Text = "Volt / Amper";
            this.btn_volt_amper.UseVisualStyleBackColor = true;
            // 
            // btn_current_test
            // 
            this.btn_current_test.Location = new System.Drawing.Point(3, 3);
            this.btn_current_test.Name = "btn_current_test";
            this.btn_current_test.Size = new System.Drawing.Size(145, 30);
            this.btn_current_test.TabIndex = 0;
            this.btn_current_test.Text = "Current Test";
            this.btn_current_test.UseVisualStyleBackColor = true;
            this.btn_current_test.Click += new System.EventHandler(this.btn_current_test_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsEnableWheelZoom = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(738, 297);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // btn_reset_speed
            // 
            this.btn_reset_speed.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_reset_speed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset_speed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_reset_speed.Location = new System.Drawing.Point(594, 307);
            this.btn_reset_speed.Name = "btn_reset_speed";
            this.btn_reset_speed.Size = new System.Drawing.Size(147, 45);
            this.btn_reset_speed.TabIndex = 4;
            this.btn_reset_speed.Text = "RESET";
            this.btn_reset_speed.UseVisualStyleBackColor = false;
            // 
            // btn_speed_stop
            // 
            this.btn_speed_stop.BackColor = System.Drawing.Color.Red;
            this.btn_speed_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_speed_stop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_speed_stop.Location = new System.Drawing.Point(441, 307);
            this.btn_speed_stop.Name = "btn_speed_stop";
            this.btn_speed_stop.Size = new System.Drawing.Size(147, 45);
            this.btn_speed_stop.TabIndex = 1;
            this.btn_speed_stop.Text = "Stop";
            this.btn_speed_stop.UseVisualStyleBackColor = false;
            this.btn_speed_stop.Click += new System.EventHandler(this.btn_speed_stop_Click);
            // 
            // btn_speed_start
            // 
            this.btn_speed_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_speed_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_speed_start.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_speed_start.Location = new System.Drawing.Point(288, 307);
            this.btn_speed_start.Name = "btn_speed_start";
            this.btn_speed_start.Size = new System.Drawing.Size(147, 45);
            this.btn_speed_start.TabIndex = 0;
            this.btn_speed_start.Text = "Start";
            this.btn_speed_start.UseVisualStyleBackColor = false;
            this.btn_speed_start.Click += new System.EventHandler(this.btn_speed_start_Click);
            // 
            // btn_changeLanguage
            // 
            this.btn_changeLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_changeLanguage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_changeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changeLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_changeLanguage.Location = new System.Drawing.Point(823, 19);
            this.btn_changeLanguage.Name = "btn_changeLanguage";
            this.btn_changeLanguage.Size = new System.Drawing.Size(75, 23);
            this.btn_changeLanguage.TabIndex = 2;
            this.btn_changeLanguage.Text = "TR / EN";
            this.btn_changeLanguage.UseVisualStyleBackColor = false;
            this.btn_changeLanguage.Click += new System.EventHandler(this.btn_changeLanguage_Click);
            // 
            // lbl_arduino_raw_data
            // 
            this.lbl_arduino_raw_data.AutoSize = true;
            this.lbl_arduino_raw_data.Location = new System.Drawing.Point(755, 18);
            this.lbl_arduino_raw_data.Name = "lbl_arduino_raw_data";
            this.lbl_arduino_raw_data.Size = new System.Drawing.Size(57, 13);
            this.lbl_arduino_raw_data.TabIndex = 1;
            this.lbl_arduino_raw_data.Text = "VERI YOK";
            this.lbl_arduino_raw_data.Click += new System.EventHandler(this.lbl_arduino_raw_data_Click);
            // 
            // timer_arduino
            // 
            this.timer_arduino.Enabled = true;
            this.timer_arduino.Interval = 500;
            this.timer_arduino.Tick += new System.EventHandler(this.timer_arduino_Tick);
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(66, 15);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 21);
            this.cbComPort.TabIndex = 4;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(282, 15);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 21);
            this.cbBaud.TabIndex = 5;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(20, 18);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(40, 13);
            this.lbl_port.TabIndex = 6;
            this.lbl_port.Text = "PORT ";
            // 
            // lbl_baudrate
            // 
            this.lbl_baudrate.AutoSize = true;
            this.lbl_baudrate.Location = new System.Drawing.Point(210, 18);
            this.lbl_baudrate.Name = "lbl_baudrate";
            this.lbl_baudrate.Size = new System.Drawing.Size(66, 13);
            this.lbl_baudrate.TabIndex = 8;
            this.lbl_baudrate.Text = "BAUDRATE";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(484, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(565, 13);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(90, 23);
            this.btn_disconnect.TabIndex = 10;
            this.btn_disconnect.Text = "DISCONNECT";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // timer_yedekleme
            // 
            this.timer_yedekleme.Enabled = true;
            this.timer_yedekleme.Tick += new System.EventHandler(this.timer_yedekleme_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_changeLanguage);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 45);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_current_test);
            this.panel2.Controls.Add(this.btn_volt_amper);
            this.panel2.Controls.Add(this.btn_test_history);
            this.panel2.Controls.Add(this.btn_settings);
            this.panel2.Controls.Add(this.btn_closeApplication);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 362);
            this.panel2.TabIndex = 12;
            // 
            // panel_current_test
            // 
            this.panel_current_test.Controls.Add(this.debugLabel);
            this.panel_current_test.Controls.Add(this.zedGraphControl1);
            this.panel_current_test.Controls.Add(this.btn_reset_speed);
            this.panel_current_test.Controls.Add(this.btn_speed_start);
            this.panel_current_test.Controls.Add(this.btn_speed_stop);
            this.panel_current_test.Location = new System.Drawing.Point(168, 81);
            this.panel_current_test.Name = "panel_current_test";
            this.panel_current_test.Size = new System.Drawing.Size(744, 363);
            this.panel_current_test.TabIndex = 13;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(85, 323);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(35, 13);
            this.debugLabel.TabIndex = 5;
            this.debugLabel.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbComPort);
            this.panel4.Controls.Add(this.lbl_arduino_raw_data);
            this.panel4.Controls.Add(this.cbBaud);
            this.panel4.Controls.Add(this.lbl_port);
            this.panel4.Controls.Add(this.btn_disconnect);
            this.panel4.Controls.Add(this.lbl_baudrate);
            this.panel4.Controls.Add(this.btn_connect);
            this.panel4.Location = new System.Drawing.Point(12, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 48);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView_test_history
            // 
            this.dataGridView_test_history.AllowUserToAddRows = false;
            this.dataGridView_test_history.AllowUserToDeleteRows = false;
            this.dataGridView_test_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_test_history.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_test_history.Name = "dataGridView_test_history";
            this.dataGridView_test_history.ReadOnly = true;
            this.dataGridView_test_history.Size = new System.Drawing.Size(582, 331);
            this.dataGridView_test_history.TabIndex = 5;
            this.dataGridView_test_history.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_test_history_CellMouseDoubleClick);
            // 
            // panel_test_history
            // 
            this.panel_test_history.Controls.Add(this.return_click);
            this.panel_test_history.Controls.Add(this.dataGridView_test_history);
            this.panel_test_history.Location = new System.Drawing.Point(933, 81);
            this.panel_test_history.Name = "panel_test_history";
            this.panel_test_history.Size = new System.Drawing.Size(744, 363);
            this.panel_test_history.TabIndex = 14;
            // 
            // return_click
            // 
            this.return_click.BackgroundImage = global::BitirmeProjesiArayuzProjesi.Properties.Resources.returnPng;
            this.return_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_click.Location = new System.Drawing.Point(591, 296);
            this.return_click.Name = "return_click";
            this.return_click.Size = new System.Drawing.Size(45, 38);
            this.return_click.TabIndex = 6;
            this.return_click.Click += new System.EventHandler(this.return_Click_event);
            // 
            // Analyse_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1757, 511);
            this.Controls.Add(this.panel_test_history);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_current_test);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Analyse_page";
            this.Text = "Analyse_page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Analyse_page_FormClosed);
            this.Load += new System.EventHandler(this.Analyse_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_current_test.ResumeLayout(false);
            this.panel_current_test.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test_history)).EndInit();
            this.panel_test_history.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_closeApplication;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_test_history;
        private System.Windows.Forms.Button btn_volt_amper;
        private System.Windows.Forms.Button btn_current_test;
        private System.Windows.Forms.Button btn_changeLanguage;
        private System.Windows.Forms.Button btn_reset_speed;
        private System.Windows.Forms.Button btn_speed_stop;
        private System.Windows.Forms.Button btn_speed_start;
        private System.Windows.Forms.Label lbl_arduino_raw_data;
        private System.Windows.Forms.Timer timer_arduino;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_baudrate;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Timer timer_yedekleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_current_test;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_test_history;
        private System.Windows.Forms.Panel panel_test_history;
        private System.Windows.Forms.Panel return_click;
        private System.Windows.Forms.Label debugLabel;
    }
}