﻿using System;
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

        public void MSLoadData2() //MSsql 연결 부분  = select를 통한 dbdata불러오기 - 부품 데이터 불러오는 부분
        {
            mssqlconn.Open();
            SqlDataAdapter msdata2 = new SqlDataAdapter("SELECT * FROM partchtable", mssqlconn); //where조건 삭제했음 - 확인필요******
            DataTable mstable2 = new DataTable(); //data를 table형식으로 불러 오도록 하는 구문 datatable class사용시 table형식으로 불러짐
            msdata2.Fill(mstable2); 
            Partch_Table.DataSource = mstable2;
            mssqlconn.Close();
        }

        public void ProcessData()
        {
            mssqlconn.Open();
            SqlDataAdapter processdb = new SqlDataAdapter("SELECT * FROM processtable",mssqlconn);
            DataTable prtable = new DataTable();
            processdb.Fill(prtable);
            Process_Chk.DataSource = processdb;
            mssqlconn.Close();    
        }

        //이 부분은 현재 있는 그리드 들이 어떻게 보여 주는지를 입력해주는 부분
        public ModelINFT() 
        {

            InitializeComponent();
            chkbox();

            mssqlconn = new SqlConnection(connstr);
            MSLoadData2();
            ProcessData(); //공정 합 db를 불러오기위해서 별도 load 중복 함수로 되어 있어서 추후 수정 필!
            
   
        }

        public void chkbox()
        {
            //체크 박스 추가
            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Sel.",
                Name = "Select",
                Width = 50
            };
            Partch_Table.Columns.Insert(0, Select);//체크박스 추가 

            Partch_Table.CellContentClick += dataGridView1_CellContentClick; //체크박스 클릭시 그리드박스안 데이터를 클릭하도록 동작을 주는 구문

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
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                Partch_Table = new DataGridView();
                bool ischked = (bool)Partch_Table.Rows[e.RowIndex].Cells["Select"].Value; // chkbox셀의 값을 가져오는 구문 
                //체크시 해당 행에 있는 모든 데이터들(해당하는 컬럼)을 ischked와 같은 상태로 바꾸기 위한 구문
                for (int i = 0; i < Partch_Table.Columns.Count; i++)
                {
                    Partch_Table.Rows[e.RowIndex].Cells[i].Value = ischked;
                }
                if (ischked)
                {
                    decimal ALCvl = Convert.ToDecimal(Partch_Table.Rows[e.RowIndex].Cells["ALC"].Value);
                    string partchname = Partch_Table.Rows[e.RowIndex].Cells["부품명"].Value.ToString();
                    string partchnum = Partch_Table.Rows[e.RowIndex].Cells["부품번호"].Value.ToString();
                    string color = Partch_Table.Rows[e.RowIndex].Cells["색상"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("부품을 선택해주세요");
                }
            }
                    

        }

        private void registbtn_Click(object sender, EventArgs e)
        {
            //var model = comboBox1.SelectedItem.ToString().Trim();
            string ALCVL = textBox1.Text.Trim(); // autoincrement없을 경우 사용 
            string partnameVL = Part_Name.Text.Trim();
            string partnumVL = Part_Num.Text.Trim();
            string partcolorVL = Part_Color.Text.Trim();

                try
                {
                    mssqlconn.Open();
                   // string InsertQry = "INSERT INTO partchtable(부품명,부품번호,색상) VALUES('" + partnameVL + "', '" + partnumVL + "','" + partcolorVL +"'); select scope_identity()"; // 자동 증가열 값을 가져오는 함수 scope_identity 이다.
                    string InsertQry = "INSERT INTO partchtable(ALC,부품명,부품번호,색상) VALUES('" + ALCVL + "','" + partnameVL + "', '" + partnumVL + "','" + partcolorVL + "')"; //자동 증가열 없는 경우 사용 구문 


                    SqlCommand cmd = new SqlCommand(InsertQry, mssqlconn);
                    DataRow newRow = ((DataTable)Partch_Table.DataSource).NewRow(); //그리드의 data행에 datatable값이 있는 db의 테이블 전체를 가져와서 신규 행에 넣도록 인스턴스
                    /*decimal gnALC = Convert.ToDecimal(cmd.ExecuteScalar()); // cope_identity를 사용하기 위해 excutescalar라는 내장함수를 가지고 영향을 받은 1행 1열을 반환시킨다. ALC가 table첫행에 잇음
                    int generatedALC = (int)gnALC;*/

                    newRow["ALC"] = ALCVL;
                    newRow["부품명"] = partnameVL;
                    newRow["부품번호"] = partnumVL;
                    newRow["색상"] = partcolorVL;
                    ((DataTable)Partch_Table.DataSource).Rows.Add(newRow);


                
                if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추가 성공");
                        mssqlconn.Close();
                    }
                    else
                    {
                        MessageBox.Show("추가 실패 - ALC중복값 또는 데이터 형식을 확인해주세요");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Part_Name_TextChanged(object sender, EventArgs e)
        {

        }

        // - ---- - - - - - - - - -- - - - - - - - -- 


        private void Process_Chk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Partch_RegistBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
