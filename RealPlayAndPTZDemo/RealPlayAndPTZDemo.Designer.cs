namespace RealPlayAndPTZDemo
{
    partial class RealPlayAndPTZDemo
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
            this.realplay_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.streamtype_comboBox = new System.Windows.Forms.ComboBox();
            this.channel_comboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.capture_button = new System.Windows.Forms.Button();
            this.start_realplay_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.step_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apertureadd_button = new System.Windows.Forms.Button();
            this.focusadd_button = new System.Windows.Forms.Button();
            this.zoomadd_button = new System.Windows.Forms.Button();
            this.aperturedec_button = new System.Windows.Forms.Button();
            this.focusdec_button = new System.Windows.Forms.Button();
            this.zoomdec_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.bottomright_button = new System.Windows.Forms.Button();
            this.bottom_button = new System.Windows.Forms.Button();
            this.bottomleft_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.topright_button = new System.Windows.Forms.Button();
            this.top_button = new System.Windows.Forms.Button();
            this.topleft_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // realplay_pictureBox
            // 
            this.realplay_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.realplay_pictureBox.Location = new System.Drawing.Point(3, 73);
            this.realplay_pictureBox.Name = "realplay_pictureBox";
            this.realplay_pictureBox.Size = new System.Drawing.Size(562, 445);
            this.realplay_pictureBox.TabIndex = 0;
            this.realplay_pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.port_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.name_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pwd_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ip_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Login(设备登录)";
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(250, 21);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(43, 23);
            this.port_textBox.TabIndex = 1;
            this.port_textBox.Text = "37777";
            this.port_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Port(端口):";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(625, 19);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(115, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login(登录)";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(367, 21);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(53, 23);
            this.name_textBox.TabIndex = 2;
            this.name_textBox.Text = "admin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name(用户):";
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(497, 21);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(103, 23);
            this.pwd_textBox.TabIndex = 3;
            this.pwd_textBox.Text = "admin";
            this.pwd_textBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pwd(密码):";
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(83, 21);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(92, 23);
            this.ip_textBox.TabIndex = 0;
            this.ip_textBox.Text = "172.23.1.104";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP(设备IP):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.streamtype_comboBox);
            this.groupBox2.Controls.Add(this.channel_comboBox);
            this.groupBox2.Controls.Add(this.save_button);
            this.groupBox2.Controls.Add(this.capture_button);
            this.groupBox2.Controls.Add(this.start_realplay_button);
            this.groupBox2.Location = new System.Drawing.Point(572, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview(预览)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "StreamType(码流类型):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "Channel(通道):";
            // 
            // streamtype_comboBox
            // 
            this.streamtype_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamtype_comboBox.FormattingEnabled = true;
            this.streamtype_comboBox.Location = new System.Drawing.Point(20, 81);
            this.streamtype_comboBox.Name = "streamtype_comboBox";
            this.streamtype_comboBox.Size = new System.Drawing.Size(159, 20);
            this.streamtype_comboBox.TabIndex = 6;
            // 
            // channel_comboBox
            // 
            this.channel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channel_comboBox.FormattingEnabled = true;
            this.channel_comboBox.Location = new System.Drawing.Point(20, 35);
            this.channel_comboBox.Name = "channel_comboBox";
            this.channel_comboBox.Size = new System.Drawing.Size(159, 20);
            this.channel_comboBox.TabIndex = 5;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(20, 167);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(159, 23);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "StartSave(开始保存录像)";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // capture_button
            // 
            this.capture_button.Location = new System.Drawing.Point(20, 137);
            this.capture_button.Name = "capture_button";
            this.capture_button.Size = new System.Drawing.Size(159, 23);
            this.capture_button.TabIndex = 8;
            this.capture_button.Text = "Capture(抓图)";
            this.capture_button.UseVisualStyleBackColor = true;
            this.capture_button.Click += new System.EventHandler(this.capture_button_Click);
            // 
            // start_realplay_button
            // 
            this.start_realplay_button.Location = new System.Drawing.Point(20, 108);
            this.start_realplay_button.Name = "start_realplay_button";
            this.start_realplay_button.Size = new System.Drawing.Size(159, 23);
            this.start_realplay_button.TabIndex = 7;
            this.start_realplay_button.Text = "StartReal(开始预览)";
            this.start_realplay_button.UseVisualStyleBackColor = true;
            this.start_realplay_button.Click += new System.EventHandler(this.start_realplay_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.step_comboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.apertureadd_button);
            this.groupBox3.Controls.Add(this.focusadd_button);
            this.groupBox3.Controls.Add(this.zoomadd_button);
            this.groupBox3.Controls.Add(this.aperturedec_button);
            this.groupBox3.Controls.Add(this.focusdec_button);
            this.groupBox3.Controls.Add(this.zoomdec_button);
            this.groupBox3.Controls.Add(this.right_button);
            this.groupBox3.Controls.Add(this.bottomright_button);
            this.groupBox3.Controls.Add(this.bottom_button);
            this.groupBox3.Controls.Add(this.bottomleft_button);
            this.groupBox3.Controls.Add(this.left_button);
            this.groupBox3.Controls.Add(this.topright_button);
            this.groupBox3.Controls.Add(this.top_button);
            this.groupBox3.Controls.Add(this.topleft_button);
            this.groupBox3.Location = new System.Drawing.Point(572, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PTZControl(云台控制)";
            // 
            // step_comboBox
            // 
            this.step_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.step_comboBox.FormattingEnabled = true;
            this.step_comboBox.Location = new System.Drawing.Point(109, 119);
            this.step_comboBox.Name = "step_comboBox";
            this.step_comboBox.Size = new System.Drawing.Size(65, 20);
            this.step_comboBox.TabIndex = 18;
            this.step_comboBox.SelectedIndexChanged += new System.EventHandler(this.step_comboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Step Len(步长):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aperture(光圈):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Focus(焦距):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Zoom(缩放):";
            // 
            // apertureadd_button
            // 
            this.apertureadd_button.Location = new System.Drawing.Point(109, 205);
            this.apertureadd_button.Name = "apertureadd_button";
            this.apertureadd_button.Size = new System.Drawing.Size(25, 25);
            this.apertureadd_button.TabIndex = 23;
            this.apertureadd_button.Text = "╋";
            this.apertureadd_button.UseVisualStyleBackColor = true;
            this.apertureadd_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.apertureadd_button_MouseDown);
            this.apertureadd_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.apertureadd_button_MouseUp);
            // 
            // focusadd_button
            // 
            this.focusadd_button.Location = new System.Drawing.Point(109, 174);
            this.focusadd_button.Name = "focusadd_button";
            this.focusadd_button.Size = new System.Drawing.Size(25, 25);
            this.focusadd_button.TabIndex = 21;
            this.focusadd_button.Text = "╋";
            this.focusadd_button.UseVisualStyleBackColor = true;
            this.focusadd_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focusadd_button_MouseDown);
            this.focusadd_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusadd_button_MouseUp);
            // 
            // zoomadd_button
            // 
            this.zoomadd_button.Location = new System.Drawing.Point(109, 143);
            this.zoomadd_button.Name = "zoomadd_button";
            this.zoomadd_button.Size = new System.Drawing.Size(25, 25);
            this.zoomadd_button.TabIndex = 19;
            this.zoomadd_button.Text = "╋";
            this.zoomadd_button.UseVisualStyleBackColor = true;
            this.zoomadd_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomadd_button_MouseDown);
            this.zoomadd_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomadd_button_MouseUp);
            // 
            // aperturedec_button
            // 
            this.aperturedec_button.Location = new System.Drawing.Point(149, 205);
            this.aperturedec_button.Name = "aperturedec_button";
            this.aperturedec_button.Size = new System.Drawing.Size(25, 25);
            this.aperturedec_button.TabIndex = 24;
            this.aperturedec_button.Text = "━";
            this.aperturedec_button.UseVisualStyleBackColor = true;
            this.aperturedec_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aperturedec_button_MouseDown);
            this.aperturedec_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aperturedec_button_MouseUp);
            // 
            // focusdec_button
            // 
            this.focusdec_button.Location = new System.Drawing.Point(149, 174);
            this.focusdec_button.Name = "focusdec_button";
            this.focusdec_button.Size = new System.Drawing.Size(25, 25);
            this.focusdec_button.TabIndex = 22;
            this.focusdec_button.Text = "━";
            this.focusdec_button.UseVisualStyleBackColor = true;
            this.focusdec_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focusdec_button_MouseDown);
            this.focusdec_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusdec_button_MouseUp);
            // 
            // zoomdec_button
            // 
            this.zoomdec_button.Location = new System.Drawing.Point(149, 143);
            this.zoomdec_button.Name = "zoomdec_button";
            this.zoomdec_button.Size = new System.Drawing.Size(25, 25);
            this.zoomdec_button.TabIndex = 20;
            this.zoomdec_button.Text = "━";
            this.zoomdec_button.UseVisualStyleBackColor = true;
            this.zoomdec_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomdec_button_MouseDown);
            this.zoomdec_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomdec_button_MouseUp);
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(139, 53);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(25, 25);
            this.right_button.TabIndex = 14;
            this.right_button.Text = "→";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_button_MouseDown);
            this.right_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_button_MouseUp);
            // 
            // bottomright_button
            // 
            this.bottomright_button.Location = new System.Drawing.Point(139, 89);
            this.bottomright_button.Name = "bottomright_button";
            this.bottomright_button.Size = new System.Drawing.Size(25, 25);
            this.bottomright_button.TabIndex = 17;
            this.bottomright_button.Text = "↘";
            this.bottomright_button.UseVisualStyleBackColor = true;
            this.bottomright_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomright_button_MouseDown);
            this.bottomright_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomright_button_MouseUp);
            // 
            // bottom_button
            // 
            this.bottom_button.Location = new System.Drawing.Point(86, 89);
            this.bottom_button.Name = "bottom_button";
            this.bottom_button.Size = new System.Drawing.Size(25, 25);
            this.bottom_button.TabIndex = 16;
            this.bottom_button.Text = "↓";
            this.bottom_button.UseVisualStyleBackColor = true;
            this.bottom_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottom_button_MouseDown);
            this.bottom_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottom_button_MouseUp);
            // 
            // bottomleft_button
            // 
            this.bottomleft_button.Location = new System.Drawing.Point(34, 89);
            this.bottomleft_button.Name = "bottomleft_button";
            this.bottomleft_button.Size = new System.Drawing.Size(25, 25);
            this.bottomleft_button.TabIndex = 15;
            this.bottomleft_button.Text = "↙";
            this.bottomleft_button.UseVisualStyleBackColor = true;
            this.bottomleft_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomleft_button_MouseDown);
            this.bottomleft_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomleft_button_MouseUp);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(34, 53);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(25, 25);
            this.left_button.TabIndex = 13;
            this.left_button.Text = "←";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_button_MouseDown);
            this.left_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_button_MouseUp);
            // 
            // topright_button
            // 
            this.topright_button.Location = new System.Drawing.Point(139, 17);
            this.topright_button.Name = "topright_button";
            this.topright_button.Size = new System.Drawing.Size(25, 25);
            this.topright_button.TabIndex = 12;
            this.topright_button.Text = "↗";
            this.topright_button.UseVisualStyleBackColor = true;
            this.topright_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topright_button_MouseDown);
            this.topright_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topright_button_MouseUp);
            // 
            // top_button
            // 
            this.top_button.Location = new System.Drawing.Point(86, 17);
            this.top_button.Name = "top_button";
            this.top_button.Size = new System.Drawing.Size(25, 25);
            this.top_button.TabIndex = 11;
            this.top_button.Text = "↑";
            this.top_button.UseVisualStyleBackColor = true;
            this.top_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_button_MouseDown);
            this.top_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_button_MouseUp);
            // 
            // topleft_button
            // 
            this.topleft_button.Location = new System.Drawing.Point(34, 17);
            this.topleft_button.Name = "topleft_button";
            this.topleft_button.Size = new System.Drawing.Size(25, 25);
            this.topleft_button.TabIndex = 10;
            this.topleft_button.Text = "↖";
            this.topleft_button.UseVisualStyleBackColor = true;
            this.topleft_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topleft_button_MouseDown);
            this.topleft_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topleft_button_MouseUp);
            // 
            // RealPlayAndPTZDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.realplay_pictureBox);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "RealPlayAndPTZDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealPlayAndPTZDemo(实时预览与云台Demo)";
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox realplay_pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button capture_button;
        private System.Windows.Forms.Button start_realplay_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apertureadd_button;
        private System.Windows.Forms.Button focusadd_button;
        private System.Windows.Forms.Button zoomadd_button;
        private System.Windows.Forms.Button aperturedec_button;
        private System.Windows.Forms.Button focusdec_button;
        private System.Windows.Forms.Button zoomdec_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button bottomright_button;
        private System.Windows.Forms.Button bottom_button;
        private System.Windows.Forms.Button bottomleft_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button topright_button;
        private System.Windows.Forms.Button top_button;
        private System.Windows.Forms.Button topleft_button;
        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox streamtype_comboBox;
        private System.Windows.Forms.ComboBox channel_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox step_comboBox;
    }
}

