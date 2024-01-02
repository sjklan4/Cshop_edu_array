﻿namespace PrintSystemProto
{
    partial class ModelINFT
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Partch_Table = new System.Windows.Forms.DataGridView();
            this.AddPartch = new System.Windows.Forms.Label();
            this.Part_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Part_Num = new System.Windows.Forms.TextBox();
            this.Part_Color = new System.Windows.Forms.TextBox();
            this.registbtn = new System.Windows.Forms.Button();
            this.productregit = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Partch_RegistBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Process_table = new System.Windows.Forms.DataGridView();
            this.Partch_Delbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Partch_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Process_table)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F);
            this.button1.Location = new System.Drawing.Point(690, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "종   료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(545, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "printsystem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Partch_Table
            // 
            this.Partch_Table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Partch_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Partch_Table.Location = new System.Drawing.Point(46, 142);
            this.Partch_Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Partch_Table.Name = "Partch_Table";
            this.Partch_Table.RowTemplate.Height = 23;
            this.Partch_Table.Size = new System.Drawing.Size(629, 246);
            this.Partch_Table.TabIndex = 3;
            this.Partch_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Partch_Table_CellContentClick);
            // 
            // AddPartch
            // 
            this.AddPartch.AutoSize = true;
            this.AddPartch.Font = new System.Drawing.Font("굴림", 19F);
            this.AddPartch.Location = new System.Drawing.Point(797, 52);
            this.AddPartch.Name = "AddPartch";
            this.AddPartch.Size = new System.Drawing.Size(116, 26);
            this.AddPartch.TabIndex = 4;
            this.AddPartch.Text = "부품추가";
            this.AddPartch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddPartch.Click += new System.EventHandler(this.label1_Click);
            // 
            // Part_Name
            // 
            this.Part_Name.Font = new System.Drawing.Font("굴림", 12F);
            this.Part_Name.Location = new System.Drawing.Point(743, 192);
            this.Part_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Part_Name.Multiline = true;
            this.Part_Name.Name = "Part_Name";
            this.Part_Name.Size = new System.Drawing.Size(228, 43);
            this.Part_Name.TabIndex = 5;
            this.Part_Name.TextChanged += new System.EventHandler(this.Part_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(739, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "부품명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(739, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "부품번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(739, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "색상";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Part_Num
            // 
            this.Part_Num.Font = new System.Drawing.Font("굴림", 12F);
            this.Part_Num.Location = new System.Drawing.Point(743, 269);
            this.Part_Num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Part_Num.Multiline = true;
            this.Part_Num.Name = "Part_Num";
            this.Part_Num.Size = new System.Drawing.Size(228, 43);
            this.Part_Num.TabIndex = 9;
            // 
            // Part_Color
            // 
            this.Part_Color.Font = new System.Drawing.Font("굴림", 12F);
            this.Part_Color.Location = new System.Drawing.Point(743, 345);
            this.Part_Color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Part_Color.Multiline = true;
            this.Part_Color.Name = "Part_Color";
            this.Part_Color.Size = new System.Drawing.Size(228, 43);
            this.Part_Color.TabIndex = 10;
            // 
            // registbtn
            // 
            this.registbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.registbtn.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.registbtn.Location = new System.Drawing.Point(747, 396);
            this.registbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registbtn.Name = "registbtn";
            this.registbtn.Size = new System.Drawing.Size(102, 44);
            this.registbtn.TabIndex = 11;
            this.registbtn.Text = "부품추가";
            this.registbtn.UseVisualStyleBackColor = true;
            this.registbtn.Click += new System.EventHandler(this.registbtn_Click);
            // 
            // productregit
            // 
            this.productregit.AutoSize = true;
            this.productregit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productregit.Location = new System.Drawing.Point(43, 115);
            this.productregit.Name = "productregit";
            this.productregit.Size = new System.Drawing.Size(75, 16);
            this.productregit.TabIndex = 12;
            this.productregit.Text = "품목등록";
            this.productregit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(873, 396);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 44);
            this.button4.TabIndex = 14;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(43, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "model선택";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(572, 492);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "삭제";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox1.Location = new System.Drawing.Point(743, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 43);
            this.textBox1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(744, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "ALC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Partch_RegistBtn
            // 
            this.Partch_RegistBtn.BackColor = System.Drawing.Color.Lime;
            this.Partch_RegistBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Partch_RegistBtn.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Partch_RegistBtn.Location = new System.Drawing.Point(453, 492);
            this.Partch_RegistBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Partch_RegistBtn.Name = "Partch_RegistBtn";
            this.Partch_RegistBtn.Size = new System.Drawing.Size(104, 33);
            this.Partch_RegistBtn.TabIndex = 13;
            this.Partch_RegistBtn.Text = "등록";
            this.Partch_RegistBtn.UseVisualStyleBackColor = false;
            this.Partch_RegistBtn.Click += new System.EventHandler(this.Partch_RegistBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(52, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "검사제품내용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Process_table
            // 
            this.Process_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Process_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Process_table.Location = new System.Drawing.Point(54, 533);
            this.Process_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Process_table.Name = "Process_table";
            this.Process_table.RowTemplate.Height = 23;
            this.Process_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Process_table.Size = new System.Drawing.Size(917, 266);
            this.Process_table.TabIndex = 16;
            this.Process_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Process_Chk_CellContentClick);
            // 
            // Partch_Delbtn
            // 
            this.Partch_Delbtn.BackColor = System.Drawing.Color.Red;
            this.Partch_Delbtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Partch_Delbtn.Location = new System.Drawing.Point(565, 396);
            this.Partch_Delbtn.Name = "Partch_Delbtn";
            this.Partch_Delbtn.Size = new System.Drawing.Size(110, 32);
            this.Partch_Delbtn.TabIndex = 21;
            this.Partch_Delbtn.Text = "부품삭제";
            this.Partch_Delbtn.UseVisualStyleBackColor = false;
            this.Partch_Delbtn.Click += new System.EventHandler(this.Partch_Delbtn_Click);
            // 
            // ModelINFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 825);
            this.Controls.Add(this.Partch_Delbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Process_table);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Partch_RegistBtn);
            this.Controls.Add(this.productregit);
            this.Controls.Add(this.registbtn);
            this.Controls.Add(this.Part_Color);
            this.Controls.Add(this.Part_Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Part_Name);
            this.Controls.Add(this.AddPartch);
            this.Controls.Add(this.Partch_Table);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModelINFT";
            this.Text = "ModelINFT";
            this.Load += new System.EventHandler(this.ModelINFT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Partch_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Process_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView Partch_Table;
        private System.Windows.Forms.Label AddPartch;
        private System.Windows.Forms.TextBox Part_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Part_Num;
        private System.Windows.Forms.TextBox Part_Color;
        private System.Windows.Forms.Button registbtn;
        private System.Windows.Forms.Label productregit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Partch_RegistBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Process_table;
        private System.Windows.Forms.Button Partch_Delbtn;
    }
}