using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace PrintSystemProto
{
    internal static class MAIN
    {
/*        public static string uid = "sa";  //mssql 접속에 필요한 정보구문 
        public static string pws = "x";
        public static string database = "printsystem";
        public static string server = "Localhost";   // 편집 확인 필요~~~
        public string connstr = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + pws + ";";
        public SqlConnection mssqlconn;*/
        

        public static ModelINFT fmModel; //modelinf 클래스를 사용하는 선언문
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fmModel = new ModelINFT();
            


            try
            {
                Application.Run(new Form1());
            }catch(Exception ex) { 
                Console.WriteLine(ex.ToString());   
            }finally
            {

            }
        }
    }
}
