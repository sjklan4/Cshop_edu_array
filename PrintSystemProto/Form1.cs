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

namespace PrintSystemProto
{
    public partial class Form1 : Form
    {
        public static string uid = "sa";
        public static string pws = "x";
        public static string database = "printsystem";
        public static string server = "localhost";

        //MySqlConnection connection = new MySqlConnection("Server=127.0.0.1" +
        //    "Database=printsystemproto" +
        //    "Uid=root" +
        //    "Pwd=qjabek46");

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "모델";
            dataGridView1.Columns[1].Name = "모델명";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private bool DupleValuechk(string val, int column)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[column].Value != null && row.Cells[column].Value.ToString().Trim().Equals(val, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // 중복된 값이 있음
                }
            }
            return false; // 중복된 값이 없음
        }

        public int currentindex = 0;
        //bool valuechk = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string modelValue = modelbox.Text.Trim();
            string modelNameValue = modelNamebox.Text.Trim();

            if (DupleValuechk(modelValue, 0) || DupleValuechk(modelNameValue, 1)) // =modelbox, 0번 cell 
            {
                MessageBox.Show("중복된 값이 있습니다.");
            }
            else
            {
                dataGridView1.Rows.Add(modelValue, modelNameValue);
                // mssql 적용 부분 ---------------------------------------------------------------------------------------------------
                string connstr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + pws + ";";
                SqlConnection conn = new SqlConnection(connstr);

                try
                {
                    conn.Open();
                    string insertQry = "INSERT INTO printsystemtable(model,modelname) VALUES('" + modelValue + "', '" + modelNameValue + "')";
                    
                    SqlCommand cmd = new SqlCommand(insertQry, conn);
                    

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("인서트 성공");
                    }
                    else
                    {
                        MessageBox.Show("인서트 실패");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

                //mariadb 적용 구문 부분 -------------------------------------------------------------------------------------------
                /*using (MySqlConnection connection = new MySqlConnection("Server=;" +
                                                                        "Database=;" +
                                                                        "Uid=root;" +
                                                                        "Pwd="))
                {
                    string insertQry = "INSERT INTO printsystemproto(model,modelname) VALUES('" + modelValue + "', '" + modelNameValue + "')";
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(insertQry, connection);

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("인서트 성공");
                        }
                        else
                        {
                            MessageBox.Show("인서트 실패");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                
                    
                }*/
                //----------------------------------------------------------------------------------------------------------------------
            }

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value == modelbox.Text)
            //    {

            //        MessageBox.Show("중복된 모델입니다.");
            //        valuechk = true;
            //        break;
            //    }
            //    else if (dataGridView1.Rows[i].Cells[1].Value != null && dataGridView1.Rows[i].Cells[1].Value == modelNamebox.Text)
            //    {

            //        MessageBox.Show("중복된 모델이름입니다.");
            //        valuechk = true;
            //        break;
            //    }

            //}
            //if (valuechk == false)
            //{
            //    dataGridView1.Rows.Add(modelbox.Text, modelNamebox.Text);
            //}


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
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modelbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                modelNamebox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
           
        }
    }
}
