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
    public partial class FRM_CATEGORY : Form
    {
        Button[] GlobalBtnCat;
        Boolean isDel = false;
        int CatIndex;
        public Color DelMode = Properties.Settings.Default.DeleteModeColor;
        public Color DefualCat = Properties.Settings.Default.DefaultProColor;
        public Color AlertColor = Properties.Settings.Default.AlertColor;

        public FRM_CATEGORY()
        {
            InitializeComponent();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_CATEGORY frm = new FRM_ADD_CATEGORY();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FRM_CATEGORY_Load(object sender, EventArgs e)
        {
            pnlTitle.BackColor = Properties.Settings.Default.TitleColor;
            getCategoty();
        }

        private void getCategoty()
        {
            //int x = 20, y = 10;
            dynamic[] para = new dynamic[3];
            para[0] = "@cat_id";
            para[1] = "@status";
            para[2] = "@brh_id";
            //---------------------------
            int x = 0, y = 0, spc = 0;
            int Cx = 200, Cy = 50;
            //spc = (pnlPro.Width-10) % (Gx+20);
            int item = 0;
            item = pnlCat.Width / (Cx + 20);
            spc = pnlCat.Width - ((Cx + 20) * item);
            x = spc / 2;
            //---------------------------
            DataTable dtCat = new DataTable();
            dtCat = DBAccess.OperationGet.Get_by_Procedure("Get_category", para, -1, -1, 1);
            Button[] cate = new Button[dtCat.Rows.Count];
            try
            {
                if (dtCat.Rows.Count > 0)
                {
                    pnlCat.Controls.Clear();
                    pnlCat.Controls.Add(pnlSearch);
                    for (int i = 0; i < dtCat.Rows.Count; i++)
                    {
                        cate[i] = new Button();
                        cate[i].Name = "btn" + dtCat.Rows[i]["Cat_name_en"].ToString();
                        cate[i].AccessibleName = i.ToString();
                        cate[i].Tag = dtCat.Rows[i]["Cat_id"].ToString();
                        cate[i].Text = dtCat.Rows[i]["Cat_name_en"].ToString();
                        cate[i].Size = new Size(Cx, Cy);
                        cate[i].Location = new Point(x, y);
                        cate[i].FlatStyle = FlatStyle.Flat;
                        cate[i].Font = new Font("Microsoft Sans Serif", 12);
                        cate[i].Click += new System.EventHandler(Cat_ClickHandler);
                        pnlCat.Controls.Add(cate[i]);
                        /* x = x + 140;
                         if (x + cate[i].Width > pnlCate.ClientRectangle.Width)
                         { y = y + (cate[i].Height+10); x = 20; }
                        */
                        //---------------------------------------
                        x = x + Cx + 20;
                        if ((i + 1) % item == 0)
                        {
                            y = y + cate[i].Height + 10; x = spc / 2;

                        }
                        //---------------------------------------

                    }
                    GlobalBtnCat = new Button[dtCat.Rows.Count];
                    GlobalBtnCat = cate;
                    cate[0].PerformClick();
                    cate[0].Focus();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void Cat_ClickHandler(Object sender, EventArgs e)
        {
            if (isDel)
                if (MessageBox.Show("You're on Deleting Mode. Click Yes-> Leave Delete Mode?", "Deleting Mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    btnDel.PerformClick();
                else return;
            CatIndex = Convert.ToInt32(((Button)sender).AccessibleName);
            //Get_Product("Cat_id=" + ((Button)sender).Tag.ToString());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addCat = new FRM_ADD_CATEGORY();
            addCat.ShowDialog();
        }
       
    }
}
