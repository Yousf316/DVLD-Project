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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void RefreshTestTypesList()
        {
            dataGridView1.DataSource = clsTestType.GetAllTestTypes();
            lbRecordsCount.Text = dataGridView1.RowCount.ToString();
        }

     
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frmUpdate = new frmUpdateTestTypes((clsTestType.enclsTestTypes)dataGridView1.CurrentRow.Cells[0].Value);
            frmUpdate.ShowDialog();
            RefreshTestTypesList();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            RefreshTestTypesList();
        }
    }
}
