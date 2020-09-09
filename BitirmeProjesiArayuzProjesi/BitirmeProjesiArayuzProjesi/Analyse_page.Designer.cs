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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_volt_amper = new System.Windows.Forms.Button();
            this.btn_current_test = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btn_reset_speed = new System.Windows.Forms.Button();
            this.btn_speed_stop = new System.Windows.Forms.Button();
            this.btn_speed_start = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.73373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.3515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.6485F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 679);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wind Tunnel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_volt_amper, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_current_test, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 355);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(3, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Close Application";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(3, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(3, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Old Test";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_volt_amper
            // 
            this.btn_volt_amper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volt_amper.Location = new System.Drawing.Point(3, 74);
            this.btn_volt_amper.Name = "btn_volt_amper";
            this.btn_volt_amper.Size = new System.Drawing.Size(128, 65);
            this.btn_volt_amper.TabIndex = 1;
            this.btn_volt_amper.Text = "Volt / Amper";
            this.btn_volt_amper.UseVisualStyleBackColor = true;
            // 
            // btn_current_test
            // 
            this.btn_current_test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_current_test.Location = new System.Drawing.Point(3, 3);
            this.btn_current_test.Name = "btn_current_test";
            this.btn_current_test.Size = new System.Drawing.Size(128, 65);
            this.btn_current_test.TabIndex = 0;
            this.btn_current_test.Text = "Current Test";
            this.btn_current_test.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1090, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "TR / EN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.zedGraphControl1);
            this.groupBox1.Controls.Add(this.btn_reset_speed);
            this.groupBox1.Controls.Add(this.btn_speed_stop);
            this.groupBox1.Controls.Add(this.btn_speed_start);
            this.groupBox1.Location = new System.Drawing.Point(216, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 583);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(157, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(681, 441);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // btn_reset_speed
            // 
            this.btn_reset_speed.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_reset_speed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset_speed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_reset_speed.Location = new System.Drawing.Point(53, 103);
            this.btn_reset_speed.Name = "btn_reset_speed";
            this.btn_reset_speed.Size = new System.Drawing.Size(75, 24);
            this.btn_reset_speed.TabIndex = 4;
            this.btn_reset_speed.Text = "RESET";
            this.btn_reset_speed.UseVisualStyleBackColor = false;
            // 
            // btn_speed_stop
            // 
            this.btn_speed_stop.BackColor = System.Drawing.Color.Red;
            this.btn_speed_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_speed_stop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_speed_stop.Location = new System.Drawing.Point(53, 74);
            this.btn_speed_stop.Name = "btn_speed_stop";
            this.btn_speed_stop.Size = new System.Drawing.Size(75, 24);
            this.btn_speed_stop.TabIndex = 1;
            this.btn_speed_stop.Text = "Stop";
            this.btn_speed_stop.UseVisualStyleBackColor = false;
            this.btn_speed_stop.Click += new System.EventHandler(this.btn_speed_stop_Click);
            // 
            // btn_speed_start
            // 
            this.btn_speed_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_speed_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_speed_start.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_speed_start.Location = new System.Drawing.Point(53, 44);
            this.btn_speed_start.Name = "btn_speed_start";
            this.btn_speed_start.Size = new System.Drawing.Size(75, 24);
            this.btn_speed_start.TabIndex = 0;
            this.btn_speed_start.Text = "Start";
            this.btn_speed_start.UseVisualStyleBackColor = false;
            this.btn_speed_start.Click += new System.EventHandler(this.btn_speed_start_Click);
            // 
            // lbl_arduino_raw_data
            // 
            this.lbl_arduino_raw_data.AutoSize = true;
            this.lbl_arduino_raw_data.Location = new System.Drawing.Point(768, 691);
            this.lbl_arduino_raw_data.Name = "lbl_arduino_raw_data";
            this.lbl_arduino_raw_data.Size = new System.Drawing.Size(57, 13);
            this.lbl_arduino_raw_data.TabIndex = 1;
            this.lbl_arduino_raw_data.Text = "VERI YOK";
            this.lbl_arduino_raw_data.Click += new System.EventHandler(this.lbl_arduino_raw_data_Click);
            // 
            // timer_arduino
            // 
            this.timer_arduino.Enabled = true;
            this.timer_arduino.Interval = 50;
            this.timer_arduino.Tick += new System.EventHandler(this.timer_arduino_Tick);
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(189, 688);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 21);
            this.cbComPort.TabIndex = 4;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(394, 688);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 21);
            this.cbBaud.TabIndex = 5;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(143, 691);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(40, 13);
            this.lbl_port.TabIndex = 6;
            this.lbl_port.Text = "PORT ";
            // 
            // lbl_baudrate
            // 
            this.lbl_baudrate.AutoSize = true;
            this.lbl_baudrate.Location = new System.Drawing.Point(322, 691);
            this.lbl_baudrate.Name = "lbl_baudrate";
            this.lbl_baudrate.Size = new System.Drawing.Size(66, 13);
            this.lbl_baudrate.TabIndex = 8;
            this.lbl_baudrate.Text = "BAUDRATE";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(539, 686);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(620, 686);
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
            // Analyse_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 730);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_baudrate);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.lbl_arduino_raw_data);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbComPort);
            this.MaximizeBox = false;
            this.Name = "Analyse_page";
            this.Text = "Analyse_page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Analyse_page_FormClosed);
            this.Load += new System.EventHandler(this.Analyse_page_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_volt_amper;
        private System.Windows.Forms.Button btn_current_test;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}