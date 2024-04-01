using DVLD_Business;
using DVLD_Presentation.Classes;
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
    public partial class frmUpdateApplicationTypes : Form
    {

        int _AppTypeID { get; set; }
        clsApplicationType _objAppType { get; set; }
        public frmUpdateApplicationTypes(int AppTypeID)
        {
            InitializeComponent();
            _AppTypeID = AppTypeID;
        }

        private void GetAppTypeInfo()
        {       
            _objAppType = clsApplicationType.FindApplicationType(_AppTypeID);

            if( _objAppType == null )
             return;
            
            txtFees.Text=_objAppType.GetApplicationFees().ToString();
            txtName.Text=_objAppType.GetApplicationTypeTitle();

        }

        private bool UpdateAppType()
        {
           

            if (_objAppType == null)
                return false;

            float.TryParse(txtFees.Text, out float _Fees);

            _objAppType.SetCoulmns(txtName.Text, _Fees);

           return _objAppType.SaveApplicationTypes();
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if(!this.ValidateChildren())
            {
                MessageBox.Show("Theres Wrong Filed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

           if( UpdateAppType())
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("false");

            }
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            GetAppTypeInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(txtName.Text =="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName,"Title Should be not empty");
            }
            else
            {
                errorProvider1.SetError(txtName, null);

            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (txtFees.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Title Should be not empty");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);

            }


            if (!clsValidatoin.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);

            }

        }
    }
}
