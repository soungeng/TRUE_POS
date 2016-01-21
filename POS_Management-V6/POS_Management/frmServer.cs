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
    public partial class frmServer : Form
    {
        public Boolean isShow = false;
        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            Setting.Connect();
            if (!isShow)
            {
                if (Properties.Settings.Default.sBDHost != "")
                {
                    var formlog = new frmLogIn(); //create an instance of Log in Form
                    formlog.ShowDialog();       //Log in Form show            
                }
                else
                {
                    txtDbhost.Text = Properties.Settings.Default.sBDHost;
                    txtDbname.Text = Properties.Settings.Default.sDBName;
                    txtDbuser.Text = Properties.Settings.Default.sDBUser;
                    txtDbpwd.Text = Properties.Settings.Default.sDBPwd;
                }
            }
            else
            {
                //var log = new frmServer();
                txtDbhost.Text = Properties.Settings.Default.sBDHost;
                txtDbname.Text = Properties.Settings.Default.sDBName;
                txtDbuser.Text = Properties.Settings.Default.sDBUser;
                txtDbpwd.Text = Properties.Settings.Default.sDBPwd;
                this.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int i = 0;
            Setting.SetDBHost( txtDbhost.Text);
            Setting.SetDBName(txtDbname.Text);
            Setting.SetDBUser(txtDbuser.Text);
            Setting.SetDBPassword(txtDbpwd.Text);

            if (!Setting.Connect())
            {
                 MessageBox.Show("Connection fail!","Server Connection",MessageBoxButtons.RetryCancel);
                 i += 1;
                 if (i == 3)
                 {
                     System.Windows.Forms.Application.Exit();
                 }
            }
            var Log = new frmLogIn();
            Properties.Settings.Default.sBDHost = txtDbhost.Text;
            Properties.Settings.Default.sDBName = txtDbname.Text;
            Properties.Settings.Default.sDBUser = txtDbuser.Text;
            Properties.Settings.Default.sDBPwd = txtDbpwd.Text;
            Properties.Settings.Default.Save();
            this.Dispose();
            Log.ShowDialog();
        }
    }
}
