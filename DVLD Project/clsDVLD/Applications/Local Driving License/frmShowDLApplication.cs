using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Forms
{
    public partial class frmShowDLApplication : Form
    {
       int DLApplication { get; set; }  
        public frmShowDLApplication(int DLApplication)
        {
            InitializeComponent();
           this.DLApplication = DLApplication;
        }

        private void frmShowDLApplication_Load(object sender, EventArgs e)
        {
            ctrShowLDLApplicationInfo1.GetDLApplicationInfo(DLApplication);
        }
    }
}
