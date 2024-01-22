using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOD_Inspect
{
    public partial class fmModelSel : Form
    {
        List<RadioButton> BtModels = new List<RadioButton>();
        List<RadioButton> BtCars = new List<RadioButton>();
        private int CurrPage = 1;
        private int MaxPage = 0;
        private int startPage = 1;
        private bool Flag = false;
        //private string SelCar = string.Empty;

        public fmModelSel()
        {
            InitializeComponent();
#if (ENGLISH)
            gLabel2.Text = "SELECT MODEL";
#else
            gLabel2.Text = "모델선택";
#endif


            // 생성된 20개의 라디오버튼에 CheckedChanged 이벤트 추가 및 List에 add
            for (int idx = 1; idx <= 20; idx++)
            {
                RadioButton b = gPanel3.Controls["btModel" + idx.ToString()] as RadioButton;
                b.CheckedChanged += B_CheckedChanged;
                BtModels.Add(b);
            }

            for (int i = 1; i <= 5; i++)
            {
                RadioButton C = gPanel3.Controls["tbCar" + i.ToString()] as RadioButton;
                C.CheckedChanged += BC_CheckedChanged;
                BtCars.Add(C);
            }
        }

        private void BC_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton b = sender as RadioButton;
            if (b.Checked)
            {
                if (Flag)
                {
                    Flag = false;
                    return;
                }
                MAIN.SelCar = b.Text;
                ButtonCaptionChange();
            }

        }

        private void B_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton b = sender as RadioButton;
            if(b.Checked)
            {
                if (Flag)
                {
                    Flag = false;
                    return;
                }

                // 선택한 모델의 정보를 저장
                var P = b.Text.Split('\n');
                string SelPartNo = P[0].Replace("[", "").Replace("]", "");
                cHelp.AnimateWindow(this.Handle, 300, cHelp.AW_CENTER | cHelp.AW_HIDE);
                MAIN.OnModelChange(MAIN.SelCar, SelPartNo);
                MAIN.ModelSelection = true;

                // 20230918 JHLEE
                MAIN.fmain.txScan.Focus();
                
                Close();
            }
            
        }
        /// <summary>
        /// 20개 버튼 내용 변경
        /// </summary>
        private void ButtonCaptionChange()
        {
            BtnClear();
            object[] data = { "SELECT", MAIN.SelCar, "", "" };
            DataTable dt = SQL.GetAllModel(data);//테이블 인덱스: [0]ModelNo, [1]PartNo, [2]PartName, [3]ALC, [4]Position, [5]DriveType, [6]CarType
            if (dt == null) return;
            if (dt.Rows.Count > 0)
            {
                var rowcount = dt.Rows.Count;
                var LastPage = rowcount % 20; //버튼의 갯수 만큼 나누어 마지막 페이지의 갯수를 가져옴. 나머지값이 마지막 페이지의 데이터 갯수임.
                var pagecount = rowcount / 20; //총 페이지 수를 저장
                if (LastPage > 0) pagecount += 1; //마지막 페이지의 데이터값이 존재하면 페이지수를 하나더 증가시킴.
                MaxPage = pagecount;
                lbPage.Text = startPage.ToString() + "/" + pagecount.ToString(); //버튼 페이지 표시
                var startPos = 1;
                if (startPage > 1) startPos = ((startPage - 1) * 20) + 1; //현재페이지 표시를 위하여 현재값을 기준으로 재정렬
                var count = 1;
                int btnCnt = 0;
                foreach (DataRow model in dt.Rows)
                {
                    if (startPos <= count && startPos + 20 > count)
                    {
                        BtModels[btnCnt].Text = $"[{model[0].ToString()}]\n({model[1].ToString()})";
                        BtModels[btnCnt].Enabled = true;
                        btnCnt++;
                    }
                    count++;
                }
            }
        }

        private void CarButtonCaptionChange()
        {
            BtnCarClear();

            // 20230915 JHLEE
            //object[] data = { "SELECT", "","","","","","",""};
            //object[] data = { "SELECT", "", "", "", "", "", "", "", "", "", "", "" };
            // 240116 JHLEE  Maker 필드 추가
            object[] data = { "SELECT", "", "", "", "", "", "", "", "", "", "", "", "" };

            //
            DataTable dt = SQL.GetCar(data);//테이블 인덱스: [0]ModelNo, [1]PartNo, [2]PartName, [3]ALC, [4]Position, [5]DriveType, [6]CarType
            if (dt == null) return;
            if (dt.Rows.Count > 0)
            {
                var rowcount = dt.Rows.Count;
                var LastPage = rowcount % 5; //버튼의 갯수 만큼 나누어 마지막 페이지의 갯수를 가져옴. 나머지값이 마지막 페이지의 데이터 갯수임.
                var pagecount = rowcount / 5; //총 페이지 수를 저장
                if (LastPage > 0) pagecount += 1; //마지막 페이지의 데이터값이 존재하면 페이지수를 하나더 증가시킴.
                MaxPage = pagecount;
                lbCar_page.Text = startPage.ToString() + "/" + pagecount.ToString(); //버튼 페이지 표시
                var startPos = 1;
                if (startPage > 1) startPos = ((startPage - 1) * 20) + 1; //현재페이지 표시를 위하여 현재값을 기준으로 재정렬
                var count = 1;
                int btnCnt = 0;
                foreach (DataRow model in dt.Rows)
                {
                    if (startPos <= count && startPos + 20 > count)
                    {
                        BtCars[btnCnt].Text = $"{model[0]}";
                        BtCars[btnCnt].Enabled = true;
                        btnCnt++;
                    }
                    count++;
                }
            }
        }
        /// <summary>
        /// 버튼 사용 불가 및 텍스트 초기화
        /// </summary>
        private void BtnClear()
        {
            foreach (var b in BtModels)
            {
                b.Enabled = false;
                b.Text = "-";
            }

        }

        private void BtnCarClear()
        {
            foreach (var b in BtCars)
            {
                b.Enabled = false;
                b.Text = "-";
            }

        }

        public Task End()
        {
            return Task.Delay(10);
        }
        protected override void OnShown(EventArgs e)
        {
            cHelp.AnimateWindow(this.Handle, 300, cHelp.AW_CENTER | cHelp.AW_ACTIVATE);
            base.OnShown(e);
            //ButtonCaptionChange();
            CarButtonCaptionChange();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cHelp.AnimateWindow(this.Handle, 300, cHelp.AW_CENTER | cHelp.AW_HIDE);
            //cHelp.SendMessage(MAIN.MainFormHandle, MAIN.WM_MODELCHANGE, 0, 0);
            //cHelp.SendMessage(MAIN.MainFormHandle, MAIN.WM_SERIAL_CHANGE, 0, 0);
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MaxPage > CurrPage) CurrPage++;
            startPage = CurrPage;
            ButtonCaptionChange();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            if (2 <= CurrPage) CurrPage--;
            startPage = CurrPage;
            ButtonCaptionChange();
        }

        /// <summary>
        /// 설정 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txFilter_TextChanged(object sender, EventArgs e)
        {
            ButtonCaptionChange();
        }

        private void btModel1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCar_Prev_Click(object sender, EventArgs e)
        {
            if (2 <= CurrPage) CurrPage--;
            startPage = CurrPage;
            CarButtonCaptionChange();
        }

        private void btnCar_Next_Click(object sender, EventArgs e)
        {
            if (MaxPage > CurrPage) CurrPage++;
            startPage = CurrPage;
            CarButtonCaptionChange();
        }

        private void btModel20_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
