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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            //ctrlPersonCard1.LoadPersonInfo(1023);
            ctrlPersonCard1.LoadPersonInfo(1025);
        }

    }
}
