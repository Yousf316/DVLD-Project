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
using System.IO;
using DVLD_Presentation.Classes;
using DVLD_Presentation.Global;

namespace DVLD_Presentation.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = ""; string Password = "";

            if(clsGlobal.GetStoredCredential(ref UserName,ref Password))
            {
                txtPassword.Text = Password;
                txtUserName.Text = UserName;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;

            }

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {

        }
       
   
       
        
    

        private void btnOk_Click(object sender, EventArgs e)
        {
            string HashPassword = clsValidatoin.HashCodeCompute(txtPassword.Text.Trim());
            clsUser UserID = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), HashPassword);

           
            if (UserID !=null)
            {

                if(UserID.GetIsActive())
                {
                    if(chkRememberMe.Checked)
                    {
                        clsGlobal.RememberUsernameAndPassword(txtUserName.Text,txtPassword.Text);
                    }
                    else
                    {
                        clsGlobal.RememberUsernameAndPassword(null, null);
                    }

                    MessageBox.Show("Login Successfuly", "Succseded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clsEventLogs.IsSourceNameExists();

                    clsEventLogs.WriteLog("User Login Successfuly",System.Diagnostics.EventLogEntryType.Information);


                    clsGlobal.CurrentUser = UserID;

                    frmHome home = new frmHome(this);
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("User is not Active contact with admin","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    clsEventLogs.WriteLog("User is Not Active try Login", System.Diagnostics.EventLogEntryType.Error);

                }
            }
            else
            {
                MessageBox.Show("Login filed UserName/Password is valid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clsEventLogs.WriteLog("User Login Faild", System.Diagnostics.EventLogEntryType.Error);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {


        }

       
    }
}
