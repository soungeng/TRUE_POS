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
    public partial class FRM_ADD_PRODUCT : Form
    {
        public int proID=0;
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (BTN_SAVE.Text == "&SAVE")
            {
                dynamic[] para = new dynamic[19];
                byte[] img = null;
                if (this.PIC_PRO_IMG.Image != null)
                    img = Setting.ImageToBinary(this.PIC_PRO_IMG.Image);
                para[0] = "Pro_name_en";
                para[1] = "Pro_name_kh";
                para[2] = "Pro_code";
                para[3] = "Cat_id";
                para[4] = "Uni_id";
                para[5] = "Pro_unit_cost";
                para[6] = "Pro_purchase_cost";
                para[7] = "Pro_level_price";
                para[8] = "Pro_price";
                para[9] = "Pro_price1";
                para[10] = "Pro_price2";
                para[11] = "Pro_price3";
                para[12] = "Pro_price4";
                para[13] = "Brd_id";
                para[14] = "Brh_id";
                para[15] = "Pro_qty";
                para[16] = "Pro_isactive";
                para[17] = "Usr_id";
                para[18] = "Pro_create_date";

                if (DBAccess.OperationInsert.Insert_by_direct
                    (
                        "PRODUCT",  //table name
                         para,   //parameters field
                    //----------parameters value-----
                          TXT_PRO_NAME_EN.Text,
                          TXT_NAME_KH.Text,
                          TXT_PRO_CODE.Text,
                          1, //cat id 3
                          1,  // unit id 4
                          0,   // purchase cost 5
                          2,    //levelPrice
                          TXT_PRICE.Text,
                          TXT_PRICE_LEVEL_1.Text,
                          TXT_PRICE_LEVEL_2.Text,
                          TXT_PRICE_LEVEL_3.Text,
                          TXT_PRICE_LEVEL_4.Text,
                          1, // brd id 12
                          1, //brh id 13
                          0, // pro qty 14
                          1, // is active 15
                          1, //isActive
                          Convert.ToInt32(Properties.Settings.Default.User_id), // userid 17
                          DateTime.Now // create date
                    //-------------------------------

                    )) MessageBox.Show("saved!");
            }
            else
            {
                try
                {
                dynamic[] para= new dynamic[20];
                para[0] = "Pro_name_en";
                para[1] = "Pro_name_kh";
                para[2] = "Pro_code";
                para[3] = "Cat_id";
                para[4] = "Uni_id";
                para[5] = "Pro_unit_cost";
                para[6] = "Pro_purchase_cost";
                para[7] = "Pro_level_price";
                para[8] = "Pro_price";
                para[9] = "Pro_price1";
                para[10] = "Pro_price2";
                para[11] = "Pro_price3";
                para[12] = "Pro_price4";
                para[13] = "Brd_id";
                para[14] = "Brh_id";
                para[15] = "Pro_qty";
                para[16] = "Pro_isactive";
                para[17] = "Usr_modify_id";
                para[18] = "Pro_modify_date";
                para[19] = "Pro_img";
                byte[] img = null;
                if (this.PIC_PRO_IMG.Image != null)
                    img = Setting.ImageToBinary(this.PIC_PRO_IMG.Image);
                if (DBAccess.OperationUpdate.Update_by_direct("PRODUCT",
                          para,
                          "Pro_id="+proID, // condition
                          TXT_PRO_NAME_EN.Text, // name english 0 
                          TXT_NAME_KH.Text, // name kh 1
                          TXT_PRO_CODE.Text, //code 2
                          2, //cat id 3
                          1,  // unit id 4
                          0,    // unit cost 5
                          0,   // purchase cost 6
                          2,    //levelPrice 7
                          TXT_PRICE.Text, // 8
                          TXT_PRICE_LEVEL_1.Text, //9
                          TXT_PRICE_LEVEL_2.Text, // 10
                          TXT_PRICE_LEVEL_3.Text, //11
                          TXT_PRICE_LEVEL_4.Text, //12
                          1, // brd id 13
                          1, //brh id 14
                          0, // pro qty 15
                          1, // is active 16
                          Convert.ToInt32(Properties.Settings.Default.User_id), // userid 17
                          DateTime.Now, // modify date 18
                          img //19
                        ))
                        MessageBox.Show("Updated!");
                         this.Dispose();
                         //var Pro = new FRM_PRODUCT();
                         //Pro.Get_Product("Pro_id="+proID);
                         
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PIC_PRO_IMG_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";
                var op = opf.ShowDialog();
                if (op == DialogResult.OK)
                {
                    PIC_PRO_IMG.ImageLocation = opf.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {
            pnlTitle.BackColor = Properties.Settings.Default.TitleColor;
            this.BackColor = Properties.Settings.Default.BodyColor;
            lblProduct.Text = "ADD NEW PRODUCT";
            if (proID != 0)
            { GetProduct(proID); lblProduct.Text = "UPDATE PRODUCT"; }
        }

        private void GetProduct(int id)
        {
            try
            {

                DataTable dtPro = new DataTable();
                dtPro = DBAccess.OperationGet.Get_by_direct("PRODUCT", "*", "Pro_id=" + id);
                if (dtPro.Rows.Count > 0)
                {
                    TXT_PRO_NAME_EN.Text = dtPro.Rows[0]["Pro_name_en"].ToString();
                    TXT_NAME_KH.Text = dtPro.Rows[0]["Pro_name_kh"].ToString();
                    TXT_PRO_ID.Text = dtPro.Rows[0]["Pro_id"].ToString();
                    TXT_PRO_CODE.Text = dtPro.Rows[0]["Pro_code"].ToString();
                    TXT_PRICE.Text = dtPro.Rows[0]["Pro_price"].ToString();
                    TXT_PRICE_LEVEL_1.Text = dtPro.Rows[0]["Pro_price1"].ToString();
                    TXT_PRICE_LEVEL_2.Text = dtPro.Rows[0]["Pro_price2"].ToString();
                    TXT_PRICE_LEVEL_3.Text = dtPro.Rows[0]["Pro_price3"].ToString();
                    TXT_PRICE_LEVEL_4.Text = dtPro.Rows[0]["Pro_price4"].ToString();
                    if (dtPro.Rows[0]["Pro_img"] != DBNull.Value)
                        PIC_PRO_IMG.Image = Setting.BinarytoImage((Byte[])dtPro.Rows[0]["Pro_img"]);
                    else
                        PIC_PRO_IMG.Image = Properties.Resources.DefaultProImg;
                    // txt 
                    BTN_SAVE.Text = "&UPDATE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
