using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataTable table = Db.RETRIEVE($"SELECT * FROM mInspector");
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

    }
}
