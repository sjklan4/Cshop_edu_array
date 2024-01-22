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
    public partial class fmHistory : Form
    {
        public fmHistory()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
#if (ENGLISH)
            gLabel2.Text = "SEARCH";
            label9.Text = "START DAY";
            label1.Text = "END DAY";
            btnSearch.Text = "SEARCH";
            button1.Text = "EXCEL";
#else
            gLabel2.Text = "조 회";
            label9.Text = "시작 날짜";
            label1.Text = "종료 날짜";
            btnSearch.Text = "조회";
            button1.Text = "엑셀 저장";
#endif
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;

        }

        private void brnEXIT_Click(object sender, EventArgs e)
        {
            // 20230918 JHLEE
            MAIN.fmain.txScan.Focus();

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.FpSpread SaveSheet = new FarPoint.Win.Spread.FpSpread();
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.CreatePrompt = false;
            ofd.OverwritePrompt = true;
            ofd.Filter = "Excel File (*.xls)|*.xls";
            ofd.FileName = $"{dtStart.Value.ToString("yyMMdd")}_InQuiry.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fpSpread1_Sheet1.SheetName = "전체 이력";
                SaveSheet.Sheets.Add(fpSpread1_Sheet1);
                SaveSheet.SaveExcel(ofd.FileName, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders | FarPoint.Excel.ExcelSaveFlags.SaveAsViewed);
            }
        }

        public void DataView()
        {
            //Serial, DateTime, Spec, CP_MIN, CP_MAX, D_MIN, D_MAX, Resistance, Judge
            string Start = dtStart.Value.ToString("yyyyMMdd");
            string END = dtEnd.Value.ToString("yyyyMMdd");
            var Data = SQL.GetSaveData(Start, END);
            cHelp.fpSpreadSet(fpSpread1, 9, new string[] { "LOTNO", "날짜", "사양", "CP_하한", "CP_상한", "D_하한", "D_상한", "CP_하한2", "CP_상한2", "D_하한2", "D_상한2","저항값", "결과" });
            fpSpread1_Sheet1.DataSource = Data;
            cHelp.GetPreferredWidth(fpSpread1, 9, 30, 120);
        }
    }
}
