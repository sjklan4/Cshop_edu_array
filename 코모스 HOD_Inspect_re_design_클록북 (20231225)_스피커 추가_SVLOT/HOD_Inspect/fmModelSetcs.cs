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
    public partial class fmModelSetcs : Form
    {
        public fmModelSetcs()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
#if (ENGLISH)
            gLabel2.Text = "SELECT MODEL";
            label1.Text = "CAR";
            label2.Text = "CAR";
            label3.Text = "MODEL NO";
            label4.Text = "SEPC";
            label5.Text = "MODEL";
            btn_Car_ADD.Text = "ADD";
            btn_Car_DEL.Text = "DEL";
            btn_Model_ADD.Text = "ADD";
            btn_Model_DEL.Text = "DEL";
#else
            gLabel2.Text = "모델선택";
            label1.Text = "차종항목";
            label2.Text = "차종";
            label3.Text = "품번";
            label4.Text = "사양";
            label5.Text = "모델항목";
            btn_Car_ADD.Text = "추가";
            btn_Car_DEL.Text = "삭제";
            btn_Model_ADD.Text = "추가";
            btn_Model_DEL.Text = "삭제";
#endif
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;
            fpCarSet();
        }

        private void brnEXIT_Click(object sender, EventArgs e)
        {
            // 20230918 JHLEE
            MAIN.fmain.txScan.Focus();

            this.Close();
        }

        private void btn_Car_ADD_Click(object sender, EventArgs e)
        {
            if (txCar.Text == "") return;
            //@CMD, @CarCode, @CP_MIN, @CP_MAX, @D_MIN, @D_MAX, @R_MIN, @R_MAX

            // 20230915 JHLEE
            //object[] data = { "INSERT", txCar.Text, "", "", "", "", "", "" };
            object[] data = { "INSERT", txCar.Text, "", "", "", "", "", "", "", "", "", "","" };
            //

            SQL.GetCar(data);
            fpCarSet();
        }

        private void btn_Car_DEL_Click(object sender, EventArgs e)
        {
            if (txCar.Text == "") return;

            // 20230915 JHLEE 
            //object[] data = { "DELETE", txCar.Text, "", "", "", "", "", "" };
            object[] data = { "DELETE", txCar.Text, "", "", "", "", "", "", "", "", "", "","" };
            //

            SQL.GetCar(data);
            fpCarSet();
        }

        private void btn_Model_ADD_Click(object sender, EventArgs e)
        {
            if (txCar.Text == "") return;
            if (txPartNo.Text == "") return;
            object[] data = { "INSERT", txCar.Text, txPartNo.Text, txSpec.Text };
            SQL.GetAllModel(data);
            fpModelSet();
        }

        private void btn_Model_DEL_Click(object sender, EventArgs e)
        {
            if (txCar.Text == "") return;
            if (txPartNo.Text == "") return;
            object[] data = { "DELETE", txCar.Text, txPartNo.Text, txSpec.Text };
            SQL.GetAllModel(data);
            fpModelSet();
        }

        public void fpCarSet()
        {
            // 20230915 JHLEE
            //object[] data = { "SELECT", "", "", "", "", "", "", "" };
            object[] data = { "SELECT", "", "", "", "", "", "", "", "", "", "", "","" };
            //

            var Data = SQL.GetCar(data);
            cHelp.fpSpreadSet(fpCar, 1, new string[] { "차종" });
            fpCar_Sheet1.DataSource = Data;
            cHelp.GetPreferredWidth(fpCar, 1, 30, 120);
        }

        public void fpModelSet()
        {
            object[] data = { "SELECT", txCar.Text, "", "" };
            var Data = SQL.GetAllModel(data);
            cHelp.fpSpreadSet(fpModels, 2, new string[] { "품번", "사양" });
            fpModels_Sheet1.DataSource = Data;
            cHelp.GetPreferredWidth(fpModels, 2, 30, 120);
        }

        private void fpCar_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            if (fpCar.ActiveSheet.Rows.Count <= 0) return;
            txCar.Text = fpCar.ActiveSheet.Cells[e.Range.Row, 0].Text;
            fpModelSet();
        }

        private void fpModels_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            if (fpModels.ActiveSheet.Rows.Count <= 0) return;
            txPartNo.Text = fpModels.ActiveSheet.Cells[e.Range.Row, 0].Text;
            txSpec.Text = fpModels.ActiveSheet.Cells[e.Range.Row, 1].Text;
        }

        private void txCar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
