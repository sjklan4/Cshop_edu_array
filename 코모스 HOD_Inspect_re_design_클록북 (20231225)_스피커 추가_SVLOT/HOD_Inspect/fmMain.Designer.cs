
namespace HOD_Inspect
{
    partial class fmMain
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnModel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_R_MAX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_R_MIN = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbR_Val = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gPanel3 = new GPanel();
            this.btnManual2 = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.txScan = new System.Windows.Forms.TextBox();
            this.lbPartNo = new System.Windows.Forms.Label();
            this.lbCNT = new System.Windows.Forms.Label();
            this.ssT = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.btnModelSet = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_J = new System.Windows.Forms.Label();
            this.lbPLCsts = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSpec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsts = new System.Windows.Forms.Label();
            this.gPanel2 = new GPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_D_MIN2 = new System.Windows.Forms.Label();
            this.lb_D_MAX2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbD_Val2 = new System.Windows.Forms.Label();
            this.lbD_Val = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_D_MIN = new System.Windows.Forms.Label();
            this.lb_D_MAX = new System.Windows.Forms.Label();
            this.gPanel1 = new GPanel();
            this.lbMax2 = new System.Windows.Forms.Label();
            this.lbMin2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMAX = new System.Windows.Forms.Label();
            this.lbMIN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVal2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVal = new System.Windows.Forms.Label();
            this.Maker = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.gPanel3.SuspendLayout();
            this.gPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.LightGray;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1280, 56);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HOD 검사기";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.DimGray;
            this.btnModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnModel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModel.ForeColor = System.Drawing.Color.White;
            this.btnModel.Image = global::HOD_Inspect.Properties.Resources.color_32;
            this.btnModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.Location = new System.Drawing.Point(5, 2);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(165, 51);
            this.btnModel.TabIndex = 6;
            this.btnModel.Text = "모델 선택";
            this.btnModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModel.UseVisualStyleBackColor = false;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::HOD_Inspect.Properties.Resources._1472652665_exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1113, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "종료";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DimGray;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = global::HOD_Inspect.Properties.Resources.Tests32;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(175, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(165, 51);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "조회";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.lb_R_MAX);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lb_R_MIN);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lbR_Val);
            this.panel3.Location = new System.Drawing.Point(1115, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 118);
            this.panel3.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(84, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 22);
            this.label18.TabIndex = 5;
            this.label18.Text = "MAX";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // lb_R_MAX
            // 
            this.lb_R_MAX.BackColor = System.Drawing.Color.White;
            this.lb_R_MAX.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_R_MAX.ForeColor = System.Drawing.Color.Black;
            this.lb_R_MAX.Location = new System.Drawing.Point(86, 88);
            this.lb_R_MAX.Name = "lb_R_MAX";
            this.lb_R_MAX.Size = new System.Drawing.Size(56, 22);
            this.lb_R_MAX.TabIndex = 5;
            this.lb_R_MAX.Text = "MIN";
            this.lb_R_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_R_MAX.Click += new System.EventHandler(this.lb_R_MAX_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(120, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ω";
            this.label14.DoubleClick += new System.EventHandler(this.label14_DoubleClick);
            // 
            // lb_R_MIN
            // 
            this.lb_R_MIN.BackColor = System.Drawing.Color.White;
            this.lb_R_MIN.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_R_MIN.ForeColor = System.Drawing.Color.Black;
            this.lb_R_MIN.Location = new System.Drawing.Point(4, 88);
            this.lb_R_MIN.Name = "lb_R_MIN";
            this.lb_R_MIN.Size = new System.Drawing.Size(66, 21);
            this.lb_R_MIN.TabIndex = 5;
            this.lb_R_MIN.Text = "MIN";
            this.lb_R_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "MIN";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbR_Val
            // 
            this.lbR_Val.BackColor = System.Drawing.Color.Chartreuse;
            this.lbR_Val.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbR_Val.Location = new System.Drawing.Point(4, 5);
            this.lbR_Val.Margin = new System.Windows.Forms.Padding(30);
            this.lbR_Val.Name = "lbR_Val";
            this.lbR_Val.Size = new System.Drawing.Size(139, 45);
            this.lbR_Val.TabIndex = 2;
            this.lbR_Val.Text = "232.332 ";
            this.lbR_Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::HOD_Inspect.Properties.Resources._1472652586_tick_16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(944, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "RESET";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gPanel3
            // 
            this.gPanel3.AllowDrop = true;
            this.gPanel3.BeginColor = System.Drawing.Color.LightGray;
            this.gPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gPanel3.BorderLineWidth = 0;
            this.gPanel3.Border색상 = System.Drawing.Color.Gainsboro;
            this.gPanel3.Controls.Add(this.btnManual2);
            this.gPanel3.Controls.Add(this.btnManual);
            this.gPanel3.Controls.Add(this.txScan);
            this.gPanel3.Controls.Add(this.lbPartNo);
            this.gPanel3.Controls.Add(this.lbCNT);
            this.gPanel3.Controls.Add(this.ssT);
            this.gPanel3.Controls.Add(this.btnModelSet);
            this.gPanel3.Controls.Add(this.btnSpec);
            this.gPanel3.Controls.Add(this.label6);
            this.gPanel3.Controls.Add(this.label4);
            this.gPanel3.Controls.Add(this.lb_J);
            this.gPanel3.Controls.Add(this.lbPLCsts);
            this.gPanel3.Controls.Add(this.label13);
            this.gPanel3.Controls.Add(this.lbSpec);
            this.gPanel3.Controls.Add(this.label10);
            this.gPanel3.Controls.Add(this.label3);
            this.gPanel3.Controls.Add(this.lbsts);
            this.gPanel3.EndColor = System.Drawing.Color.Gainsboro;
            this.gPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gPanel3.ForeColor = System.Drawing.Color.Black;
            this.gPanel3.GAngle = 70F;
            this.gPanel3.isRoundedEdge = true;
            this.gPanel3.LineAlign = System.Drawing.StringAlignment.Near;
            this.gPanel3.Location = new System.Drawing.Point(8, 724);
            this.gPanel3.MoveSpeed = 1000;
            this.gPanel3.Name = "gPanel2";
            this.gPanel3.RoundRadius = 20;
            this.gPanel3.Size = new System.Drawing.Size(1264, 291);
            this.gPanel3.StringAlign = System.Drawing.StringAlignment.Near;
            this.gPanel3.TabIndex = 180;
            // 
            // btnManual2
            // 
            this.btnManual2.Enabled = false;
            this.btnManual2.Font = new System.Drawing.Font("새굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManual2.Image = global::HOD_Inspect.Properties.Resources.color_32;
            this.btnManual2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual2.Location = new System.Drawing.Point(950, 202);
            this.btnManual2.Name = "btnManual2";
            this.btnManual2.Size = new System.Drawing.Size(150, 75);
            this.btnManual2.TabIndex = 27;
            this.btnManual2.Text = "  Z2수동";
            this.btnManual2.UseVisualStyleBackColor = true;
            this.btnManual2.Click += new System.EventHandler(this.btnManual2_Click);
            // 
            // btnManual
            // 
            this.btnManual.Enabled = false;
            this.btnManual.Font = new System.Drawing.Font("새굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManual.Image = global::HOD_Inspect.Properties.Resources.color_32;
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual.Location = new System.Drawing.Point(951, 118);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(150, 75);
            this.btnManual.TabIndex = 26;
            this.btnManual.Text = "  Z1수동";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // txScan
            // 
            this.txScan.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txScan.Location = new System.Drawing.Point(107, 65);
            this.txScan.Name = "txScan";
            this.txScan.Size = new System.Drawing.Size(338, 50);
            this.txScan.TabIndex = 25;
            this.txScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txScan_KeyPress);
            this.txScan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txScan_KeyUp);
            // 
            // lbPartNo
            // 
            this.lbPartNo.BackColor = System.Drawing.Color.White;
            this.lbPartNo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPartNo.ForeColor = System.Drawing.Color.Black;
            this.lbPartNo.Location = new System.Drawing.Point(110, 12);
            this.lbPartNo.Name = "lbPartNo";
            this.lbPartNo.Size = new System.Drawing.Size(335, 50);
            this.lbPartNo.TabIndex = 17;
            this.lbPartNo.Text = "품번";
            this.lbPartNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCNT
            // 
            this.lbCNT.AutoSize = true;
            this.lbCNT.Location = new System.Drawing.Point(977, 78);
            this.lbCNT.Name = "lbCNT";
            this.lbCNT.Size = new System.Drawing.Size(0, 20);
            this.lbCNT.TabIndex = 24;
            // 
            // ssT
            // 
            this.ssT.ArrayCount = 2;
            this.ssT.ColorBackground = System.Drawing.Color.Black;
            this.ssT.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.ssT.ColorLight = System.Drawing.Color.Yellow;
            this.ssT.DecimalShow = true;
            this.ssT.ElementPadding = new System.Windows.Forms.Padding(4);
            this.ssT.ElementWidth = 10;
            this.ssT.ForeColor = System.Drawing.Color.Yellow;
            this.ssT.ItalicFactor = 0F;
            this.ssT.Location = new System.Drawing.Point(1106, 118);
            this.ssT.Name = "ssT";
            this.ssT.Size = new System.Drawing.Size(150, 159);
            this.ssT.TabIndex = 23;
            this.ssT.TabStop = false;
            this.ssT.Value = null;
            // 
            // btnModelSet
            // 
            this.btnModelSet.BackColor = System.Drawing.Color.DimGray;
            this.btnModelSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnModelSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModelSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelSet.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModelSet.ForeColor = System.Drawing.Color.White;
            this.btnModelSet.Image = global::HOD_Inspect.Properties.Resources._1472652599_plus_16;
            this.btnModelSet.Location = new System.Drawing.Point(845, 10);
            this.btnModelSet.Name = "btnModelSet";
            this.btnModelSet.Size = new System.Drawing.Size(162, 52);
            this.btnModelSet.TabIndex = 21;
            this.btnModelSet.Text = "모델 설정";
            this.btnModelSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModelSet.UseVisualStyleBackColor = false;
            this.btnModelSet.Click += new System.EventHandler(this.btnModelSet_Click);
            // 
            // btnSpec
            // 
            this.btnSpec.BackColor = System.Drawing.Color.DimGray;
            this.btnSpec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSpec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpec.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpec.ForeColor = System.Drawing.Color.White;
            this.btnSpec.Image = global::HOD_Inspect.Properties.Resources._1472653876_Save_as;
            this.btnSpec.Location = new System.Drawing.Point(1009, 10);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(162, 52);
            this.btnSpec.TabIndex = 22;
            this.btnSpec.Text = "검사 설정";
            this.btnSpec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpec.UseVisualStyleBackColor = false;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1106, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "측정 시간";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(448, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(654, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "결과 표시";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_J
            // 
            this.lb_J.BackColor = System.Drawing.Color.Lime;
            this.lb_J.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_J.ForeColor = System.Drawing.Color.White;
            this.lb_J.Location = new System.Drawing.Point(449, 118);
            this.lb_J.Name = "lb_J";
            this.lb_J.Size = new System.Drawing.Size(498, 159);
            this.lb_J.TabIndex = 13;
            this.lb_J.Text = "OK";
            this.lb_J.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPLCsts
            // 
            this.lbPLCsts.BackColor = System.Drawing.Color.DarkGreen;
            this.lbPLCsts.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPLCsts.ForeColor = System.Drawing.Color.White;
            this.lbPLCsts.Location = new System.Drawing.Point(1174, 12);
            this.lbPLCsts.Name = "lbPLCsts";
            this.lbPLCsts.Size = new System.Drawing.Size(82, 50);
            this.lbPLCsts.TabIndex = 14;
            this.lbPLCsts.Text = "PLC";
            this.lbPLCsts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(448, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 50);
            this.label13.TabIndex = 15;
            this.label13.Text = "사양";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSpec
            // 
            this.lbSpec.BackColor = System.Drawing.Color.White;
            this.lbSpec.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSpec.ForeColor = System.Drawing.Color.Black;
            this.lbSpec.Location = new System.Drawing.Point(552, 12);
            this.lbSpec.Name = "lbSpec";
            this.lbSpec.Size = new System.Drawing.Size(287, 50);
            this.lbSpec.TabIndex = 16;
            this.lbSpec.Text = "사양";
            this.lbSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 50);
            this.label10.TabIndex = 18;
            this.label10.Text = "품번";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 50);
            this.label3.TabIndex = 19;
            this.label3.Text = "작업 상태 표시";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsts
            // 
            this.lbsts.BackColor = System.Drawing.Color.Black;
            this.lbsts.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbsts.ForeColor = System.Drawing.Color.Yellow;
            this.lbsts.Location = new System.Drawing.Point(5, 115);
            this.lbsts.Name = "lbsts";
            this.lbsts.Size = new System.Drawing.Size(440, 162);
            this.lbsts.TabIndex = 20;
            this.lbsts.Text = "측정 종료";
            this.lbsts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gPanel2
            // 
            this.gPanel2.AllowDrop = true;
            this.gPanel2.BeginColor = System.Drawing.Color.LightGray;
            this.gPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gPanel2.BorderLineWidth = 0;
            this.gPanel2.Border색상 = System.Drawing.Color.Gainsboro;
            this.gPanel2.Controls.Add(this.panel3);
            this.gPanel2.Controls.Add(this.label16);
            this.gPanel2.Controls.Add(this.label17);
            this.gPanel2.Controls.Add(this.lb_D_MIN2);
            this.gPanel2.Controls.Add(this.lb_D_MAX2);
            this.gPanel2.Controls.Add(this.label11);
            this.gPanel2.Controls.Add(this.label19);
            this.gPanel2.Controls.Add(this.panel4);
            this.gPanel2.Controls.Add(this.lb_D_MIN);
            this.gPanel2.Controls.Add(this.lb_D_MAX);
            this.gPanel2.EndColor = System.Drawing.Color.Gainsboro;
            this.gPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gPanel2.ForeColor = System.Drawing.Color.Black;
            this.gPanel2.GAngle = 70F;
            this.gPanel2.isRoundedEdge = true;
            this.gPanel2.LineAlign = System.Drawing.StringAlignment.Near;
            this.gPanel2.Location = new System.Drawing.Point(9, 385);
            this.gPanel2.MoveSpeed = 1000;
            this.gPanel2.Name = "gPanel2";
            this.gPanel2.RoundRadius = 20;
            this.gPanel2.Size = new System.Drawing.Size(1261, 328);
            this.gPanel2.StringAlign = System.Drawing.StringAlignment.Near;
            this.gPanel2.TabIndex = 179;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(838, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(277, 50);
            this.label16.TabIndex = 12;
            this.label16.Text = "Zone2 D MAX";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(568, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 50);
            this.label17.TabIndex = 11;
            this.label17.Text = "Zone2 D MIN";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_D_MIN2
            // 
            this.lb_D_MIN2.BackColor = System.Drawing.Color.White;
            this.lb_D_MIN2.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_D_MIN2.ForeColor = System.Drawing.Color.Black;
            this.lb_D_MIN2.Location = new System.Drawing.Point(568, 249);
            this.lb_D_MIN2.Name = "lb_D_MIN2";
            this.lb_D_MIN2.Size = new System.Drawing.Size(264, 62);
            this.lb_D_MIN2.TabIndex = 9;
            this.lb_D_MIN2.Text = "MIN";
            this.lb_D_MIN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_D_MAX2
            // 
            this.lb_D_MAX2.BackColor = System.Drawing.Color.White;
            this.lb_D_MAX2.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_D_MAX2.ForeColor = System.Drawing.Color.Black;
            this.lb_D_MAX2.Location = new System.Drawing.Point(838, 249);
            this.lb_D_MAX2.Name = "lb_D_MAX2";
            this.lb_D_MAX2.Size = new System.Drawing.Size(277, 62);
            this.lb_D_MAX2.TabIndex = 10;
            this.lb_D_MAX2.Text = "MIN";
            this.lb_D_MAX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(280, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 50);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zone1 D MAX";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(10, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(264, 50);
            this.label19.TabIndex = 7;
            this.label19.Text = "Zone1 D MIN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.panel4.Controls.Add(this.lbD_Val2);
            this.panel4.Controls.Add(this.lbD_Val);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(9, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 181);
            this.panel4.TabIndex = 3;
            // 
            // lbD_Val2
            // 
            this.lbD_Val2.BackColor = System.Drawing.Color.DarkGray;
            this.lbD_Val2.Font = new System.Drawing.Font("맑은 고딕", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbD_Val2.Location = new System.Drawing.Point(560, 12);
            this.lbD_Val2.Margin = new System.Windows.Forms.Padding(30);
            this.lbD_Val2.Name = "lbD_Val2";
            this.lbD_Val2.Size = new System.Drawing.Size(546, 163);
            this.lbD_Val2.TabIndex = 5;
            this.lbD_Val2.Text = "232.332";
            this.lbD_Val2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbD_Val
            // 
            this.lbD_Val.BackColor = System.Drawing.Color.White;
            this.lbD_Val.Font = new System.Drawing.Font("맑은 고딕", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbD_Val.Location = new System.Drawing.Point(5, 13);
            this.lbD_Val.Margin = new System.Windows.Forms.Padding(30);
            this.lbD_Val.Name = "lbD_Val";
            this.lbD_Val.Size = new System.Drawing.Size(543, 162);
            this.lbD_Val.TabIndex = 2;
            this.lbD_Val.Text = "232.332";
            this.lbD_Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(1106, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 163);
            this.label8.TabIndex = 4;
            this.label8.Text = "D";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_D_MIN
            // 
            this.lb_D_MIN.BackColor = System.Drawing.Color.White;
            this.lb_D_MIN.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_D_MIN.ForeColor = System.Drawing.Color.Black;
            this.lb_D_MIN.Location = new System.Drawing.Point(10, 248);
            this.lb_D_MIN.Name = "lb_D_MIN";
            this.lb_D_MIN.Size = new System.Drawing.Size(264, 62);
            this.lb_D_MIN.TabIndex = 5;
            this.lb_D_MIN.Text = "MIN";
            this.lb_D_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_D_MAX
            // 
            this.lb_D_MAX.BackColor = System.Drawing.Color.White;
            this.lb_D_MAX.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_D_MAX.ForeColor = System.Drawing.Color.Black;
            this.lb_D_MAX.Location = new System.Drawing.Point(280, 248);
            this.lb_D_MAX.Name = "lb_D_MAX";
            this.lb_D_MAX.Size = new System.Drawing.Size(277, 62);
            this.lb_D_MAX.TabIndex = 5;
            this.lb_D_MAX.Text = "MIN";
            this.lb_D_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gPanel1
            // 
            this.gPanel1.AllowDrop = true;
            this.gPanel1.BeginColor = System.Drawing.Color.LightGray;
            this.gPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gPanel1.BorderLineWidth = 0;
            this.gPanel1.Border색상 = System.Drawing.Color.Gainsboro;
            this.gPanel1.Controls.Add(this.lbMax2);
            this.gPanel1.Controls.Add(this.lbMin2);
            this.gPanel1.Controls.Add(this.label9);
            this.gPanel1.Controls.Add(this.label12);
            this.gPanel1.Controls.Add(this.label7);
            this.gPanel1.Controls.Add(this.lbMAX);
            this.gPanel1.Controls.Add(this.lbMIN);
            this.gPanel1.Controls.Add(this.label5);
            this.gPanel1.Controls.Add(this.panel1);
            this.gPanel1.EndColor = System.Drawing.Color.Gainsboro;
            this.gPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gPanel1.ForeColor = System.Drawing.Color.Black;
            this.gPanel1.GAngle = 70F;
            this.gPanel1.isRoundedEdge = true;
            this.gPanel1.LineAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.Location = new System.Drawing.Point(8, 62);
            this.gPanel1.MoveSpeed = 1000;
            this.gPanel1.Name = "gPanel2";
            this.gPanel1.RoundRadius = 20;
            this.gPanel1.Size = new System.Drawing.Size(1263, 317);
            this.gPanel1.StringAlign = System.Drawing.StringAlignment.Near;
            this.gPanel1.TabIndex = 178;
            // 
            // lbMax2
            // 
            this.lbMax2.BackColor = System.Drawing.Color.White;
            this.lbMax2.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMax2.ForeColor = System.Drawing.Color.Black;
            this.lbMax2.Location = new System.Drawing.Point(838, 244);
            this.lbMax2.Name = "lbMax2";
            this.lbMax2.Size = new System.Drawing.Size(277, 62);
            this.lbMax2.TabIndex = 13;
            this.lbMax2.Text = "MIN";
            this.lbMax2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMin2
            // 
            this.lbMin2.BackColor = System.Drawing.Color.White;
            this.lbMin2.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMin2.ForeColor = System.Drawing.Color.Black;
            this.lbMin2.Location = new System.Drawing.Point(568, 244);
            this.lbMin2.Name = "lbMin2";
            this.lbMin2.Size = new System.Drawing.Size(264, 62);
            this.lbMin2.TabIndex = 12;
            this.lbMin2.Text = "MIN";
            this.lbMin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(838, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 50);
            this.label9.TabIndex = 11;
            this.label9.Text = "Zone2 Cp MAX";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(568, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 50);
            this.label12.TabIndex = 10;
            this.label12.Text = "Zone2 Cp MIN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(281, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "Zone1 Cp MAX";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMAX
            // 
            this.lbMAX.BackColor = System.Drawing.Color.White;
            this.lbMAX.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMAX.ForeColor = System.Drawing.Color.Black;
            this.lbMAX.Location = new System.Drawing.Point(281, 244);
            this.lbMAX.Name = "lbMAX";
            this.lbMAX.Size = new System.Drawing.Size(277, 62);
            this.lbMAX.TabIndex = 9;
            this.lbMAX.Text = "MIN";
            this.lbMAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMIN
            // 
            this.lbMIN.BackColor = System.Drawing.Color.White;
            this.lbMIN.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMIN.ForeColor = System.Drawing.Color.Black;
            this.lbMIN.Location = new System.Drawing.Point(11, 244);
            this.lbMIN.Name = "lbMIN";
            this.lbMIN.Size = new System.Drawing.Size(264, 62);
            this.lbMIN.TabIndex = 6;
            this.lbMIN.Text = "MIN";
            this.lbMIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 50);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zone1 Cp MIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.lbVal2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbVal);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 181);
            this.panel1.TabIndex = 3;
            // 
            // lbVal2
            // 
            this.lbVal2.BackColor = System.Drawing.Color.DarkGray;
            this.lbVal2.Font = new System.Drawing.Font("맑은 고딕", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVal2.Location = new System.Drawing.Point(558, 14);
            this.lbVal2.Margin = new System.Windows.Forms.Padding(30);
            this.lbVal2.Name = "lbVal2";
            this.lbVal2.Size = new System.Drawing.Size(546, 162);
            this.lbVal2.TabIndex = 5;
            this.lbVal2.Text = "232.332";
            this.lbVal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(99)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(1100, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 162);
            this.label2.TabIndex = 4;
            this.label2.Text = "pF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbVal
            // 
            this.lbVal.BackColor = System.Drawing.Color.White;
            this.lbVal.Font = new System.Drawing.Font("맑은 고딕", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVal.Location = new System.Drawing.Point(5, 14);
            this.lbVal.Margin = new System.Windows.Forms.Padding(30);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(543, 161);
            this.lbVal.TabIndex = 2;
            this.lbVal.Text = "232.332";
            this.lbVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Maker
            // 
            this.Maker.AutoSize = true;
            this.Maker.Location = new System.Drawing.Point(870, 27);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(24, 12);
            this.Maker.TabIndex = 181;
            this.Maker.Text = "IEE";
            // 
            // fmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.gPanel3);
            this.Controls.Add(this.gPanel2);
            this.Controls.Add(this.gPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gPanel3.ResumeLayout(false);
            this.gPanel3.PerformLayout();
            this.gPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbVal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbD_Val;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_D_MIN;
        private System.Windows.Forms.Label lb_D_MAX;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbR_Val;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_R_MIN;
        private System.Windows.Forms.Label lb_R_MAX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private GPanel gPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMAX;
        private System.Windows.Forms.Label lbMIN;
        private System.Windows.Forms.Label label5;
        private GPanel gPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private GPanel gPanel3;
        private System.Windows.Forms.Label lbCNT;
        private DmitryBrant.CustomControls.SevenSegmentArray ssT;
        private System.Windows.Forms.Button btnModelSet;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_J;
        private System.Windows.Forms.Label lbPLCsts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSpec;
        private System.Windows.Forms.Label lbPartNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsts;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_D_MIN2;
        private System.Windows.Forms.Label lb_D_MAX2;
        private System.Windows.Forms.Label lbD_Val2;
        private System.Windows.Forms.Label lbMax2;
        private System.Windows.Forms.Label lbMin2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbVal2;
        public System.Windows.Forms.TextBox txScan;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnManual2;
        private System.Windows.Forms.Label Maker;
    }
}

