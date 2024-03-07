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
            this.components = new System.ComponentModel.Container();
            this.inspecterlist = new System.Windows.Forms.DataGridView();
            this.CarnameTX = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ALCTX = new System.Windows.Forms.TextBox();
            this.PartnumTX = new System.Windows.Forms.TextBox();
            this.SpecTX = new System.Windows.Forms.TextBox();
            this.Car_cate = new System.Windows.Forms.Label();
            this.ALC = new System.Windows.Forms.Label();
            this.Partname = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.Label();
            this.insertbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
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
            this.inspecterlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inspecterlist.Size = new System.Drawing.Size(693, 754);
            this.inspecterlist.TabIndex = 0;
            this.inspecterlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspecterlist_CellClick);
            this.inspecterlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspecterlist_CellContentClick);
            // 
            // CarnameTX
            // 
            this.CarnameTX.Location = new System.Drawing.Point(82, 13);
            this.CarnameTX.Name = "CarnameTX";
            this.CarnameTX.Size = new System.Drawing.Size(350, 21);
            this.CarnameTX.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ALCTX
            // 
            this.ALCTX.Location = new System.Drawing.Point(82, 40);
            this.ALCTX.Name = "ALCTX";
            this.ALCTX.Size = new System.Drawing.Size(350, 21);
            this.ALCTX.TabIndex = 3;
            // 
            // PartnumTX
            // 
            this.PartnumTX.Location = new System.Drawing.Point(82, 67);
            this.PartnumTX.Name = "PartnumTX";
            this.PartnumTX.Size = new System.Drawing.Size(350, 21);
            this.PartnumTX.TabIndex = 4;
            // 
            // SpecTX
            // 
            this.SpecTX.Location = new System.Drawing.Point(82, 94);
            this.SpecTX.Name = "SpecTX";
            this.SpecTX.Size = new System.Drawing.Size(350, 21);
            this.SpecTX.TabIndex = 5;
            // 
            // Car_cate
            // 
            this.Car_cate.AutoSize = true;
            this.Car_cate.Font = new System.Drawing.Font("굴림", 12F);
            this.Car_cate.Location = new System.Drawing.Point(26, 13);
            this.Car_cate.Name = "Car_cate";
            this.Car_cate.Size = new System.Drawing.Size(39, 16);
            this.Car_cate.TabIndex = 6;
            this.Car_cate.Text = "차종";
            // 
            // ALC
            // 
            this.ALC.AutoSize = true;
            this.ALC.Font = new System.Drawing.Font("굴림", 12F);
            this.ALC.Location = new System.Drawing.Point(26, 40);
            this.ALC.Name = "ALC";
            this.ALC.Size = new System.Drawing.Size(37, 16);
            this.ALC.TabIndex = 7;
            this.ALC.Text = "ALC";
            // 
            // Partname
            // 
            this.Partname.AutoSize = true;
            this.Partname.Font = new System.Drawing.Font("굴림", 12F);
            this.Partname.Location = new System.Drawing.Point(26, 67);
            this.Partname.Name = "Partname";
            this.Partname.Size = new System.Drawing.Size(39, 16);
            this.Partname.TabIndex = 8;
            this.Partname.Text = "품번";
            // 
            // Spec
            // 
            this.Spec.AutoSize = true;
            this.Spec.Font = new System.Drawing.Font("굴림", 12F);
            this.Spec.Location = new System.Drawing.Point(26, 94);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(39, 16);
            this.Spec.TabIndex = 9;
            this.Spec.Text = "사양";
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("굴림", 20F);
            this.insertbtn.Location = new System.Drawing.Point(479, 12);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(161, 39);
            this.insertbtn.TabIndex = 10;
            this.insertbtn.Text = "추 가";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Font = new System.Drawing.Font("굴림", 20F);
            this.Delbtn.Location = new System.Drawing.Point(479, 76);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(161, 39);
            this.Delbtn.TabIndex = 11;
            this.Delbtn.Text = "삭 제";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Checkprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 930);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.Partname);
            this.Controls.Add(this.ALC);
            this.Controls.Add(this.Car_cate);
            this.Controls.Add(this.SpecTX);
            this.Controls.Add(this.PartnumTX);
            this.Controls.Add(this.ALCTX);
            this.Controls.Add(this.CarnameTX);
            this.Controls.Add(this.inspecterlist);
            this.Name = "Checkprocess";
            this.Text = "CHKlist";
            this.Load += new System.EventHandler(this.Checkprocess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspecterlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inspecterlist;
        private System.Windows.Forms.TextBox CarnameTX;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ALCTX;
        private System.Windows.Forms.TextBox PartnumTX;
        private System.Windows.Forms.TextBox SpecTX;
        private System.Windows.Forms.Label Car_cate;
        private System.Windows.Forms.Label ALC;
        private System.Windows.Forms.Label Partname;
        private System.Windows.Forms.Label Spec;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button Delbtn;
    }
}