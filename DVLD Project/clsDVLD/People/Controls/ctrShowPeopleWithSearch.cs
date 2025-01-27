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
    public partial class ctrShowPeopleWithSearch : UserControl
    {

        public event Action<int> OnButtonSetPerson;
        // Create a protected method to raise the event with a parameter
        protected virtual void _OnButtonSetPerson(int PeronID)
        {
            Action<int> handler = OnButtonSetPerson;
            if (handler != null)
            {
                handler(PeronID); // Raise the event with the parameter
            }
        }

        public clsPerson obPerson { get {return ctrShowPerson1.obPerson; } }

        public ctrShowPeopleWithSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson(-1);
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int PersonID)
        {
            SetPersonInfoLock(PersonID);
        }

        private void ctrShowPeopleWithSearch_Load(object sender, EventArgs e)
        {
            cmbFinds.SelectedIndex = 0;
        }

        private void SearchOperator()
        {

            if (cmbFinds.SelectedItem.ToString()=="PersonID")
            {

                if (!int.TryParse(txtSearch.Text, out int PersonID))
                {
                    txtSearch.Text = "";
                    return;
                }
                if (clsPerson.IsExists(PersonID))
                {
                    ctrShowPerson1.GetPersonInfo(PersonID);


                        if (OnButtonSetPerson != null)
                            _OnButtonSetPerson(PersonID);
                   
                }
                else
                {
                    MessageBox.Show("ID " + PersonID + " Is not Exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }
            else
            {
                int PersonID =-1;
                if (clsPerson.IsExists(txtSearch.Text, ref PersonID) )
                {
                    ctrShowPerson1.GetPersonInfo(PersonID);

                    if (OnButtonSetPerson != null)
                            _OnButtonSetPerson(PersonID);
                  
                }
                else
                {
                    MessageBox.Show("ID " + txtSearch.Text + " Is not Exsits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        public void SetPersonInfoLock(int PersonID)
        {
            if (clsPerson.IsExists(PersonID))
            {
                txtSearch.Text=PersonID.ToString();
                pnlSearchPerson.Enabled = false;
            }
            ctrShowPerson1.GetPersonInfo(PersonID);
        }

        public int GetPersonID()
        {
           return ctrShowPerson1.GetPersonID();
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchOperator();


        }

        private void ctrShowPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
