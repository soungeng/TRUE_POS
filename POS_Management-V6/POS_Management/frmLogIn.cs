using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Management
{
    public partial class frmLogIn : Form
    {
        DataTable dt;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dynamic[] para = new dynamic[4];
            para[0]="@uid";
            para[1] = "@pws";
            para[2] = "@uname";
            para[3] = "@status";

            dt = DBAccess.OperationGet.Get_by_Procedure("Get_user_login",para,0,txtPassword.Text,txtUsername.Text,1);
            if (dt.Rows.Count > 0)
            {
               // MessageBox.Show("Successful!", "Log In", MessageBoxButtons.OK);
                var main = new MAIN();
                Properties.Settings.Default.User_id = dt.Rows[0]["Usr_id"].ToString();
                Properties.Settings.Default.uname = dt.Rows[0]["Usr_name"].ToString();
                Properties.Settings.Default.Save();
                this.Dispose();
                main.ShowDialog();
            }
            else
                MessageBox.Show("Fail!, try again", "Log In", MessageBoxButtons.OK);
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User_id != "")
            {
                txtUsername.Text = Properties.Settings.Default.uname;
                txtPassword.TabIndex=1 ;
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var frm = new frmServer();
            frm.isShow = true;
            this.Dispose();
            frm.ShowDialog();
        }

    }
}
