﻿using DVLD_Business;
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
    public partial class ctrShowUserInfo : UserControl
    {

       
        public ctrShowUserInfo()
        {
            InitializeComponent();
            
        }

        public void GetUserInfo(int UserID)
        {
            clsUser user = clsUser.FindUser(UserID);

            if (user == null)
                return;

            ctrShowPerson1.GetPersonInfo(user.GetPersonID());
            lbUserID.Text = user.GetUserID().ToString();
            lbUserName.Text=user.GetUserName();
            
            if(user.GetIsActive())
            {
                lbIsActive.Text = "Yes";
            }
            else
            {
                lbIsActive.Text = "No";
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
