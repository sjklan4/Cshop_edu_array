namespace ModelINF
{
    partial class modelinf
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.frtfomebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("굴림", 15F);
            this.Exitbutton.Location = new System.Drawing.Point(651, 12);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(121, 30);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.Text = "종료";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // frtfomebtn
            // 
            this.frtfomebtn.Font = new System.Drawing.Font("굴림", 15F);
            this.frtfomebtn.Location = new System.Drawing.Point(651, 57);
            this.frtfomebtn.Name = "frtfomebtn";
            this.frtfomebtn.Size = new System.Drawing.Size(121, 31);
            this.frtfomebtn.TabIndex = 2;
            this.frtfomebtn.Text = "printSYS";
            this.frtfomebtn.UseVisualStyleBackColor = true;
            this.frtfomebtn.Click += new System.EventHandler(this.frtfomebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 656);
            this.Controls.Add(this.frtfomebtn);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button frtfomebtn;
    }
}

