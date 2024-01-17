namespace PrintSystemProto
{
    partial class processprint
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
            this.closebtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.combtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ALCLB = new System.Windows.Forms.Label();
            this.ModelLB = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.modeltx = new System.Windows.Forms.TextBox();
            this.ALCtx = new System.Windows.Forms.TextBox();
            this.datetext = new System.Windows.Forms.TextBox();
            this.xposition = new System.Windows.Forms.Label();
            this.yposition = new System.Windows.Forms.Label();
            this.xposibx = new System.Windows.Forms.TextBox();
            this.yposibx = new System.Windows.Forms.TextBox();
            this.barcodeposi = new System.Windows.Forms.GroupBox();
            this.portselect = new System.Windows.Forms.Button();
            this.serialcombo = new System.Windows.Forms.ComboBox();
            this.serialport = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.barcordps = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barX = new System.Windows.Forms.TextBox();
            this.barY = new System.Windows.Forms.TextBox();
            this.barcodeposi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closebtn.Location = new System.Drawing.Point(406, 125);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(46, 30);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "닫기";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.Blue;
            this.printbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printbtn.Location = new System.Drawing.Point(340, 15);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(112, 30);
            this.printbtn.TabIndex = 1;
            this.printbtn.Text = "출력";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // combtn
            // 
            this.combtn.BackColor = System.Drawing.Color.Lime;
            this.combtn.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combtn.Location = new System.Drawing.Point(356, 77);
            this.combtn.Name = "combtn";
            this.combtn.Size = new System.Drawing.Size(96, 30);
            this.combtn.TabIndex = 1;
            this.combtn.Text = "Portcontrol";
            this.combtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ALCLB
            // 
            this.ALCLB.AutoSize = true;
            this.ALCLB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ALCLB.Location = new System.Drawing.Point(46, 55);
            this.ALCLB.Name = "ALCLB";
            this.ALCLB.Size = new System.Drawing.Size(52, 20);
            this.ALCLB.TabIndex = 2;
            this.ALCLB.Text = "ALC : ";
            // 
            // ModelLB
            // 
            this.ModelLB.AutoSize = true;
            this.ModelLB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ModelLB.Location = new System.Drawing.Point(38, 22);
            this.ModelLB.Name = "ModelLB";
            this.ModelLB.Size = new System.Drawing.Size(67, 20);
            this.ModelLB.TabIndex = 3;
            this.ModelLB.Text = "Model : ";
            // 
            // DateLB
            // 
            this.DateLB.AutoSize = true;
            this.DateLB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DateLB.Location = new System.Drawing.Point(43, 87);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(56, 20);
            this.DateLB.TabIndex = 2;
            this.DateLB.Text = "Date : ";
            // 
            // modeltx
            // 
            this.modeltx.Location = new System.Drawing.Point(116, 23);
            this.modeltx.Name = "modeltx";
            this.modeltx.Size = new System.Drawing.Size(166, 21);
            this.modeltx.TabIndex = 4;
            this.modeltx.TextChanged += new System.EventHandler(this.modeltx_TextChanged);
            // 
            // ALCtx
            // 
            this.ALCtx.Location = new System.Drawing.Point(116, 55);
            this.ALCtx.Name = "ALCtx";
            this.ALCtx.Size = new System.Drawing.Size(166, 21);
            this.ALCtx.TabIndex = 4;
            // 
            // datetext
            // 
            this.datetext.Location = new System.Drawing.Point(116, 87);
            this.datetext.Name = "datetext";
            this.datetext.Size = new System.Drawing.Size(166, 21);
            this.datetext.TabIndex = 4;
            // 
            // xposition
            // 
            this.xposition.AutoSize = true;
            this.xposition.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xposition.Location = new System.Drawing.Point(13, 35);
            this.xposition.Name = "xposition";
            this.xposition.Size = new System.Drawing.Size(28, 20);
            this.xposition.TabIndex = 2;
            this.xposition.Text = "X :";
            // 
            // yposition
            // 
            this.yposition.AutoSize = true;
            this.yposition.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yposition.Location = new System.Drawing.Point(159, 35);
            this.yposition.Name = "yposition";
            this.yposition.Size = new System.Drawing.Size(27, 20);
            this.yposition.TabIndex = 2;
            this.yposition.Text = "Y :";
            // 
            // xposibx
            // 
            this.xposibx.Location = new System.Drawing.Point(45, 36);
            this.xposibx.Name = "xposibx";
            this.xposibx.Size = new System.Drawing.Size(102, 21);
            this.xposibx.TabIndex = 5;
            // 
            // yposibx
            // 
            this.yposibx.Location = new System.Drawing.Point(191, 35);
            this.yposibx.Name = "yposibx";
            this.yposibx.Size = new System.Drawing.Size(102, 21);
            this.yposibx.TabIndex = 6;
            // 
            // barcodeposi
            // 
            this.barcodeposi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.barcodeposi.Controls.Add(this.yposibx);
            this.barcodeposi.Controls.Add(this.xposibx);
            this.barcodeposi.Controls.Add(this.yposition);
            this.barcodeposi.Controls.Add(this.xposition);
            this.barcodeposi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barcodeposi.Location = new System.Drawing.Point(20, 125);
            this.barcodeposi.Name = "barcodeposi";
            this.barcodeposi.Size = new System.Drawing.Size(318, 77);
            this.barcodeposi.TabIndex = 7;
            this.barcodeposi.TabStop = false;
            this.barcodeposi.Text = "QR위치";
            // 
            // portselect
            // 
            this.portselect.BackColor = System.Drawing.Color.Gray;
            this.portselect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.portselect.Location = new System.Drawing.Point(379, 173);
            this.portselect.Name = "portselect";
            this.portselect.Size = new System.Drawing.Size(73, 42);
            this.portselect.TabIndex = 8;
            this.portselect.Text = "ProtSel나중수정";
            this.portselect.UseVisualStyleBackColor = false;
            this.portselect.Click += new System.EventHandler(this.portselect_Click);
            // 
            // serialcombo
            // 
            this.serialcombo.FormattingEnabled = true;
            this.serialcombo.Location = new System.Drawing.Point(125, 267);
            this.serialcombo.Name = "serialcombo";
            this.serialcombo.Size = new System.Drawing.Size(60, 20);
            this.serialcombo.TabIndex = 9;
            // 
            // serialport
            // 
            this.serialport.AutoSize = true;
            this.serialport.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serialport.Location = new System.Drawing.Point(29, 267);
            this.serialport.Name = "serialport";
            this.serialport.Size = new System.Drawing.Size(90, 20);
            this.serialport.TabIndex = 10;
            this.serialport.Text = "serialport : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.barY);
            this.panel1.Controls.Add(this.barX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.barcordps);
            this.panel1.Location = new System.Drawing.Point(22, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 57);
            this.panel1.TabIndex = 11;
            // 
            // barcordps
            // 
            this.barcordps.AutoSize = true;
            this.barcordps.BackColor = System.Drawing.Color.SeaShell;
            this.barcordps.Font = new System.Drawing.Font("굴림", 10F);
            this.barcordps.Location = new System.Drawing.Point(3, 1);
            this.barcordps.Name = "barcordps";
            this.barcordps.Size = new System.Drawing.Size(77, 14);
            this.barcordps.TabIndex = 0;
            this.barcordps.Text = "바코드위치";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chartreuse;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(170, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // barX
            // 
            this.barX.Location = new System.Drawing.Point(62, 21);
            this.barX.Multiline = true;
            this.barX.Name = "barX";
            this.barX.Size = new System.Drawing.Size(66, 22);
            this.barX.TabIndex = 7;
            // 
            // barY
            // 
            this.barY.Location = new System.Drawing.Point(188, 21);
            this.barY.Multiline = true;
            this.barY.Name = "barY";
            this.barY.Size = new System.Drawing.Size(66, 22);
            this.barY.TabIndex = 8;
            // 
            // processprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 299);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.serialport);
            this.Controls.Add(this.serialcombo);
            this.Controls.Add(this.portselect);
            this.Controls.Add(this.barcodeposi);
            this.Controls.Add(this.datetext);
            this.Controls.Add(this.ALCtx);
            this.Controls.Add(this.modeltx);
            this.Controls.Add(this.ModelLB);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.ALCLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.closebtn);
            this.Name = "processprint";
            this.Text = "processprint";
            this.Load += new System.EventHandler(this.processprint_Load);
            this.barcodeposi.ResumeLayout(false);
            this.barcodeposi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button combtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ALCLB;
        private System.Windows.Forms.Label ModelLB;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.TextBox modeltx;
        private System.Windows.Forms.TextBox ALCtx;
        private System.Windows.Forms.TextBox datetext;
        private System.Windows.Forms.Label xposition;
        private System.Windows.Forms.Label yposition;
        private System.Windows.Forms.TextBox xposibx;
        private System.Windows.Forms.TextBox yposibx;
        private System.Windows.Forms.GroupBox barcodeposi;
        private System.Windows.Forms.Button portselect;
        private System.Windows.Forms.ComboBox serialcombo;
        private System.Windows.Forms.Label serialport;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label barcordps;
        private System.Windows.Forms.TextBox barY;
        private System.Windows.Forms.TextBox barX;
    }
}