using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Google.Protobuf;

namespace PrintSystemProto
{
    using static MAIN;
    public partial class Form1 : Form
    {
        public static string uid = "sa";  //mssql 접속에 필요한 정보구문 
        public static string pws = "x";
        public static string database = "printsystem";
        public static string server = "Localhost";   // 편집 확인 필요~~~
        public string connstr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + pws + ";";
        public SqlConnection mssqlconn;



        // private const string ConnectionString = "Server=127.0.0.1;Database=printsystemproto;Uid=root;Pwd=qjabek46;"; //maria db연결
        // private MySqlConnection sqlConn; // maria db 연결 부분
        // 아래는 윈폼의 귀동 현황 데이터를 보여주는 관련 구문
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    Console.WriteLine($"{m.Msg}");
        //}

        public Form1()
        {
            InitializeComponent();
            //mssql부분
            mssqlconn = new SqlConnection(connstr);
            MSLoadData();


            //mariadb전용 구문
            /*          sqlConn = new MySqlConnection(ConnectionString);
                      LoadData();*/
        }


        public void MSLoadData() //MSsql 연결 부분  = select를 통한 dbdata불러오기
        {
            mssqlconn.Open();
         /*   SqlDataAdapter msdata = new SqlDataAdapter("SELECT * FROM printsystemtable", mssqlconn); //where조건 삭제했음 - 확인필요******
            DataTable mstable = new DataTable();
            msdata.Fill(mstable);*/

            SqlDataAdapter prcData = new SqlDataAdapter("select_print",mssqlconn); // 프로시저에 select가 있으면 command가 안되서 dataAdpater를 사용한 구조로 단순 처리 가능
            DataTable mstable = new DataTable(); // 데이터 테이블 인스턴스
            prcData.Fill(mstable);  // 프로시저로 부터 받은 데이터로 받는다.
            dataGridView1.DataSource = mstable;

            mssqlconn.Close();
            

        }

        public DataTable Instancedatabse() // modelinf로 db데이터 전달을 위한 구문 - 반복구문 수정 필요
        {
            mssqlconn.Open();
            SqlDataAdapter msdata = new SqlDataAdapter("SELECT * FROM printsystemtable", mssqlconn);
            DataTable mstable = new DataTable();
            msdata.Fill(mstable);
            mssqlconn.Close();
            return mstable;

        }


        /*     private void LoadData() // mariadb 에 있는 데이터를 가져와서 load시키기 위한 함수구문
             {
                 sqlConnection.Open();
                 MySqlDataAdapter dbdata = new MySqlDataAdapter("SELECT * FROM printsystemproto", sqlConnection);
                 DataTable dataTable = new DataTable();
                 dbdata.Fill(dataTable);
                 dataGridView1.DataSource = dataTable;
                 sqlConnection.Close();
             }*/

