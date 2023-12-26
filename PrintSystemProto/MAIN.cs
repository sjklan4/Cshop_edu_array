using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintSystemProto
{
    internal static class MAIN
    {
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
