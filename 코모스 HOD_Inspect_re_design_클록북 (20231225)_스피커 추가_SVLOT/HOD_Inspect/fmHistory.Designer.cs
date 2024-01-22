
namespace HOD_Inspect
{
    partial class fmHistory
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
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gPanel1 = new GPanel();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.gPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gLabel2
            // 
            this.gLabel2.BeginColor = System.Drawing.Color.DodgerBlue;
            this.gLabel2.EndColor = System.Drawing.Color.RoyalBlue;
            this.gLabel2.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gLabel2.ForeColor = System.Drawing.Color.White;
            this.gLabel2.GAngle = 120F;
            this.gLabel2.Location = new System.Drawing.Point(4, 3);
            this.gLabel2.Name = "gLabel2";
            this.gLabel2.Size = new System.Drawing.Size(1122, 46);
            this.gLabel2.TabIndex = 29;
            this.gLabel2.Text = "조  회";
            this.gLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brnEXIT
            // 
            this.brnEXIT.Font = new System.Drawing.Font("맑은 고딕", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.brnEXIT.ForeColor = System.Drawing.Color.Black;
            this.brnEXIT.Location = new System.Drawing.Point(954, 7);
            this.brnEXIT.Name = "brnEXIT";
            this.brnEXIT.Size = new System.Drawing.Size(167, 38);
            this.brnEXIT.TabIndex = 30;
            this.brnEXIT.Text = "Exit";
            this.brnEXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnEXIT.UseVisualStyleBackColor = true;
            this.brnEXIT.Click += new System.EventHandler(this.brnEXIT_Click);
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Location = new System.Drawing.Point(6, 93);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.Size = new System.Drawing.Size(1119, 742);
            this.fpSpread1.TabIndex = 31;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 34);
            this.label9.TabIndex = 32;
            this.label9.Text = "시작 날짜";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "종료 날짜";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStart
            // 
            this.dtStart.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Location = new System.Drawing.Point(157, 53);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(243, 33);
            this.dtStart.TabIndex = 33;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Location = new System.Drawing.Point(555, 53);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(246, 33);
            this.dtEnd.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::HOD_Inspect.Properties.Resources.iconfinder_magnifier_data_532758;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(807, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 39);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "조회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::HOD_Inspect.Properties.Resources.if_microsoft_office_excel_1784856;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(967, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "엑셀 저장";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gPanel1
            // 
            this.gPanel1.AllowDrop = true;
            this.gPanel1.BeginColor = System.Drawing.Color.White;
            this.gPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gPanel1.BorderLineWidth = 0;
            this.gPanel1.Border색상 = System.Drawing.Color.Gainsboro;
            this.gPanel1.Controls.Add(this.brnEXIT);
            this.gPanel1.Controls.Add(this.fpSpread1);
            this.gPanel1.Controls.Add(this.button1);
            this.gPanel1.Controls.Add(this.gLabel2);
            this.gPanel1.Controls.Add(this.btnSearch);
            this.gPanel1.Controls.Add(this.label9);
            this.gPanel1.Controls.Add(this.dtEnd);
            this.gPanel1.Controls.Add(this.label1);
            this.gPanel1.Controls.Add(this.dtStart);
            this.gPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPanel1.EndColor = System.Drawing.Color.Gainsboro;
            this.gPanel1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gPanel1.ForeColor = System.Drawing.Color.Black;
            this.gPanel1.GAngle = 70F;
            this.gPanel1.isRoundedEdge = true;
            this.gPanel1.LineAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.Location = new System.Drawing.Point(5, 5);
            this.gPanel1.MoveSpeed = 1000;
            this.gPanel1.Name = "gPanel2";
            this.gPanel1.RoundRadius = 1;
            this.gPanel1.Size = new System.Drawing.Size(1128, 838);
            this.gPanel1.StringAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.TabIndex = 179;
            // 
            // fmHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1138, 848);
            this.Controls.Add(this.gPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmHistory";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmHistory";
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.gPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GLabel gLabel2;
        private System.Windows.Forms.Button brnEXIT;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private GPanel gPanel1;
    }
}