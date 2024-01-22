
namespace HOD_Inspect
{
    partial class fmModelSetcs
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
            this.gLabel2 = new GLabel();
            this.brnEXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fpCar = new FarPoint.Win.Spread.FpSpread();
            this.fpCar_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label2 = new System.Windows.Forms.Label();
            this.txCar = new System.Windows.Forms.TextBox();
            this.btn_Car_ADD = new System.Windows.Forms.Button();
            this.btn_Car_DEL = new System.Windows.Forms.Button();
            this.gPanel1 = new GPanel();
            this.btn_Model_DEL = new System.Windows.Forms.Button();
            this.btn_Model_ADD = new System.Windows.Forms.Button();
            this.txSpec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPartNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fpModels = new FarPoint.Win.Spread.FpSpread();
            this.fpModels_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.fpCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpCar_Sheet1)).BeginInit();
            this.gPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpModels_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gLabel2
            // 
            this.gLabel2.BeginColor = System.Drawing.Color.RoyalBlue;
            this.gLabel2.EndColor = System.Drawing.Color.RoyalBlue;
            this.gLabel2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gLabel2.ForeColor = System.Drawing.Color.White;
            this.gLabel2.GAngle = 90F;
            this.gLabel2.Location = new System.Drawing.Point(5, 3);
            this.gLabel2.Name = "gLabel2";
            this.gLabel2.Size = new System.Drawing.Size(840, 44);
            this.gLabel2.TabIndex = 28;
            this.gLabel2.Text = "모델 선택";
            this.gLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brnEXIT
            // 
            this.brnEXIT.Font = new System.Drawing.Font("맑은 고딕", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.brnEXIT.ForeColor = System.Drawing.Color.Black;
            this.brnEXIT.Location = new System.Drawing.Point(712, 7);
            this.brnEXIT.Name = "brnEXIT";
            this.brnEXIT.Size = new System.Drawing.Size(128, 37);
            this.brnEXIT.TabIndex = 29;
            this.brnEXIT.Text = "Exit";
            this.brnEXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnEXIT.UseVisualStyleBackColor = true;
            this.brnEXIT.Click += new System.EventHandler(this.brnEXIT_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "차종 항목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpCar
            // 
            this.fpCar.AccessibleDescription = "";
            this.fpCar.Location = new System.Drawing.Point(6, 84);
            this.fpCar.Name = "fpCar";
            this.fpCar.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpCar_Sheet1});
            this.fpCar.Size = new System.Drawing.Size(386, 188);
            this.fpCar.TabIndex = 30;
            this.fpCar.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.fpCar_SelectionChanged);
            // 
            // fpCar_Sheet1
            // 
            this.fpCar_Sheet1.Reset();
            this.fpCar_Sheet1.SheetName = "Sheet1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "차종";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txCar
            // 
            this.txCar.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txCar.Location = new System.Drawing.Point(583, 111);
            this.txCar.Name = "txCar";
            this.txCar.Size = new System.Drawing.Size(240, 39);
            this.txCar.TabIndex = 32;
            this.txCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txCar.TextChanged += new System.EventHandler(this.txCar_TextChanged);
            // 
            // btn_Car_ADD
            // 
            this.btn_Car_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.btn_Car_ADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Car_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Car_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car_ADD.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Car_ADD.ForeColor = System.Drawing.Color.White;
            this.btn_Car_ADD.Image = global::HOD_Inspect.Properties.Resources._1472652599_plus_16;
            this.btn_Car_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Car_ADD.Location = new System.Drawing.Point(585, 162);
            this.btn_Car_ADD.Name = "btn_Car_ADD";
            this.btn_Car_ADD.Size = new System.Drawing.Size(238, 50);
            this.btn_Car_ADD.TabIndex = 33;
            this.btn_Car_ADD.Text = "추가";
            this.btn_Car_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Car_ADD.UseVisualStyleBackColor = false;
            this.btn_Car_ADD.Click += new System.EventHandler(this.btn_Car_ADD_Click);
            // 
            // btn_Car_DEL
            // 
            this.btn_Car_DEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.btn_Car_DEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Car_DEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Car_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car_DEL.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Car_DEL.ForeColor = System.Drawing.Color.White;
            this.btn_Car_DEL.Image = global::HOD_Inspect.Properties.Resources._1472652672_edit_remove;
            this.btn_Car_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Car_DEL.Location = new System.Drawing.Point(585, 210);
            this.btn_Car_DEL.Name = "btn_Car_DEL";
            this.btn_Car_DEL.Size = new System.Drawing.Size(238, 50);
            this.btn_Car_DEL.TabIndex = 33;
            this.btn_Car_DEL.Text = "삭제";
            this.btn_Car_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Car_DEL.UseVisualStyleBackColor = false;
            this.btn_Car_DEL.Click += new System.EventHandler(this.btn_Car_DEL_Click);
            // 
            // gPanel1
            // 
            this.gPanel1.AllowDrop = true;
            this.gPanel1.BeginColor = System.Drawing.Color.LightGray;
            this.gPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gPanel1.BorderLineWidth = 0;
            this.gPanel1.Border색상 = System.Drawing.Color.Gainsboro;
            this.gPanel1.Controls.Add(this.brnEXIT);
            this.gPanel1.Controls.Add(this.btn_Model_DEL);
            this.gPanel1.Controls.Add(this.btn_Model_ADD);
            this.gPanel1.Controls.Add(this.txSpec);
            this.gPanel1.Controls.Add(this.label4);
            this.gPanel1.Controls.Add(this.txPartNo);
            this.gPanel1.Controls.Add(this.label3);
            this.gPanel1.Controls.Add(this.label5);
            this.gPanel1.Controls.Add(this.fpModels);
            this.gPanel1.Controls.Add(this.gLabel2);
            this.gPanel1.Controls.Add(this.btn_Car_DEL);
            this.gPanel1.Controls.Add(this.label1);
            this.gPanel1.Controls.Add(this.fpCar);
            this.gPanel1.Controls.Add(this.btn_Car_ADD);
            this.gPanel1.Controls.Add(this.txCar);
            this.gPanel1.Controls.Add(this.label2);
            this.gPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPanel1.EndColor = System.Drawing.Color.Gainsboro;
            this.gPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gPanel1.ForeColor = System.Drawing.Color.Black;
            this.gPanel1.GAngle = 70F;
            this.gPanel1.LineAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.Location = new System.Drawing.Point(5, 5);
            this.gPanel1.MoveSpeed = 1000;
            this.gPanel1.Name = "gPanel2";
            this.gPanel1.RoundRadius = 1;
            this.gPanel1.Size = new System.Drawing.Size(848, 812);
            this.gPanel1.StringAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.TabIndex = 179;
            // 
            // btn_Model_DEL
            // 
            this.btn_Model_DEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.btn_Model_DEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Model_DEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Model_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Model_DEL.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Model_DEL.ForeColor = System.Drawing.Color.White;
            this.btn_Model_DEL.Image = global::HOD_Inspect.Properties.Resources._1472652672_edit_remove;
            this.btn_Model_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Model_DEL.Location = new System.Drawing.Point(583, 534);
            this.btn_Model_DEL.Name = "btn_Model_DEL";
            this.btn_Model_DEL.Size = new System.Drawing.Size(238, 50);
            this.btn_Model_DEL.TabIndex = 40;
            this.btn_Model_DEL.Text = "삭제";
            this.btn_Model_DEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Model_DEL.UseVisualStyleBackColor = false;
            this.btn_Model_DEL.Click += new System.EventHandler(this.btn_Model_DEL_Click);
            // 
            // btn_Model_ADD
            // 
            this.btn_Model_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.btn_Model_ADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btn_Model_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Model_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Model_ADD.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Model_ADD.ForeColor = System.Drawing.Color.White;
            this.btn_Model_ADD.Image = global::HOD_Inspect.Properties.Resources._1472652599_plus_16;
            this.btn_Model_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Model_ADD.Location = new System.Drawing.Point(583, 483);
            this.btn_Model_ADD.Name = "btn_Model_ADD";
            this.btn_Model_ADD.Size = new System.Drawing.Size(238, 50);
            this.btn_Model_ADD.TabIndex = 41;
            this.btn_Model_ADD.Text = "추가";
            this.btn_Model_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Model_ADD.UseVisualStyleBackColor = false;
            this.btn_Model_ADD.Click += new System.EventHandler(this.btn_Model_ADD_Click);
            // 
            // txSpec
            // 
            this.txSpec.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txSpec.Location = new System.Drawing.Point(583, 428);
            this.txSpec.Name = "txSpec";
            this.txSpec.Size = new System.Drawing.Size(240, 39);
            this.txSpec.TabIndex = 38;
            this.txSpec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 39);
            this.label4.TabIndex = 36;
            this.label4.Text = "사양";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txPartNo
            // 
            this.txPartNo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txPartNo.Location = new System.Drawing.Point(583, 381);
            this.txPartNo.Name = "txPartNo";
            this.txPartNo.Size = new System.Drawing.Size(240, 39);
            this.txPartNo.TabIndex = 39;
            this.txPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 40);
            this.label3.TabIndex = 37;
            this.label3.Text = "품번";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(839, 30);
            this.label5.TabIndex = 35;
            this.label5.Text = "모델 항목";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpModels
            // 
            this.fpModels.AccessibleDescription = "";
            this.fpModels.Location = new System.Drawing.Point(6, 309);
            this.fpModels.Name = "fpModels";
            this.fpModels.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpModels_Sheet1});
            this.fpModels.Size = new System.Drawing.Size(385, 500);
            this.fpModels.TabIndex = 34;
            this.fpModels.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.fpModels_SelectionChanged);
            // 
            // fpModels_Sheet1
            // 
            this.fpModels_Sheet1.Reset();
            this.fpModels_Sheet1.SheetName = "Sheet1";
            // 
            // fmModelSetcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(858, 822);
            this.Controls.Add(this.gPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmModelSetcs";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmModelSetcs";
            ((System.ComponentModel.ISupportInitialize)(this.fpCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpCar_Sheet1)).EndInit();
            this.gPanel1.ResumeLayout(false);
            this.gPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpModels_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GLabel gLabel2;
        private System.Windows.Forms.Button brnEXIT;
        private System.Windows.Forms.Label label1;
        private FarPoint.Win.Spread.FpSpread fpCar;
        private FarPoint.Win.Spread.SheetView fpCar_Sheet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCar;
        private System.Windows.Forms.Button btn_Car_ADD;
        private System.Windows.Forms.Button btn_Car_DEL;
        private GPanel gPanel1;
        private System.Windows.Forms.Button btn_Model_DEL;
        private System.Windows.Forms.Button btn_Model_ADD;
        private System.Windows.Forms.TextBox txSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private FarPoint.Win.Spread.FpSpread fpModels;
        private FarPoint.Win.Spread.SheetView fpModels_Sheet1;
    }
}