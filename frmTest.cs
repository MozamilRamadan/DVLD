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
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            clsPerson person = new clsPerson();
            int id = 1026;
            person = clsPerson.Find(id);

            int newId = person.PersonID;

            ctrlPersonCard PersonCard = new ctrlPersonCard();

            PersonCard.LoadPersonInfo(newId);
        }
    }
}
