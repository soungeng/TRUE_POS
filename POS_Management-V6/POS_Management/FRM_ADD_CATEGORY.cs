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
    public partial class FRM_ADD_CATEGORY : Form
    {
        public FRM_ADD_CATEGORY()
        {
            InitializeComponent();
        }

        private void FRM_ADD_CATEGORY_Load(object sender, EventArgs e)
        {
            pnlCat.BackColor = Properties.Settings.Default.TitleColor;
            this.BackColor = Properties.Settings.Default.BodyColor;
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
