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

namespace POS_Management
{
    public partial class FRM_PRODUCT : Form
    {
        //---------------define Color---------------
        public Color DelMode = Properties.Settings.Default.DeleteModeColor;
        public Color DefualPro = Properties.Settings.Default.DefaultProColor;
        public Color AlertColor = Properties.Settings.Default.AlertColor;
        //-----------------------------
        public  Button[] GlobalBtnCat;
        public Button[] GlobalBtnPro;
        public CheckBox[] GlobalchkDelPro;
        public Panel[] GlobalProGroup;
        public Label[] GlobalLabelStock;
        public Boolean isDel = false;
        public int ProIndex=0;
        public int CatIndex = 0;

        public FRM_PRODUCT()
        {
            InitializeComponent();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.Show();
        }

        private void BTN_CATEGORY_Click(object sender, EventArgs e)
        {
            FRM_CATEGORY frm = new FRM_CATEGORY();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FRM_PRODUCT_Load(object sender, EventArgs e)
        {
            try
            {
                pnlHead.BackColor = Properties.Settings.Default.TitleColor;
                pnlPro.BackColor = Properties.Settings.Default.BodyColor;
                pnlFooter.BackColor = Properties.Settings.Default.TitleColor;
                lblProlist.Location = new Point((pnlHead.Width / 2) - (lblProlist.Width/2), 15);
                getCategoty();
                getBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getBrand()
        {
            dynamic[] para = new dynamic[3];
            para[0] = "@cat_id";
            para[1] = "@status";
            para[2] = "@brh_id";
            DataTable dtCat = new DataTable();
            dtCat = DBAccess.OperationGet.Get_by_Procedure("Get_category", para, -1, -1, 1);
            try
            {
                if (dtCat.Rows.Count > 0)
                {
                    for (int i = 0; i < dtCat.Rows.Count; i++)
                    {

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            int Cx = 130, Cy = 50;
            //spc = (pnlPro.Width-10) % (Gx+20);
            int item = 0;
            item = pnlCate.Width / (Cx + 20);
            spc = pnlCate.Width - ((Cx + 20) * item);
            x = spc / 2;
            //---------------------------
            DataTable dtCat = new DataTable();
            dtCat = DBAccess.OperationGet.Get_by_Procedure("Get_category", para, -1, -1, 1);
            Button[] cate = new Button[dtCat.Rows.Count];
            try
            {
                if (dtCat.Rows.Count > 0)
                {
                    pnlCate.Controls.Clear();
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
                        pnlCate.Controls.Add(cate[i]);
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
                    GlobalBtnCat= new Button[dtCat.Rows.Count];
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
                    btnDelete.PerformClick();
                else return;
            CatIndex = Convert.ToInt32(((Button)sender).AccessibleName);
            Get_Product("Cat_id="+((Button)sender).Tag.ToString());
        }
        private void chkPro_CheckedChange(Object sender, EventArgs e)
        {
            ProIndex = Convert.ToInt32(((CheckBox)sender).AccessibleName);
            Color col = DefualPro;
            if (((CheckBox)sender).Checked)
                col=DelMode;
            else
                if (Convert.ToInt32(GlobalLabelStock[ProIndex].Tag.ToString()) == 0) col = AlertColor;

            GlobalProGroup[ProIndex].BackColor = col;
                
        }

        private void Pro_ClickHandler(Object sender, EventArgs e)
        {
            Boolean check = true;
            Color col = DelMode;
            ProIndex = Convert.ToInt32(((Button)sender).AccessibleName);
            if (!isDel)
            {
                // MessageBox.Show("Button " + ((Button)sender).ToString() + " was clicked");
                string str = ((Button)sender).Tag.ToString();
                DataTable dtPro = new DataTable();
                var frmPro = new FRM_ADD_PRODUCT();
                frmPro.proID = Convert.ToInt32(str);
                frmPro.ShowDialog();
            }
            else
            {
                if (GlobalchkDelPro[ProIndex].Checked == true)
                { 
                    check = false; col = DefualPro;
                    if (Convert.ToInt32(GlobalLabelStock[ProIndex].Tag.ToString()) == 0) col = AlertColor;
                }
                GlobalchkDelPro[ProIndex].Checked = check;
                GlobalProGroup[ProIndex].BackColor = col;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "&Delete")
            {
                btnDelete.Text = "&Cancel";
                btnConf_del.Visible=true;
                isDel = true;
                for (int i = 0; i < GlobalchkDelPro.Length; i++)
                {
                    GlobalchkDelPro[i].Visible = true;
                }
            }
            else
            {
                btnDelete.Text = "&Delete";
                btnConf_del.Visible=false;
                isDel = false;
                for (int i = 0; i < GlobalchkDelPro.Length; i++)
                {
                    if (GlobalchkDelPro[i].Checked == true) GlobalchkDelPro[i].Checked = false;
                    GlobalchkDelPro[i].Visible = false;
                    GlobalchkDelPro[i].BackColor = DefualPro;
                }
            }
        }

        private void btnConf_del_Click(object sender, EventArgs e)
        {
            string Pro_Del_id = "", id="", cond= "";
            dynamic[] para = new dynamic[1];
           var ok= MessageBox.Show("Delete Item(s)?","Delete",MessageBoxButtons.YesNo);
           if (ok == DialogResult.Yes)
           {
               for (int i=0; i<GlobalBtnPro.Length;i++)
               {
                   if (GlobalchkDelPro[i].Checked)
                   {
                       Pro_Del_id = GlobalBtnPro[i].Tag + ",";
                       id += Pro_Del_id;
                   }
                  
               }
               para[0] = "Pro_isactive";
               cond = "Pro_id In(" + Strings.Left(id, Strings.Len(id) - 1) + ")";
               if (DBAccess.OperationUpdate.Update_by_direct("PRODUCT", para, cond, 0))
                   MessageBox.Show("Product(s) id: "+id+" has deleted!","Delete Prouduct",MessageBoxButtons.OK);
               GlobalBtnCat[0].PerformClick();
           }

        }
        public void Get_Product(string cond)
        {
            try
            {
                
                //MessageBox.Show("Button" +((Button) sender).ToString() + " was clicked");
                //string str = ((Button)sender).Tag.ToString();
                DataTable dtPro = new DataTable();
                Color col;
                dtPro = DBAccess.OperationGet.Get_by_direct("PRODUCT", "*", cond);
                Button[] Pro = new Button[dtPro.Rows.Count];
                Panel[] GPro = new Panel[dtPro.Rows.Count];
                Label[] lblProName = new Label[dtPro.Rows.Count];
                Label[] lblProstock = new Label[dtPro.Rows.Count];
                CheckBox[] chkPro = new CheckBox[dtPro.Rows.Count];
                int x = 0, y = 5, spc = 0;
                int Gx = 130, Gy = 150;
                //spc = (pnlPro.Width-10) % (Gx+20);
                int item = 0;
                item = pnlPro.Width / (Gx + 20);
                spc = pnlPro.Width - ((Gx + 20) * item);
                x = spc / 2;
                pnlPro.Controls.Clear();
                if (dtPro.Rows.Count > 0)
                {
                    for (int i = 0; i < dtPro.Rows.Count; i++)
                    {
                        col= Properties.Settings.Default.DefaultProColor;
                        //---------Button ------------------------------------------
                        Pro[i] = new Button();
                        Pro[i].Name = "btn" + dtPro.Rows[i]["Pro_name_en"].ToString();
                        Pro[i].Tag = dtPro.Rows[i]["Pro_id"].ToString();
                        Pro[i].AccessibleName = i.ToString();
                        //Pro[i].Text = dtPro.Rows[i]["Pro_name_en"].ToString();
                        Pro[i].Size = new Size(120, 85);
                        Pro[i].Location = new Point(5, 10);
                        Pro[i].FlatStyle = FlatStyle.Flat;
                        Pro[i].Font = new Font("Microsoft Sans Serif", 12);
                        Pro[i].Click += new System.EventHandler(Pro_ClickHandler);
                        //Pro[i].BackgroundImage = Properties.Resources.DefaultProImg;
                        Pro[i].BackgroundImageLayout = ImageLayout.Stretch;
                        if (dtPro.Rows[i]["Pro_img"] != DBNull.Value)
                            Pro[i].BackgroundImage = Setting.BinarytoImage((Byte[])dtPro.Rows[i]["Pro_img"]);
                        else
                            Pro[i].BackgroundImage = Properties.Resources.DefaultProImg;
                        //-----------------------------------------------------------
                        //-------------------Label Name------------------------------
                        lblProName[i] = new Label();
                        lblProName[i].Text = "Name: " + dtPro.Rows[i]["Pro_name_en"].ToString();
                        lblProName[i].Size = new Size(120, 20);
                        lblProName[i].Location = new Point(5, (Pro[i].Height + 20));
                        //-----------------------------------------------------------
                        //---------------------CheckBox------------------------------
                        chkPro[i] = new CheckBox();
                        chkPro[i].Text = "";
                        chkPro[i].AccessibleName = i.ToString();
                        chkPro[i].Font = new Font("Microsoft Sans Serif", 13);
                        chkPro[i].CheckAlign = ContentAlignment.MiddleRight;
                        chkPro[i].Tag = dtPro.Rows[i]["Pro_id"];
                        chkPro[i].Size = new Size(20, 15);
                        chkPro[i].Location = new Point(Gx - 30, Gy - 20);
                        chkPro[i].BringToFront();
                        chkPro[i].CheckedChanged += new System.EventHandler(chkPro_CheckedChange);

                        chkPro[i].Visible = false;
                        //-----------------------------------------------------------
                        //-------------------Label Stock------------------------------
                        lblProstock[i] = new Label();
                        lblProstock[i].Text = "Stock: " + dtPro.Rows[i]["Pro_qty"].ToString();
                        lblProstock[i].Tag =  dtPro.Rows[i]["Pro_qty"].ToString();
                        lblProstock[i].Size = new Size(120, 20);
                        lblProstock[i].Location = new Point(5, ((Pro[i].Height + lblProstock[i].Height) + 20));
                        //-----------------------------------------------------------

                        //----------------GroupBox-----------------------------------
                        GPro[i] = new Panel();
                        GPro[i].Size = new Size(Gx, Gy);
                        GPro[i].Location = new Point(x, y);
                        //GPro[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                        GPro[i].Controls.Add(Pro[i]);
                        GPro[i].Controls.Add(lblProName[i]);
                        GPro[i].Controls.Add(chkPro[i]);
                        GPro[i].Controls.Add(lblProstock[i]);
                        //------------------stock status------------------------------
                        if (Convert.ToInt32(dtPro.Rows[i]["Pro_qty"].ToString()) <= 0)
                            col = AlertColor;
                        GPro[i].BackColor = col;
                        //
                        //------------------------------------------------------------
                        pnlPro.Controls.Add(GPro[i]);
                        x = x + Gx + 20;
                        if ((i + 1) % item == 0)
                        {
                            y = y + GPro[i].Height + 10; x = spc / 2;

                        }
                    }
                    //--------------------asign control to Global Object---------------
                    GlobalProGroup = new Panel[dtPro.Rows.Count];
                    GlobalProGroup = GPro;
                    GlobalBtnPro = new Button[dtPro.Rows.Count];
                    GlobalBtnPro = Pro;
                    GlobalchkDelPro = new CheckBox[dtPro.Rows.Count];
                    GlobalchkDelPro = chkPro;
                    GlobalLabelStock = new Label[dtPro.Rows.Count];
                    GlobalLabelStock = lblProstock;
                    //------------------------------------------------------------------
                }
                else
                {

                    Label lblstatus = new Label();
                    lblstatus.Text = "No Products found!";
                    x = (pnlPro.Width / 2) - (lblstatus.Width / 2);
                    y = pnlPro.Height / 2;
                    lblstatus.Location = new Point(x, y);
                    lblstatus.AutoSize = true;
                    lblstatus.Font = new Font("Microsoft Sans Serif", 13);
                    pnlPro.Controls.Add(lblstatus);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtPro_Code_TextChanged(object sender, EventArgs e)
        {
            int catid;
            string cond = "", Cat_cond="";
            if (CatIndex != 0)
            {
                catid = Convert.ToInt32(GlobalBtnCat[CatIndex].AccessibleName);
                Cat_cond = "And Cat_id=" + catid ;
            }
            cond = "Pro_code like '" + txtPro_Code.Text + "%'" +Cat_cond;
            Get_Product(cond);
        }

        private void TXT_NAME_TextChanged(object sender, EventArgs e)
        {
            int catid;
            string cond = "", Cat_cond = "";
            if (CatIndex != 0)
            {
                catid = Convert.ToInt32(GlobalBtnCat[CatIndex].AccessibleName);
                Cat_cond = "And Cat_id=" + catid;
            }
            cond = "Pro_name_en like '" + TXT_NAME.Text + "%'" + Cat_cond;
            Get_Product(cond);
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            var AddPro = new FRM_ADD_PRODUCT();
            AddPro.ShowDialog();
        }

    }
}
