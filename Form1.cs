using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tslPeople_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmTest frmTest = new frmTest();
            frmTest.ShowDialog();
        }
    }
}
