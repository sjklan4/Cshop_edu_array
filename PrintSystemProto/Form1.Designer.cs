﻿namespace PrintSystemProto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.modelNamebox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.model,
            this.modelName});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(397, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // model
            // 
            this.model.HeaderText = "모델";
            this.model.Name = "model";
            this.model.Width = 150;
            // 
            // modelName
            // 
            this.modelName.HeaderText = "모델명";
            this.modelName.Name = "modelName";
            this.modelName.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "모델입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(525, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "모델";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 25F);
            this.label2.Location = new System.Drawing.Point(525, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "모델명";
            // 
            // modelbox
            // 
            this.modelbox.Font = new System.Drawing.Font("굴림", 20F);
            this.modelbox.Location = new System.Drawing.Point(531, 114);
            this.modelbox.Multiline = true;
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(284, 42);
            this.modelbox.TabIndex = 5;
            this.modelbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelbox.TextChanged += new System.EventHandler(this.modelbox_TextChanged);
            // 
            // modelNamebox
            // 
            this.modelNamebox.Font = new System.Drawing.Font("굴림", 20F);
            this.modelNamebox.Location = new System.Drawing.Point(531, 291);
            this.modelNamebox.Multiline = true;
            this.modelNamebox.Name = "modelNamebox";
            this.modelNamebox.Size = new System.Drawing.Size(284, 42);
            this.modelNamebox.TabIndex = 7;
            this.modelNamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelNamebox.TextChanged += new System.EventHandler(this.modelNamebox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(979, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "종료";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 775);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.modelNamebox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelbox;
        private System.Windows.Forms.TextBox modelNamebox;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelName;
        private System.Windows.Forms.Button button3;
    }
}
