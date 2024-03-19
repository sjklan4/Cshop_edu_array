namespace PrintSystemProto
{
    partial class InspecterCNT
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LOAD_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LOAD_btn
            // 
            this.LOAD_btn.Font = new System.Drawing.Font("굴림", 19F, System.Drawing.FontStyle.Bold);
            this.LOAD_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LOAD_btn.Location = new System.Drawing.Point(32, 573);
            this.LOAD_btn.Name = "LOAD_btn";
            this.LOAD_btn.Size = new System.Drawing.Size(148, 47);
            this.LOAD_btn.TabIndex = 1;
            this.LOAD_btn.Text = "LOAD";
            this.LOAD_btn.UseVisualStyleBackColor = true;
            this.LOAD_btn.Click += new System.EventHandler(this.LOAD_btn_Click);
            // 
            // InspecterCNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 765);
            this.Controls.Add(this.LOAD_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InspecterCNT";
            this.Text = "InspecterCNT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LOAD_btn;
    }
}