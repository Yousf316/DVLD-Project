using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmShowPersonDetails : Form
    {
        int PersonID {  get; set; }
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrShowPerson1.GetPersonInfo(PersonID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
