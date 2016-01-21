using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace True_POS_Activator
{
    public partial class frmActivate : Form
    {
        public frmActivate()
        {
            InitializeComponent();
        }

        private void frmActivate_Load(object sender, EventArgs e)
        {

            txtProID.Text = Activatation.GetDriveSerialNumber();
            txtProID.Tag = Conversion.Hex(Activatation.GetDriveSerialNumber());
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            String GetEn;
            bool result;
            result = txtProID.Tag.Equals(txtSerialID.Text);
            if (result)
            {
                GetEn = Activatation.EncryptRegisterKey(txtSerialID.Text);
                General.SaveRegistry(GetEn);
                MessageBox.Show("Successfully Activate", "Successfull", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(" Invalid Register Key, Please try another one", "", MessageBoxButtons.OK);
                txtSerialID.Text = "";
                txtSerialID.Focus();
            }
        }
    }
}
