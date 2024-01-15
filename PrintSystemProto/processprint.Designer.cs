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
            this.closebtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.combtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ALCLB = new System.Windows.Forms.Label();
            this.ModelLB = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.xposition = new System.Windows.Forms.Label();
            this.yposition = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.barcodeposi = new System.Windows.Forms.GroupBox();
            this.barcodeposi.SuspendLayout();
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
            this.printbtn.Location = new System.Drawing.Point(340, 12);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(112, 30);
            this.printbtn.TabIndex = 1;
            this.printbtn.Text = "출력";
            this.printbtn.UseVisualStyleBackColor = false;
            // 
            // combtn
            // 
            this.combtn.BackColor = System.Drawing.Color.Lime;
            this.combtn.Font = new System.Drawing.Font("새굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combtn.Location = new System.Drawing.Point(356, 89);
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
            this.ALCLB.Location = new System.Drawing.Point(43, 62);
            this.ALCLB.Name = "ALCLB";
            this.ALCLB.Size = new System.Drawing.Size(52, 20);
            this.ALCLB.TabIndex = 2;
            this.ALCLB.Text = "ALC : ";
            // 
            // ModelLB
            // 
            this.ModelLB.AutoSize = true;
            this.ModelLB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ModelLB.Location = new System.Drawing.Point(43, 30);
            this.ModelLB.Name = "ModelLB";
            this.ModelLB.Size = new System.Drawing.Size(67, 20);
            this.ModelLB.TabIndex = 3;
            this.ModelLB.Text = "Model : ";
            // 
            // DateLB
            // 
            this.DateLB.AutoSize = true;
            this.DateLB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DateLB.Location = new System.Drawing.Point(43, 93);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(56, 20);
            this.DateLB.TabIndex = 2;
            this.DateLB.Text = "Date : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 21);
            this.textBox3.TabIndex = 4;
            // 
            // xposition
            // 
            this.xposition.AutoSize = true;
            this.xposition.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xposition.Location = new System.Drawing.Point(11, 36);
            this.xposition.Name = "xposition";
            this.xposition.Size = new System.Drawing.Size(28, 20);
            this.xposition.TabIndex = 2;
            this.xposition.Text = "X :";
            // 
            // yposition
            // 
            this.yposition.AutoSize = true;
            this.yposition.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yposition.Location = new System.Drawing.Point(153, 36);
            this.yposition.Name = "yposition";
            this.yposition.Size = new System.Drawing.Size(27, 20);
            this.yposition.TabIndex = 2;
            this.yposition.Text = "Y :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(45, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 21);
            this.textBox5.TabIndex = 6;
            // 
            // barcodeposi
            // 
            this.barcodeposi.BackColor = System.Drawing.Color.White;
            this.barcodeposi.Controls.Add(this.textBox5);
            this.barcodeposi.Controls.Add(this.textBox4);
            this.barcodeposi.Controls.Add(this.yposition);
            this.barcodeposi.Controls.Add(this.xposition);
            this.barcodeposi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barcodeposi.Location = new System.Drawing.Point(20, 140);
            this.barcodeposi.Name = "barcodeposi";
            this.barcodeposi.Size = new System.Drawing.Size(307, 62);
            this.barcodeposi.TabIndex = 7;
            this.barcodeposi.TabStop = false;
            this.barcodeposi.Text = "바코드위치";
            // 
            // processprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 215);
            this.ControlBox = false;
            this.Controls.Add(this.barcodeposi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label xposition;
        private System.Windows.Forms.Label yposition;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox barcodeposi;
    }
}