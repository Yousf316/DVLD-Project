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
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;
        int PersonID { get; set; }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void ctrAddPerson1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (PersonID == -1)
            {
                label1.Text = "Add New Person";
               
            }
            else
            {
                label1.Text = "Update Person";
            }
            ctrAddPerson1.SetPersonID(PersonID);
        }

        

        private void ctrAddPerson1_OnCloseButton_1(bool obj)
        {
            bool Exsits = obj;
            if (Exsits)
                this.Close();
        }

        private void ctrAddPerson1_OnSaveButton(bool obj)
        {
            if(obj)
            {
                label1.Text = "Update Person";
            }
        }

        private void ctrAddPerson1_DataBack(object sender, int PersonID)
        {
            DataBack?.Invoke(this, PersonID);
            this.Close();
        }
    }
}
