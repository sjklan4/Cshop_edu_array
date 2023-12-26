namespace PrintSystemProto
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.modelNamebox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.modelinf = new System.Windows.Forms.Button();
            this.DelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(33, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(567, 850);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1197, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "모델입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(750, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label2.Location = new System.Drawing.Point(750, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "모델명";
            // 
            // modelbox
            // 
            this.modelbox.Font = new System.Drawing.Font("굴림", 20F);
            this.modelbox.Location = new System.Drawing.Point(759, 171);
            this.modelbox.Margin = new System.Windows.Forms.Padding(4);
            this.modelbox.Multiline = true;
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(404, 61);
            this.modelbox.TabIndex = 5;
            this.modelbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelbox.TextChanged += new System.EventHandler(this.modelbox_TextChanged);
            // 
            // modelNamebox
            // 
            this.modelNamebox.Font = new System.Drawing.Font("굴림", 20F);
            this.modelNamebox.Location = new System.Drawing.Point(759, 436);
            this.modelNamebox.Margin = new System.Windows.Forms.Padding(4);
            this.modelNamebox.Multiline = true;
            this.modelNamebox.Name = "modelNamebox";
            this.modelNamebox.Size = new System.Drawing.Size(404, 61);
            this.modelNamebox.TabIndex = 7;
            this.modelNamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelNamebox.TextChanged += new System.EventHandler(this.modelNamebox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1399, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "종료";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // modelinf
            // 
            this.modelinf.Font = new System.Drawing.Font("굴림", 15F);
            this.modelinf.Location = new System.Drawing.Point(1197, 388);
            this.modelinf.Margin = new System.Windows.Forms.Padding(4);
            this.modelinf.Name = "modelinf";
            this.modelinf.Size = new System.Drawing.Size(209, 56);
            this.modelinf.TabIndex = 10;
            this.modelinf.Text = "ModelINF";
            this.modelinf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modelinf.UseVisualStyleBackColor = true;
            this.modelinf.Click += new System.EventHandler(this.modelinf_Click);
            // 
            // DelBTN
            // 
            this.DelBTN.Location = new System.Drawing.Point(759, 552);
            this.DelBTN.Name = "DelBTN";
            this.DelBTN.Size = new System.Drawing.Size(136, 41);
            this.DelBTN.TabIndex = 11;
            this.DelBTN.Text = "삭제";
            this.DelBTN.UseVisualStyleBackColor = true;
            this.DelBTN.Click += new System.EventHandler(this.DelBTN_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 1162);
            this.ControlBox = false;
            this.Controls.Add(this.DelBTN);
            this.Controls.Add(this.modelinf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.modelNamebox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button modelinf;
        private System.Windows.Forms.Button DelBTN;
    }
}

