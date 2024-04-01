using DVLD_Business;
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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }


        private void RefreshApplicationTypesList()
        {
            dataGridView1.DataSource = clsApplicationType.GetAllApplicationTypes();
            lbRecordsCount.Text=dataGridView1.RowCount.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            RefreshApplicationTypesList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes frmUpdate = new frmUpdateApplicationTypes((int)dataGridView1.CurrentRow.Cells[0].Value);
            frmUpdate.ShowDialog();
            RefreshApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
