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
    public partial class frmSchedualVissionTest : Form
    {
        int _ID = 0;
        public frmSchedualVissionTest(int id)
        {
            InitializeComponent();
            _ID = id;
            ctrlApplicationDetails1 = new ctrlApplicationDetails(id);
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            frmSchedualTest frm = new frmSchedualTest();
            frm.ShowDialog();
        }
    }
}
