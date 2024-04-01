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
    public partial class frmUpdateTestTypes : Form
    {
        clsTestType.enclsTestTypes _TestTypeID { get; set; }
        clsTestType _objTestType { get; set; }
        public frmUpdateTestTypes(clsTestType.enclsTestTypes TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;   
        }

        private void GetTestTypeInfo()
        {
            _objTestType = clsTestType.FindTestType(_TestTypeID);

            if (_objTestType == null)
                return;
            lbID.Text=_objTestType.GetTestTypeID().ToString();
            txtFees.Text = _objTestType.GetTestTypeFees().ToString();
            txtName.Text = _objTestType.GetTestTypeTitle();
            rtxtDescription.Text= _objTestType.GetTestTypeDescription();
        }

        private bool UpdateTestType()
        {


            if (_objTestType == null)
                return false;

            float.TryParse(txtFees.Text, out float _Fees);
            _objTestType.UpdateColumns(txtName.Text,rtxtDescription.Text, _Fees);
            return _objTestType.SaveTestTypes ();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateTestType())
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("false");

            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            GetTestTypeInfo();
        }
    }
}
