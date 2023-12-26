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
    public partial class ModelINFT : Form
    {
        private Form1 formInstance;
        //private DataTable GetDataForm1()
        //{
        //    return formInstance.Instancedatabse();
        //}
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add(GetDataForm1());

        }


        public ModelINFT()
        {
            InitializeComponent();
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
            
        }
    }
}