        public void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[0].Name = "모델";
            //dataGridView1.Columns[1].Name = "모델명";
            ////LoadData(); - maria db
            //MSLoadData(); 
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private bool DupleValuechk(string val, int column)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[column].Value != null && row.Cells[column].Value.ToString().Trim().Equals(val, StringComparison.OrdinalIgnoreCase)) //개체의 값이 같은지 비교하기위함 Equals라는 매서드사용
                {
                    return true; // 중복된 값이 있음
                }
            }
            return false; // 중복된 값이 없음
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            string modelValue = modelbox.Text.Trim();
            string modelNameValue = modelNamebox.Text.Trim();
            if (modelValue == "")
            {
                Insert_result.Text = "Model을 입력해주세요";
                Insert_result.ForeColor = Color.Red;
            }
            else if (modelNameValue == "")
            {
                Insert_result.Text = "Modelname을 입력해주세요";
                Insert_result.ForeColor = Color.Red;
            }
            else
            {

                if (DupleValuechk(modelValue, 0) || DupleValuechk(modelNameValue, 1)) // =modelbox, 0번 cell  (변수,컬럼번호를 argument로 전달) - DUP위 구문에서 true이면 중복값, 아니면 아래 신규값추가
                {
                    Insert_result.Text = "중복된 값이 있습니다.";
                    Insert_result.ForeColor = Color.Red;
                }
                else
                {


                    try
                    {
                        mssqlconn.Open();
                   /*     string InsertQry = "INSERT INTO printsystemtable(model,modelname) VALUES('" + modelValue + "', '" + modelNameValue + "')";

                        SqlCommand cmd = new SqlCommand(InsertQry, mssqlconn);*/

                        SqlCommand cmd = new SqlCommand("Insert_model", mssqlconn);
                        cmd.CommandType = CommandType.StoredProcedure;  // 명령 형식을 지정해주어야 함. 안하면 Pram이 안들어감.
                        cmd.Parameters.AddWithValue("@modelValue",modelValue);
                        cmd.Parameters.AddWithValue("@modelNameValue", modelNameValue);
                        DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();
                        newRow["model"] = modelValue;
                        newRow["modelname"] = modelNameValue;
                        ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Insert_result.Text = "인서트 성공";   
                            Insert_result.ForeColor = Color.Blue;
                            mssqlconn.Close();
                        }
                        else
                        {
                            Insert_result.Text = "인서트 실패";
                            Insert_result.ForeColor = Color.Red;
                            mssqlconn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
            }
        }
  

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    if (dataGridView1.Rows.Count > currentindex)
        //    {
        //        dataGridView1.Rows[currentindex].Cells[1].Value = modelbox.Text;
        //        currentindex++;
        //    }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void modelbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void modelNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //data선택시 text박스에 선택값 보여주두록 하는것
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modelbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                modelNamebox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
           
        }

        private void modelinf_Click(object sender, EventArgs e) // modelinfo안에 콤보박스 연동시켜주는 구문
        {
            if (!fmModel.IsDisposed)
            {
                fmModel.Show();
                fmModel.comboBox1.Items.Clear();

                var indata = Instancedatabse();
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    fmModel.comboBox1.Items.Add($"{indata.Rows[i]["model"]} - { indata.Rows[i]["modelname"] }"); //2개 컬럼을 한번에 가져오기 위한 구조변경
                }

                //ModelINFT modelINFT = new ModelINFT();
                //modelINFT.Show();
            }
        }

        private void DelBTN_Click(object sender, EventArgs e)
        {
            int datrow = dataGridView1.SelectedRows.Count;
            int delrow = dataGridView1.CurrentCell.RowIndex; // 활성화된 셀의 위치를 가져옴 - 번호로
            string modelValue = modelbox.Text.Trim();
            string modelNameValue = modelNamebox.Text.Trim();
            if (datrow > 0)
            {
                try
                {
                    mssqlconn.Open();

                    string DelQry = "DELETE FROM printsystemtable WHERE model = '" + modelValue + "' OR modelname = '" + modelNameValue + "'";


                    SqlCommand cmd = new SqlCommand(DelQry, mssqlconn);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Insert_result.Text = "삭제 성공";
                        dataGridView1.Rows.Remove(dataGridView1.Rows[delrow]); // 가져온 번호에 해당하는 열을 지움 지금 data는 전체 행 선택으로 설정 되어있음
                        mssqlconn.Close();
                    }
                    else
                    {
                        Insert_result.Text = "삭제 실패";
                        mssqlconn.Close();
                    }
                }
                catch (SqlException)
                {
                    Insert_result.Text = "삭제 불가\n (해당 Model의 공정을 확인해주세요)";

                }

                catch (Exception)
                {
                    Insert_result.Text = "삭제 불가\n(해당 Model의 공정을 확인해주세요)";
                    
                }
                finally { mssqlconn.Close(); }
            
            }
            else
            {
                Insert_result.Text = "삭제 데이터를 선택하세요";
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void Insert_result_Click(object sender, EventArgs e)
        {

        }
    }
}
