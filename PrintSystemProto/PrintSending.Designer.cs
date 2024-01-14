﻿namespace PrintSystemProto
{
    partial class PrintSending
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sendtxbox = new System.Windows.Forms.TextBox();
            this.sendtx = new System.Windows.Forms.Label();
            this.receivetx = new System.Windows.Forms.Label();
            this.receivebox = new System.Windows.Forms.TextBox();
            this.comport = new System.Windows.Forms.Label();
            this.serialoption = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.Label();
            this.databit = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.stopbit = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.connet = new System.Windows.Forms.Button();
            this.nonconnet = new System.Windows.Forms.Button();
            this.serialchk = new System.Windows.Forms.Label();
            this.serialoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sendtxbox
            // 
            this.sendtxbox.Location = new System.Drawing.Point(31, 52);
            this.sendtxbox.Multiline = true;
            this.sendtxbox.Name = "sendtxbox";
            this.sendtxbox.Size = new System.Drawing.Size(356, 406);
            this.sendtxbox.TabIndex = 1;
            // 
            // sendtx
            // 
            this.sendtx.AutoSize = true;
            this.sendtx.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.sendtx.Location = new System.Drawing.Point(29, 26);
            this.sendtx.Name = "sendtx";
            this.sendtx.Size = new System.Drawing.Size(92, 16);
            this.sendtx.TabIndex = 2;
            this.sendtx.Text = "프린트내용";
            // 
            // receivetx
            // 
            this.receivetx.AutoSize = true;
            this.receivetx.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.receivetx.Location = new System.Drawing.Point(406, 26);
            this.receivetx.Name = "receivetx";
            this.receivetx.Size = new System.Drawing.Size(75, 16);
            this.receivetx.TabIndex = 3;
            this.receivetx.Text = "수신내용";
            // 
            // receivebox
            // 
            this.receivebox.Location = new System.Drawing.Point(409, 52);
            this.receivebox.Multiline = true;
            this.receivebox.Name = "receivebox";
            this.receivebox.Size = new System.Drawing.Size(356, 133);
            this.receivebox.TabIndex = 4;
            // 
            // comport
            // 
            this.comport.AutoSize = true;
            this.comport.Location = new System.Drawing.Point(17, 27);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(53, 12);
            this.comport.TabIndex = 6;
            this.comport.Text = "Comport";
            // 
            // serialoption
            // 
            this.serialoption.BackColor = System.Drawing.Color.White;
            this.serialoption.Controls.Add(this.serialchk);
            this.serialoption.Controls.Add(this.nonconnet);
            this.serialoption.Controls.Add(this.connet);
            this.serialoption.Controls.Add(this.comboBox4);
            this.serialoption.Controls.Add(this.comboBox3);
            this.serialoption.Controls.Add(this.stopbit);
            this.serialoption.Controls.Add(this.comboBox2);
            this.serialoption.Controls.Add(this.databit);
            this.serialoption.Controls.Add(this.comboBox1);
            this.serialoption.Controls.Add(this.Baudrate);
            this.serialoption.Controls.Add(this.comport);
            this.serialoption.Cursor = System.Windows.Forms.Cursors.Default;
            this.serialoption.Location = new System.Drawing.Point(409, 191);
            this.serialoption.Name = "serialoption";
            this.serialoption.Size = new System.Drawing.Size(199, 290);
            this.serialoption.TabIndex = 7;
            this.serialoption.TabStop = false;
            this.serialoption.Text = "Serial Option";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comboBox1.Location = new System.Drawing.Point(82, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1200\t",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200"});
            this.comboBox2.Location = new System.Drawing.Point(82, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 20);
            this.comboBox2.TabIndex = 7;
            // 
            // Baudrate
            // 
            this.Baudrate.AutoSize = true;
            this.Baudrate.Location = new System.Drawing.Point(18, 53);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Baudrate.Size = new System.Drawing.Size(63, 12);
            this.Baudrate.TabIndex = 6;
            this.Baudrate.Text = "Baud Rate";
            // 
            // databit
            // 
            this.databit.AutoSize = true;
            this.databit.Location = new System.Drawing.Point(18, 79);
            this.databit.Name = "databit";
            this.databit.Size = new System.Drawing.Size(55, 12);
            this.databit.TabIndex = 6;
            this.databit.Text = "Data Bits";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(82, 75);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 20);
            this.comboBox3.TabIndex = 7;
            // 
            // stopbit
            // 
            this.stopbit.AutoSize = true;
            this.stopbit.Location = new System.Drawing.Point(18, 105);
            this.stopbit.Name = "stopbit";
            this.stopbit.Size = new System.Drawing.Size(55, 12);
            this.stopbit.TabIndex = 6;
            this.stopbit.Text = "Stop Bits";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(82, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(103, 20);
            this.comboBox4.TabIndex = 7;
            // 
            // connet
            // 
            this.connet.Location = new System.Drawing.Point(6, 231);
            this.connet.Name = "connet";
            this.connet.Size = new System.Drawing.Size(88, 36);
            this.connet.TabIndex = 8;
            this.connet.Text = "연결하기";
            this.connet.UseVisualStyleBackColor = true;
            this.connet.Click += new System.EventHandler(this.connet_Click);
            // 
            // nonconnet
            // 
            this.nonconnet.Location = new System.Drawing.Point(100, 231);
            this.nonconnet.Name = "nonconnet";
            this.nonconnet.Size = new System.Drawing.Size(93, 36);
            this.nonconnet.TabIndex = 9;
            this.nonconnet.Text = "연결끊기";
            this.nonconnet.UseVisualStyleBackColor = true;
            this.nonconnet.Click += new System.EventHandler(this.nonconnet_Click);
            // 
            // serialchk
            // 
            this.serialchk.AutoSize = true;
            this.serialchk.Location = new System.Drawing.Point(10, 274);
            this.serialchk.Name = "serialchk";
            this.serialchk.Size = new System.Drawing.Size(0, 12);
            this.serialchk.TabIndex = 10;
            // 
            // PrintSending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 559);
            this.Controls.Add(this.serialoption);
            this.Controls.Add(this.receivebox);
            this.Controls.Add(this.receivetx);
            this.Controls.Add(this.sendtx);
            this.Controls.Add(this.sendtxbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PrintSending";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PrintSending_Load);
            this.serialoption.ResumeLayout(false);
            this.serialoption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sendtxbox;
        private System.Windows.Forms.Label sendtx;
        private System.Windows.Forms.Label receivetx;
        private System.Windows.Forms.TextBox receivebox;
        private System.Windows.Forms.Label comport;
        private System.Windows.Forms.GroupBox serialoption;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label stopbit;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label databit;
        private System.Windows.Forms.Label Baudrate;
        private System.Windows.Forms.Button nonconnet;
        private System.Windows.Forms.Button connet;
        private System.Windows.Forms.Label serialchk;
    }
}