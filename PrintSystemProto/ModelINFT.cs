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

        private List<Tuple<string, string, string, string>> selectedPDataList = new List<Tuple<string, string, string, string>>(); //선택한 여러 부품데이터를 한번에 넣기 위해서 tuple 한번에 받아온다.
        private bool cellValueChangedHandled = false; // 2번 반복되는 것을 막기위해서 메서드가 여러번 호출되는 것을 막기 위해 bool린 함수를 선언 false로 설정 
       
        
        
        
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
           // SqlDataAdapter msdata2 = new SqlDataAdapter("select_partch", mssqlconn); // 저장 프로시저 사용시 
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

        // select를 하기위한 열과 단순 선택 박스 기능만 추가하는 구문
        public void chkbox()
        {
            //체크 박스 추가
            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Sel.",
                Name = "Select",
                Width = 50
            };
            Partch_Table.Columns.Insert(0, Select);//체크박스 추가 - 0번째 컬럼에 select 기능을 추가
            Partch_Table.CellValueChanged += Partch_Table_CellContentClick;
        }

        // 입력된 부품 내용들에 대한 조합을 위한 선택을 하는 구문 - 부품 선택 테이블 
        public void Partch_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cellValueChangedHandled) // 전역으로 선언한 cellvalue가 true상태 일때는 리턴 시켜서 Partch_table 매서드를 종료 시켜준다. false상태 즉 구동하지 않은 상태면 아래를 한번 구동시켜서 최종적으로 1번 움직이면 종료 - true상태이기때문에
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
                
                cellValueChangedHandled = true; //위에서 false상태에서 구동후 true로 만들고
                Partch_Table.EndEdit();         // 작업한 것을 커밋후 종료 - 더이상 메서드안에 함수가 동작하지 않도록 멈춤
                cellValueChangedHandled = false; // 다시 다음 작업을 위해 false상태로 바꿔준다.
            }
        }

        // 공정 추가 버튼
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
                    Process_result.Text = "모델과 모델이름을 선택해주세요";
                    Process_result.ForeColor = Color.Red;

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

                            //DataRow newRow = ((DataTable)Process_table.DataSource).NewRow();

                            /*   newRow["model"] = model;
                               newRow["modelname"] = modelname;
                               newRow["ALC"] = ALCvalue;
                               newRow["부품명"] = Partname;
                               newRow["부품번호"] = Partnum;
                               newRow["색상"] = Color;*/
                            //((DataTable)Process_table.DataSource).Rows.Add(newRow);

                            if (processcmd.ExecuteNonQuery() == 1)
                            {
                                mssqlconn.Close();
                                ProcessData(); // 이부분안에 connection 열림 닫힘이 있음로 동작 순서상 전체 열고->닫고->process에서 열고->process에서 닫고 -> 전체 열어야 다음 foreach 조건 동작
                                mssqlconn.Open();
                                Process_result.Text = "공정 추가";
                                Process_result.ForeColor = System.Drawing.Color.Blue;

                            }
                            else
                            {
                                Process_result.Text = "공정추가 실패 - 중복값 또는 공정을 확인해주세요";
                                Process_result.ForeColor = System.Drawing.Color.Red;
                            }

                        }
                    }
                    catch (SqlException)
                    {
                        Partch_result.Text = "공정추가 실패 - 중복값 또는 공정을 확인해주세요";
                        Process_result.ForeColor = System.Drawing.Color.Red;
                    }
                    catch (Exception ex)
                    {

                        Process_result.Text = "공정 추가 실패 관리자에게 문의하세요";
                        Process_result.ForeColor = System.Drawing.Color.Red;

                    }
                    finally 
                    {
                        mssqlconn.Close();
                    }


                }
            }
            else
            {
                Process_result.Text = "부품 또는 모델을 선택해주세요";
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
            ProcessData();
        }

        // 부품 추가
        private void registbtn_Click(object sender, EventArgs e)
        {

            //var model = comboBox1.SelectedItem.ToString().Trim();
            string ALCVL = textBox1.Text.Trim(); // autoincrement없을 경우 사용 
            string partnameVL = Part_Name.Text.Trim();
            string partnumVL = Part_Num.Text.Trim();
            string partcolorVL = Part_Color.Text.Trim();
            if (ALCVL == "")
            {
                Partch_result.Text = "ALC를 입력하세요";
            }
            else if (partnameVL == "")
            {
                Partch_result.Text = "부품 이름을 입력하세요";
            }
            else if (partnumVL == "")
            {
                Partch_result.Text = "부품 번호을 입력하세요";
            }
            else if (partcolorVL == "")
            {
                Partch_result.Text = "색상을 입력하세요";
            }
            else
            { 
                try
                    {
                        mssqlconn.Open();
                       // string InsertQry = "INSERT INTO partchtable(부품명,부품번호,색상) VALUES('" + partnameVL + "', '" + partnumVL + "','" + partcolorVL +"'); select scope_identity()"; // 자동 증가열 값을 가져오는 함수 scope_identity 이다.
                        string InsertQry = "INSERT INTO partchtable(ALC,부품명,부품번호,색상) VALUES('" + ALCVL + "','" + partnameVL + "', '" + partnumVL + "','" + partcolorVL + "')"; //자동 증가열 없는 경우 사용 구문 


                        SqlCommand cmd = new SqlCommand(InsertQry, mssqlconn);
                        DataRow newRow = ((DataTable)Partch_Table.DataSource).NewRow(); //그리드의 data행에 datatable값이 있는 db의 테이블 전체를 가져와서 신규 행에 넣도록 인스턴스
                        /*decimal gnALC = Convert.ToDecimal(cmd.ExecuteScalar()); // cope_identity를 사용하기 위해 excutescalar라는 내장함수를 가지고 영향을 받은 1행 1열을 반환시킨다. ALC가 table첫행에 잇음
                        int generatedALC = (int)gnALC;*/
               
                    if (cmd.ExecuteNonQuery() == 1)
                        {
                        /*newRow["ALC"] = ALCVL;
                        newRow["부품명"] = partnameVL;
                        newRow["부품번호"] = partnumVL;
                        newRow["색상"] = partcolorVL;
                        ((DataTable)Partch_Table.DataSource).Rows.Add(newRow);*/
                            mssqlconn.Close();
                            MSLoadData2();
                            mssqlconn.Open();
                            Partch_result.Text = "부품이 추가 되었습니다.";
                            Partch_result.ForeColor = Color.Blue;
                    
                        }
                  
                    }
                    catch (SqlException)
                    {
                        Partch_result.Text = "추가 실패 - ALC중복값 또는 데이터 형식을 확인해주세요";
                    Partch_result.ForeColor = Color.Red;

                }
                    catch (Exception)
                    {
                        Partch_result.Text = "추가 실패 : 관리자에게 문의하세요";
                        Partch_result.ForeColor = Color.Red;

                     }
                    finally
                    {
                        mssqlconn.Close();
                    }
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
            int selectRowdata = Process_table.SelectedRows.Count;  // 선택된 행의 숫자를 가져옴 
            int delProcess = Process_table.CurrentCell.RowIndex;   // 활성화된 행의 번호를 가져옴 - 몇번째 행 지울지 결정하기 위함
            string ALCvalue = Process_table.Rows[delProcess].Cells["ALC"].Value.ToString(); 
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
                    string Process_DelQry = "DELETE FROM processtable WHERE ALC = '" + ALCvalue + "'";

                    SqlCommand Process_delcmd = new SqlCommand(Process_DelQry, mssqlconn);
                    int resultrow = Process_delcmd.ExecuteNonQuery(); //여러 행이 묶여서 삭제 될 수도 있어서 영향 받는 행을 별도로 추출

                    if (resultrow > 0)
                    {
                        mssqlconn.Close();
                        ProcessData();
                        //Process_table.Rows.Remove(Process_table.Rows[delProcess]);
                        Process_result.Text = "(해당 모델의)부품이 삭제 되었습니다.";
                        Process_result.ForeColor = Color.Green;
                    }
                    else
                    {
                        Process_result.Text = "실패! : 공정을 다시 확인해주세요";
                        Process_result.ForeColor = Color.Red;
                        mssqlconn.Close();
                    }
                }
                catch (Exception)
                {
                    Process_result.Text = "오류가 발생하였습니다. 담당자에게 문의해주세요";
                    Process_result.ForeColor = Color.Red;
                    mssqlconn.Close();
                }
             
            }
            else
            {
                Process_result.Text = "삭제할 공정을 선택해주세요";
                Process_result.ForeColor = Color.Red;
            }
        }

        // 부품 삭제 버튼  - 수정사항 : 예외 처리가 반복됨 
        private void Partch_Delbtn_Click(object sender, EventArgs e)
        {

            if (Partch_Table.SelectedRows.Count > 0)
            {
                try
                {
                    mssqlconn.Open();
                    foreach (var DelselectRow in selectedPDataList)
                    {
                        int Select_Row = -1; // 기본 행의 번호는 0부터 시작 선택이 없을시 디폴트인 0 행을 삭제 될수도 있기 때문에 디폴트 값에 대한 삭제 방지 
                        if (Partch_Table.CurrentCell != null) // null또는 선택을 안했을시 생기는 예외처리를 처리하기 위한 구문 - 오류 직접적으로 안보여주기
                        {
                            Select_Row = Partch_Table.CurrentCell.RowIndex;     //선택한 행의 - 활성된 행의 rowindex값을 가져오는 구문
                        }
                        
                        string ALCvalue = DelselectRow.Item1;                       //선택한 ALC가 들어 있는 행의 ALC값을 받아옴

                        string DelQry = "DELETE FROM partchtable where ALC = '" + ALCvalue + "'";
                        SqlCommand Partch_Del = new SqlCommand(DelQry, mssqlconn);
                        int resultList = Partch_Del.ExecuteNonQuery();

                        if (resultList > 0)
                        {
                            mssqlconn.Close();
                            MSLoadData2();
                            Partch_result.Text = "부품리스트 삭제.";
                            Partch_result.ForeColor = Color.Blue;
                        }
                      
                    }
                }
                catch (SqlException)
                {
                    Partch_result.Text = "실패! : 공정이 남아 있습니다. \n 공정을 확인해주세요";
                    Partch_result.ForeColor = Color.Red;
                    

                }
                catch (Exception)
                {
                    Partch_result.Text = "실패! : 공정을 확인해주세요";
                    Process_result.ForeColor = Color.Red;
                 
                }
                finally
                {
                    mssqlconn.Close();
                }
                

            }
        }

        // 결과 레이블 모음
        private void Partch_result_Click(object sender, EventArgs e)
        {

        }


        private void Part_Color_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
