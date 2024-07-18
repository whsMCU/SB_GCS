namespace SB_GCS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_RxFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_HEX = new System.Windows.Forms.RadioButton();
            this.radioButton_ASCII = new System.Windows.Forms.RadioButton();
            this.CB_Enable_Terminal = new System.Windows.Forms.CheckBox();
            this.TextBox_received = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label_send = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.text_roll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_pitch = new System.Windows.Forms.TextBox();
            this.text_yaw = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox_RxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_RxFormat
            // 
            this.groupBox_RxFormat.Controls.Add(this.radioButton_HEX);
            this.groupBox_RxFormat.Controls.Add(this.radioButton_ASCII);
            this.groupBox_RxFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_RxFormat.Location = new System.Drawing.Point(28, 430);
            this.groupBox_RxFormat.Name = "groupBox_RxFormat";
            this.groupBox_RxFormat.Size = new System.Drawing.Size(83, 70);
            this.groupBox_RxFormat.TabIndex = 34;
            this.groupBox_RxFormat.TabStop = false;
            this.groupBox_RxFormat.Text = "Rx_Format";
            // 
            // radioButton_HEX
            // 
            this.radioButton_HEX.AutoSize = true;
            this.radioButton_HEX.Location = new System.Drawing.Point(7, 45);
            this.radioButton_HEX.Name = "radioButton_HEX";
            this.radioButton_HEX.Size = new System.Drawing.Size(47, 16);
            this.radioButton_HEX.TabIndex = 1;
            this.radioButton_HEX.Text = "HEX";
            this.radioButton_HEX.UseVisualStyleBackColor = true;
            // 
            // radioButton_ASCII
            // 
            this.radioButton_ASCII.AutoSize = true;
            this.radioButton_ASCII.Checked = true;
            this.radioButton_ASCII.Location = new System.Drawing.Point(7, 18);
            this.radioButton_ASCII.Name = "radioButton_ASCII";
            this.radioButton_ASCII.Size = new System.Drawing.Size(54, 16);
            this.radioButton_ASCII.TabIndex = 0;
            this.radioButton_ASCII.TabStop = true;
            this.radioButton_ASCII.Text = "ASCII";
            this.radioButton_ASCII.UseVisualStyleBackColor = true;
            // 
            // CB_Enable_Terminal
            // 
            this.CB_Enable_Terminal.AutoSize = true;
            this.CB_Enable_Terminal.Location = new System.Drawing.Point(28, 399);
            this.CB_Enable_Terminal.Name = "CB_Enable_Terminal";
            this.CB_Enable_Terminal.Size = new System.Drawing.Size(117, 16);
            this.CB_Enable_Terminal.TabIndex = 33;
            this.CB_Enable_Terminal.Text = "Enable Terminal";
            this.CB_Enable_Terminal.UseVisualStyleBackColor = true;
            // 
            // TextBox_received
            // 
            this.TextBox_received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_received.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_received.Location = new System.Drawing.Point(117, 430);
            this.TextBox_received.Multiline = true;
            this.TextBox_received.Name = "TextBox_received";
            this.TextBox_received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received.Size = new System.Drawing.Size(536, 195);
            this.TextBox_received.TabIndex = 31;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(117, 654);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(328, 21);
            this.textBox_send.TabIndex = 27;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(460, 652);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 28;
            this.button_send.Text = "보내기";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 73);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 12);
            this.label_status.TabIndex = 30;
            this.label_status.Text = "연결상태";
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Location = new System.Drawing.Point(82, 657);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 12);
            this.label_send.TabIndex = 29;
            this.label_send.Text = "송신";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(95, 88);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_disconnect.TabIndex = 24;
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 41);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_port.TabIndex = 21;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 88);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 23;
            this.button_connect.Text = "연결하기";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(12, 23);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 12);
            this.label_port.TabIndex = 22;
            this.label_port.Text = "COM 포트 설정";
            // 
            // text_roll
            // 
            this.text_roll.Location = new System.Drawing.Point(956, 39);
            this.text_roll.Name = "text_roll";
            this.text_roll.ReadOnly = true;
            this.text_roll.Size = new System.Drawing.Size(100, 21);
            this.text_roll.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "ROLL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "PITCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(956, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "YAW";
            // 
            // text_pitch
            // 
            this.text_pitch.Location = new System.Drawing.Point(956, 87);
            this.text_pitch.Name = "text_pitch";
            this.text_pitch.ReadOnly = true;
            this.text_pitch.Size = new System.Drawing.Size(100, 21);
            this.text_pitch.TabIndex = 31;
            // 
            // text_yaw
            // 
            this.text_yaw.Location = new System.Drawing.Point(956, 139);
            this.text_yaw.Name = "text_yaw";
            this.text_yaw.ReadOnly = true;
            this.text_yaw.Size = new System.Drawing.Size(100, 21);
            this.text_yaw.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(660, 285);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(509, 325);
            this.zedGraphControl1.TabIndex = 35;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 707);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox_RxFormat);
            this.Controls.Add(this.text_yaw);
            this.Controls.Add(this.CB_Enable_Terminal);
            this.Controls.Add(this.text_pitch);
            this.Controls.Add(this.TextBox_received);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_send);
            this.Controls.Add(this.text_roll);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_RxFormat.ResumeLayout(false);
            this.groupBox_RxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TextBox_received;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.CheckBox CB_Enable_Terminal;
        private System.Windows.Forms.GroupBox groupBox_RxFormat;
        private System.Windows.Forms.RadioButton radioButton_HEX;
        private System.Windows.Forms.RadioButton radioButton_ASCII;
        private System.Windows.Forms.TextBox text_roll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_pitch;
        private System.Windows.Forms.TextBox text_yaw;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

