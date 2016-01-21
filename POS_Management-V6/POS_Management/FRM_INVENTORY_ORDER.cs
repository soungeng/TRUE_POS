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
    public partial class FRM_INVENTORY_ORDER : Form
    {
        public FRM_INVENTORY_ORDER()
        {
            InitializeComponent();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            FRM_INVENTORY_ADD_ORDER frm = new FRM_INVENTORY_ADD_ORDER();
            frm.Show();
        }
    }
}
