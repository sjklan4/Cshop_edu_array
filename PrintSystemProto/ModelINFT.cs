using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrintSystemProto
{
    


    public partial class ModelINFT : Form
    {
        public static string uid = "sa";  //mssql 접속에 필요한 정보구문 
        public static string pws = "x";
        public static string database = "printsystem";
        public static string server = "Localhost";   // 편집 확인 필요~~~
        public string connstr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + pws + ";";
        public SqlConnection mssqlconn;
       

        //private DataTable GetDataForm1()
        //{
        //    return formInstance.Instancedatabse();
        //}
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add(GetDataForm1());

        }
        public void MSLoadData2() //MSsql 연결 부분  = select를 통한 dbdata불러오기
        {
            mssqlconn.Open();
            SqlDataAdapter msdata2 = new SqlDataAdapter("SELECT * FROM partchtable", mssqlconn); //where조건 삭제했음 - 확인필요******
            DataTable mstable2 = new DataTable(); //data를 table형식으로 불러 오도록 하는 구문 datatable class사용시 table형식으로 불러짐
            msdata2.Fill(mstable2); 
            Partch_Table.DataSource = mstable2;

            mssqlconn.Close();


        }

        public ModelINFT()
        {
            InitializeComponent();
            mssqlconn = new SqlConnection(connstr);
            MSLoadData2();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }


        private void ModelINFT_Load(object sender, EventArgs e)
        {
         /*   Partch_Table.Columns[0].Name = "model";
            Partch_Table.Columns[1].Name = "부품명";
            Partch_Table.Columns[2].Name = "부품번호";
            Partch_Table.Columns[3].Name = "부품색상";*/
            MSLoadData2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Part_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void registbtn_Click(object sender, EventArgs e)
        {
            //var model = comboBox1.SelectedItem.ToString().Trim();
            string partnameVL = Part_Name.Text.Trim();
            string partnumVL = Part_Num.Text.Trim();
            string partcolorVL = Part_Color.Text.Trim();

        
           DataRow newRow = ((DataTable)Partch_Table.DataSource).NewRow();
                //newRow["model"] = model;
                newRow["부품명"] = partnameVL;
                newRow["부품번호"] = partnumVL;
                newRow["색상"] = partcolorVL;
                ((DataTable)Partch_Table.DataSource).Rows.Add(newRow);
    
                try
                {
                    mssqlconn.Open();
                    string InsertQry = "INSERT INTO partchtable(부품명,부품번호,색상) VALUES('" + partnameVL + "', '" + partnumVL + "','" + partcolorVL +"')";

                    SqlCommand cmd = new SqlCommand(InsertQry, mssqlconn);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추가 성공");
                        mssqlconn.Close();
                    }
                    else
                    {
                        MessageBox.Show("추가 실패");
                        mssqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

            }

        private void button4_Click(object sender, EventArgs e)
        {
  
        }

        // - ---- - - - - - - - - -- - - - - - - - -- 


        private void Process_Chk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
