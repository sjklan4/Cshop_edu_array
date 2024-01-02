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

        //process그리드에 넣기 위해 전역 변수 사용 - 매개 변수 로직과 비교 필요......

        private List<Tuple<string, string, string, string>> selectedPDataList = new List<Tuple<string, string, string, string>>();
        private bool cellValueChangedHandled = false;
        /*private string gbALCvalue;
        private string gbPartname;
        private string gbPartnum;
        private string gbColor;*/

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
            Process_table.DataSource = prtable;
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
            Partch_Table.CellValueChanged += Partch_Table_CellContentClick;
        }

        // 입력된 부품 내용들에 대한 조합을 위한 선택을 하는 구문 - 부품 선택 테이블 
        public void Partch_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cellValueChangedHandled)
            {
                return;
            }

            if (e.ColumnIndex == Partch_Table.Columns["Select"].Index && e.RowIndex >= 0) // 체크박스가 있는 컬럼의 위치에서 변동이 생기는 행이 있으면 이라는 것으로 시작
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)Partch_Table.Rows[e.RowIndex].Cells["Select"]; // 체크박스 클래스를 patch테이블의 해당 컬럼의 row값을 넣어주는 구문
                bool isChecked = (bool)checkbox.EditedFormattedValue; //bool형식으로 변환해서 결과 값 반환

                if (isChecked)
                {

                    DataRowView selectRow = (DataRowView)Partch_Table.Rows[e.RowIndex].DataBoundItem;
                    DataRow selectrowdata = selectRow.Row;
/*
                
                    gbALCvalue = selectrowdata["ALC"].ToString();
                    gbPartname = selectrowdata["부품명"].ToString();
                    gbPartnum = selectrowdata["부품번호"].ToString();
                    gbColor = selectrowdata["색상"].ToString();*/

                    string ALC = selectrowdata["ALC"].ToString();
                    string partName = selectrowdata["부품명"].ToString();
                    string partNum = selectrowdata["부품번호"].ToString();
                    string color = selectrowdata["색상"].ToString();

                   selectedPDataList.Add(new Tuple<string, string, string, string>(ALC, partName, partNum, color));
                   

                }
                else
                {
                    //해제 기능 테스트필요 필!!!
                    //체크 해제시 담긴데이터들을 삭제 시키기 위함. - 삭제 안시키면 select리스트 데이터에 그대로 남아서 추후 insert시 체크가 풀린 데이터까지 다 들어감.
                    DataRowView selectRow = (DataRowView)Partch_Table.Rows[e.RowIndex].DataBoundItem;
                    DataRow selectrowdata = selectRow.Row;

                    string ALC = selectrowdata["ALC"].ToString();
                    string partName = selectrowdata["부품명"].ToString();
                    string partNum = selectrowdata["부품번호"].ToString();
                    string color = selectrowdata["색상"].ToString();

                    selectedPDataList.RemoveAll(item => item.Item1 == ALC &&
                                                      item.Item2 == partName &&
                                                      item.Item3 == partNum &&
                                                      item.Item4 == color);
                }
                cellValueChangedHandled = true;
                Partch_Table.EndEdit();
                cellValueChangedHandled = false;
            }
        }

        private void Partch_RegistBtn_Click(object sender, EventArgs e)
        {
            
            //if (!string.IsNullOrEmpty(gbALCvalue))
            if(selectedPDataList.Count > 0)
            {
                //int RowIndex = Partch_Table.SelectedRows[0].Index; // 파츠 테이블의 선택한 행 번호 를 가져온다.

                // string chkvalue = Partch_Table.Rows[RowIndex].Cells["Select"].Value.ToString(); // 행번호 와 컬럼위치를 지정해서 문자형식으로 담아줌 -  파츠테이블의 컬럼위치에 있는 해당행 전체 


                //DataGridViewRow selectedRow = new DataGridViewRow();


                string selectcombo = comboBox1.SelectedItem?.ToString(); //콤보박스 내용 가져오기
                
                if (string.IsNullOrEmpty(selectcombo)) // 유효성? 검사 부분 - 콤보 선택 안하면 경고 띄우기
                {
                    MessageBox.Show("모델과 모델이름을 선택해주세요");
                    return;
                }

                else
                {
                    try
                    {
                        mssqlconn.Open();


                        foreach (var selectedPData in selectedPDataList)
                        {
                            string[] comboPartdata = selectcombo.Split('-'); //지금 콤보 박스 내용에 2개 컬럼 데이터가 오기 때문에 '-'를 기점으로 나누어 줌

                            string model = comboPartdata[0].Trim(); //model 컬럼 내용
                            string modelname = comboPartdata[1].Trim(); // modelname 컬럼 내용
                            string ALCvalue = selectedPData.Item1;
                            string Partname = selectedPData.Item2;
                            string Partnum = selectedPData.Item3;
                            string Color = selectedPData.Item4;

                            string InsertQry2 = "INSERT INTO processtable(model, modelname, ALC, 부품명, 부품번호, 색상)"
                                                    + "VALUES('" + model + "','" + modelname + "','" + ALCvalue + "','" + Partname + "', '" + Partnum + "','" + Color + "')";
                            SqlCommand processcmd = new SqlCommand(InsertQry2, mssqlconn);
                            DataRow newRow = ((DataTable)Process_table.DataSource).NewRow();

                            newRow["model"] = model;
                            newRow["modelname"] = modelname;
                            newRow["ALC"] = ALCvalue;
                            newRow["부품명"] = Partname;
                            newRow["부품번호"] = Partnum;
                            newRow["색상"] = Color;
                            ((DataTable)Process_table.DataSource).Rows.Add(newRow);

                            if (processcmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("공정 추가");
                           
                            }
                            else
                            {
                                MessageBox.Show("공정추가 실패 - 중복값 또는 공정을 확인해주세요");

                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                    finally 
                    {
                        mssqlconn.Close();
                    }


                }
            }
            else
            {
                MessageBox.Show("부품을 선택해주세요");
            }
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

        // 공정 삭제 버튼 
        private void button5_Click(object sender, EventArgs e)
        {
            int selectRowdata = Process_table.SelectedRows.Count;
            int delProcess = Process_table.CurrentCell.RowIndex;
            string model = Process_table.Rows[delProcess].Cells["model"].Value.ToString();
            /*string modelname = Process_table.SelectedRows[selectRowdata].Cells["modelname"].ToString();
            string ALC = Process_table.SelectedRows[selectRowdata].Cells["ALC"].ToString();
            string Partname = Process_table.SelectedRows[selectRowdata].Cells["부품명"].ToString();
            string PartNum = Process_table.SelectedRows[selectRowdata].Cells["부품번호"].ToString();
            string Color = Process_table.SelectedRows[selectRowdata].Cells["색상"].ToString();*/

            if (selectRowdata > 0)
            {
                try
                {
                    mssqlconn.Open();
                    string Process_DelQry = "DELETE FROM processtable WHERE model = '" + model + "'";

                    SqlCommand Process_delcmd = new SqlCommand(Process_DelQry, mssqlconn);
                    int resultrow = Process_delcmd.ExecuteNonQuery(); //여러 행이 묶여서 삭제 될 수도 있어서 영향 받는 행을 별도로 추출

                    if (resultrow > 0)
                    {
                        Process_table.Rows.Remove(Process_table.Rows[delProcess]);
                        MessageBox.Show("공정이 삭제 되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("실패! : 공정을 다시 확인해주세요");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("오류가 발생하였습니다. 담당자에게 문의해주세요");
                    throw;
                }
                finally
                {
                    mssqlconn.Close();
                }
            }
            else
            {
                MessageBox.Show("삭제할 공정을 선택해주세요");
            }
        }

        // 부품 삭제 버튼
        private void Partch_Delbtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
