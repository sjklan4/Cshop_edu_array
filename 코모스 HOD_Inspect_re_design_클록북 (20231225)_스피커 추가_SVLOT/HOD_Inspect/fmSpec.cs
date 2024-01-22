using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOD_Inspect
{
    public partial class fmSpec : Form
    {
        public fmSpec()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;

#if (ENGLISH)
            groupBox1.Text = "CP";
            groupBox2.Text = "D"; 
            groupBox3.Text = "CONFIG";
            groupBox4.Text = "REGISTER";
            label4.Text = "TIME";
            label10.Text = "MIN VALUE";
            btnSave.Text = "SAVE";
            ckPrintUSE.Text = "USE PRINTER";
            ckLCR_USE.Text = "USE MULTIMETER";
            ckDbCheck.Text = "USE DB";
            ckWord_LOC.Text = "WORD POS(F/B)";
#else
            groupBox1.Text = "CP 설정";
            groupBox2.Text = "D 설정"; 
            groupBox3.Text = "설정";
            groupBox4.Text = "저항설정";
            label4.Text = "검사시간";
            label10.Text = "최소변화값";
            btnSave.Text = "저장";
            ckPrintUSE.Text = "프린터 사용";
            ckLCR_USE.Text = "멀티메터 사용";
            ckDbCheck.Text = "연동사용";
            ckWord_LOC.Text = "문자위치(전/후)";
#endif

            //txMIN.Text = cSetting.Set.MIN.ToString();
            //txMAX.Text = cSetting.Set.MAX.ToString();

            //txD_MIN.Text = cSetting.Set.D_MIN.ToString();
            //txD_MAX.Text = cSetting.Set.D_MAX.ToString();

            //txR_MIN.Text = cSetting.Set.R_MIN.ToString();
            //txR_MAX.Text = cSetting.Set.R_MAX.ToString();

            DataTable Spec_DT = SQL.GetCarSpec(MAIN.SelCar);
            if (Spec_DT != null && Spec_DT.Rows.Count > 0)
            {
                //CarCode, CP_MIN, CP_MAX, D_MIN, D_MAX, R_MIN, R_MAX
                DataRow R = Spec_DT.Rows[0];
                txMIN.Text = R["CP_MIN"].ToString();
                txMAX.Text = R["CP_MAX"].ToString();

                txD_MIN.Text = R["D_MIN"].ToString();
                txD_MAX.Text = R["D_MAX"].ToString();

                // 20230915 JHLEE
                txMIN2.Text = R["CP_MIN2"].ToString();
                txMAX2.Text = R["CP_MAX2"].ToString();

                txD_MIN2.Text = R["D_MIN2"].ToString();
                txD_MAX2.Text = R["D_MAX2"].ToString();
                // 20230915 JHLEE 

                txR_MIN.Text = R["R_MIN"].ToString();
                txR_MAX.Text = R["R_MAX"].ToString();

                cbMaker.Text = R["Maker"].ToString();     // 240116 JHLEE IEE, JOYSON
            }

            txTime.Text = cSetting.Set.Work_Time.ToString();
            ckPrintUSE.Checked = cSetting.Set.PrintUSE;
            ckLCR_USE.Checked = cSetting.Set.LCRUSE;

            ckDbCheck.Checked = cSetting.Set.DbCheck;
            tx_X.Text = cSetting.Set.X;
            tx_Y.Text = cSetting.Set.Y;

            txMIN_V.Text = cSetting.Set.MIN_V.ToString();

            txWord.Text = cSetting.Set.Word;
            ckWord_LOC.Checked = cSetting.Set.Word_Loc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //cSetting.Set.MIN = txMIN.Text.ToDouble();
            //cSetting.Set.MAX = txMAX.Text.ToDouble();

            //cSetting.Set.D_MIN = txD_MIN.Text.ToDouble();
            //cSetting.Set.D_MAX = txD_MAX.Text.ToDouble();

            //cSetting.Set.R_MIN = txR_MIN.Text.ToDouble();
            //cSetting.Set.R_MAX = txR_MAX.Text.ToDouble();
            //@CMD, @CarCode, @CP_MIN, @CP_MAX, @D_MIN, @D_MAX, @R_MIN, @R_MAX

            // 20230915 JHLEE
            //object[] data = { "INSERT", MAIN.SelCar, txMIN.Text, txMAX.Text, txD_MIN.Text, txD_MAX.Text, txR_MIN.Text, txR_MAX.Text };

            // 240116 JHLEE IEE, JOYSON 구분 필드
            object[] data = { "INSERT", MAIN.SelCar, txMIN.Text, txMAX.Text, txD_MIN.Text, txD_MAX.Text, txMIN2.Text, txMAX2.Text, txD_MIN2.Text, txD_MAX2.Text, txR_MIN.Text, txR_MAX.Text, cbMaker.SelectedItem.ToString() };
            //
            SQL.GetCar(data);

            cSetting.Set.Work_Time = txTime.Text.ToInt();
            cSetting.Set.PrintUSE = ckPrintUSE.Checked;
            cSetting.Set.LCRUSE = ckLCR_USE.Checked;

            cSetting.Set.X = tx_X.Text;
            cSetting.Set.Y = tx_Y.Text;
            cSetting.Set.DbCheck = ckDbCheck.Checked;
            cSetting.Set.MIN_V = txMIN_V.Text.ToInt();

            cSetting.Set.Word = txWord.Text;
            cSetting.Set.Word_Loc = ckWord_LOC.Checked;

            cSetting.Save();

            // 20230918 JHLEE
            MAIN.fmain.txScan.Focus();

            this.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BPrint.DoPrint("23062700001", "S56111DO100EMA", "MV1", "EMA HTD");
        }

        private void ckDbCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
