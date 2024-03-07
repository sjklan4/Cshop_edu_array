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


            DataTable insertSP = Db.RETRIEVE("up_mInspector_Pr", Db.PARAMS(new string[] { "@cMode", "@차종", "@ALC","@품번","@사양" }, 
                                                                        new object[] {"IN", CarnameVL, ALCVL, PartnumVL, SpecVL }));

            if (insertSP != null)
            {
                MessageBox.Show("입력 성공");
                inspectorDB();
            }
            else
            {
                MessageBox.Show("입력 실패");
                inspectorDB();
            }

        }

        private void Delbtn_Click(object sender, EventArgs e)
        {

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
