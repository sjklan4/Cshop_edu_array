namespace PrintSystemProto
{
    partial class Checkprocess
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
            this.inspecterlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inspecterlist)).BeginInit();
            this.SuspendLayout();
            // 
            // inspecterlist
            // 
            this.inspecterlist.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inspecterlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspecterlist.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.inspecterlist.Location = new System.Drawing.Point(28, 143);
            this.inspecterlist.Name = "inspecterlist";
            this.inspecterlist.RowTemplate.Height = 23;
            this.inspecterlist.Size = new System.Drawing.Size(693, 754);
            this.inspecterlist.TabIndex = 0;
            // 
            // Checkprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 930);
            this.Controls.Add(this.inspecterlist);
            this.Name = "Checkprocess";
            this.Text = "CHKlist";
            this.Load += new System.EventHandler(this.Checkprocess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspecterlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inspecterlist;
    }
}