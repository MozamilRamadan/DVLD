using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int ID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(ID);
        }
        public frmShowPersonInfo(string NaNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NaNo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
