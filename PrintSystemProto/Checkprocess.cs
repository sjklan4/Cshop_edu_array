using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PrintSystemProto
{
    public partial class Checkprocess : Form
    {
        public Checkprocess()
        {
            InitializeComponent();
            Db.DbConnectionCheck();
            inspectorDB();

        }

        public void inspectorDB()
        {
            DataTable table = Db.RETRIEVE($"SELECT * FROM mInspector"); //Db클래스에서 RETRIEVE 메서드를 불러와서 쿼리로 조회 시키는 구문
            if (table != null)
            {
                inspecterlist.DataSource = table;
            }
            else
            {
                MessageBox.Show("테이블 블러오기 오류");
            }
        }
        




        private void Checkprocess_Load(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            string CarnameVL = CarnameTX.Text.Trim();
            string ALCVL = ALCTX.Text.Trim();
            string PartnumVL = PartnumTX.Text.Trim();
            string SpecVL = SpecTX.Text.Trim();

            //DataTable을 반환받기 위해 Db.cs에 있는 클래스 메서드를 불러온다. RETRIEVE라는 메서드를 불러와서 프로시저명,파라미터로 insert하려는 값들을 정의
            //값들은 배열로 해서 전달해준다.
            DataTable insertSP = Db.RETRIEVE("up_mInspector_Pr", Db.PARAMS(new string[] { "@cMode", "@차종", "@ALC","@품번","@사양" }, 
                                                                        new object[] {"IN", CarnameVL, ALCVL, PartnumVL, SpecVL }));

            if (insertSP != null)
            {
                MessageBox.Show("입력 성공");
                inspectorDB(); //DB에 영향을 받고 바로 다시 조회를 하기 위해 추가 
            }
            else
            {
                MessageBox.Show("입력 실패");
                inspectorDB();
            }

        }


        private void Delbtn_Click(object sender, EventArgs e)
        {
            string ALCVL = ALCTX.Text.Trim();
            int inspectordataRW = inspecterlist.SelectedRows.Count;
            if (inspectordataRW > 0 )
            {
                DataTable DelSP = Db.RETRIEVE("up_mInspector_Pr", Db.PARAMS(new string[] { "@cMode", "@ALC" }, new object[] { "DEL", ALCVL }));
                inspectorDB();
            }
            else
            {
                MessageBox.Show("삭제할 데이터를 선택해주세요.");
            }
        }


        private void inspecterlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void inspecterlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (inspecterlist.Rows[e.RowIndex].Cells[1].Value != null)
            {

                CarnameTX.Text = inspecterlist.Rows[e.RowIndex].Cells[1].Value.ToString();
                ALCTX.Text = inspecterlist.Rows[e.RowIndex].Cells[2].Value.ToString();
                PartnumTX.Text = inspecterlist.Rows[e.RowIndex].Cells[3].Value.ToString();
                SpecTX.Text = inspecterlist.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }









    }
}
