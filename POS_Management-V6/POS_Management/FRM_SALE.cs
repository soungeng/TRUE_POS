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
    public partial class FRM_SALE : Form
    {
        public FRM_SALE()
        {
            InitializeComponent();
        }

        private void FRM_SALE_Load(object sender, EventArgs e)
        {
            //timer running
            TIMER1.Start();
            pnlhead.BackColor = Properties.Settings.Default.HeadColor;
            LBL_USER_ID.Text = "(" + Properties.Settings.Default.User_id + ") " + Properties.Settings.Default.uname;
            TXT_BARCODE.Focus();
            
            //display product
            //InitProduct();
            
            //display category
            InitCategory(0);

        }

        private void ProductClick(object sender, EventArgs e)
        {
            Button btn =  (Button)sender;
            AddProductToDGVByProId(Convert.ToInt32(btn.Tag));
            
        }

        private void AddProductToDGVByProId(int pro_id)
        {
            if (TXT_INVOICE_NO.Text != "")
            {
                try
                {
                    DataTable dt_product = new DataTable();
                    dt_product = DBAccess.OperationGet.Get_by_direct("PRODUCT", "Pro_id, Pro_code, Pro_name_en, Pro_name_kh, Pro_price", "Pro_status=1 and Pro_id=" + pro_id);

                    if (dt_product.Rows.Count > 0)
                    {
                        AddProductToDGV(dt_product);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please add new invoice first!");
            }
        }

        private void AddProductToDGVByBarcode(string barcode)
        {
            if (TXT_INVOICE_NO.Text != "")
            {


                try
                {
                    DataTable dt_product = new DataTable();
                    dt_product = DBAccess.OperationGet.Get_by_direct("PRODUCT", "Pro_id, Pro_code, Pro_name_en, Pro_name_kh, Pro_price", "Pro_status=1 and Pro_code = '" + barcode + "'");

                    if (dt_product.Rows.Count > 0)
                    {
                        AddProductToDGV(dt_product);
                    }
                    else
                    {
                        MessageBox.Show("Barcode not exist, please try another code!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
            else
            {
                MessageBox.Show("Please add new invoice first!");
            }
        }

        private void AddProductToDGV(DataTable dt)
        {
            DGV_ORDERED_PRODUCT.Rows.Add();
            int indexDGV = DGV_ORDERED_PRODUCT.Rows.Count - 1;
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVTXT_PRO_ID"].Value = dt.Rows[0]["Pro_id"].ToString(); ;
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVTXT_PRO_NAME"].Value = dt.Rows[0]["Pro_name_en"].ToString();
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVTXT_PRO_PRICE"].Value = Convert.ToDouble( dt.Rows[0]["Pro_price"]).ToString("0.000");
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVBTN_MINUS"].Value = "-";
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVTXT_QTY"].Value = 1;
            DGV_ORDERED_PRODUCT.Rows[indexDGV].Cells["DGVBTN_PLUS"].Value = "+";
            TXT_BARCODE.Text = "";
            TXT_BARCODE.Focus();
        }

        private void InsertOrderedProduct(int pro_id)
        {
            try
            {
                DataTable dt_product = new DataTable();
                dt_product = DBAccess.OperationGet.Get_by_direct("PRODUCT", "Pro_id, Pro_code, Pro_name_en, Pro_name_kh, Pro_price", "Pro_status=1 and Pro_id=" + pro_id);

                if (dt_product.Rows.Count > 0)
                {
                    
                    dynamic[] dynamic_field = new dynamic[11];
                    dynamic_field[0] = "Inv_id";
                    dynamic_field[1] = "Pro_id";
                    dynamic_field[2] = "Pro_code";
                    dynamic_field[3] = "Pro_name_en";
                    dynamic_field[4] = "Pro_name_kh";
                    dynamic_field[5] = "Ind_qty";
                    dynamic_field[6] = "Ind_price";
                    dynamic_field[7] = "Prn_id";
                    dynamic_field[8] = "Ind_sale_price";
                    dynamic_field[9] = "Usr_id";
                    dynamic_field[10] = "Ind_status";

                    dynamic[] dynamic_value = new dynamic[11];
                    dynamic_value[0] = TXT_INVOICE_NO.Tag;
                    dynamic_value[1] = pro_id;
                    dynamic_value[2] = dt_product.Rows[0]["Pro_code"];
                    dynamic_value[3] = dt_product.Rows[0]["Pro_name_en"];
                    dynamic_value[4] = dt_product.Rows[0]["Pro_name_kh"];
                    dynamic_value[5] = 1;
                    dynamic_value[6] = dt_product.Rows[0]["Pro_price"];
                    dynamic_value[7] = 0;
                    dynamic_value[8] = dt_product.Rows[0]["Pro_price"];
                    dynamic_value[9] = Properties.Settings.Default.User_id;
                    dynamic_value[10] = 1;

                    DBAccess.OperationInsert.Insert_by_direct("INVOICE_DETAIL", dynamic_field, dynamic_value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void InitProduct(int cat_id)
        {
            try
            {
                DataTable dt_product = new DataTable();
                dt_product = DBAccess.OperationGet.Get_by_direct("PRODUCT PR INNER JOIN PRODUCT_CATEGORY PC ON PR.Pro_id=PC.Pro_id ", "PR.Pro_id,PR.Pro_img,PR.Pro_price,PR.Pro_code,PR.Pro_name_en,PR.Pro_name_kh", "PR.Pro_status=1 and PC.Cat_id=" + cat_id);
                //MessageBox.Show(dt_product.Rows.Count.ToString());
                if (dt_product.Rows.Count > 0)
                {
                    
                    PNL_PRODUCT.Controls.Clear();

                    int width_space = 9,  heigh_space = 9;
                    int  grb_x=0,grb_y=0;
                    int  horizontal_num = 4;
                    for (int i = 1; i <= dt_product.Rows.Count; i++)
                    {

                        // 
                        // BTN_PRO1
                        // 
                        Button btn_pro = new Button();
                        btn_pro.BackColor = BTN_PRO.BackColor;
                        btn_pro.FlatStyle = BTN_PRO.FlatStyle;
                        btn_pro.Font = BTN_PRO.Font;
                        btn_pro.Location = BTN_PRO.Location;
                        btn_pro.Name = "BTN_PRO_" + dt_product.Rows[i - 1]["Pro_id"].ToString();
                        btn_pro.Tag = dt_product.Rows[i - 1]["Pro_id"].ToString();
                        btn_pro.Size = BTN_PRO.Size;
                        btn_pro.BackgroundImageLayout = ImageLayout.Stretch;
                        if (dt_product.Rows[i - 1]["Pro_img"] != DBNull.Value)
                            btn_pro.BackgroundImage = Setting.BinarytoImage((Byte[])dt_product.Rows[i - 1]["Pro_img"]);
                        else
                            btn_pro.BackgroundImage = Properties.Resources.DefaultProImg;
                        btn_pro.Click += new EventHandler(ProductClick);

                        // 
                        // LBL_PRO_PRICE1
                        // 
                        Label lbl_pro_price = new Label();
                        lbl_pro_price.Location = LBL_PRO_PRICE.Location;
                        lbl_pro_price.Text = dt_product.Rows[i - 1]["Pro_price"].ToString() + " $";
                        lbl_pro_price.Name = "LBL_PRO_PRICE_" + dt_product.Rows[i - 1]["Pro_id"].ToString();
                        lbl_pro_price.Size = LBL_PRO_PRICE.Size;

                        // 
                        // LBL_PRO_CODE1
                        // 
                        Label lbl_pro_code = new Label();
                        lbl_pro_code.Location = LBL_PRO_CODE.Location;
                        lbl_pro_code.Name = "LBL_PRO_CODE_" + dt_product.Rows[i - 1]["Pro_id"].ToString();
                        lbl_pro_code.Size = LBL_PRO_CODE.Size;
                        lbl_pro_code.Text = dt_product.Rows[i - 1]["Pro_code"].ToString();

                        //
                        // LBL_PRO_NAME
                        //
                        Label lbl_pro_name = new Label();
                        lbl_pro_name.Text = dt_product.Rows[i - 1]["Pro_name_en"].ToString();
                        lbl_pro_name.Location = LBL_PRO_NAME.Location;
                        lbl_pro_name.Name = "LBL_PRO_NAME_" + dt_product.Rows[i - 1]["Pro_id"].ToString();

                        // 
                        // GRB_PRODUCT1
                        // 
                        GroupBox grb_pro = new GroupBox();
                        grb_pro.Name = "GRB_PRO_" + dt_product.Rows[i - 1]["Pro_id"].ToString();
                        grb_pro.Size = GRB_PRODUCT1.Size;
                        grb_pro.Location = new System.Drawing.Point(grb_x, grb_y);

                        grb_pro.Controls.Add(btn_pro);
                        grb_pro.Controls.Add(lbl_pro_code);
                        grb_pro.Controls.Add(lbl_pro_name);
                        grb_pro.Controls.Add(lbl_pro_price);


                        PNL_PRODUCT.Controls.Add(grb_pro);
                        grb_x += GRB_PRODUCT1.Width + width_space;

                        if (i % horizontal_num == 0)
                        {
                            grb_x = 0;
                            grb_y += GRB_PRODUCT1.Height + heigh_space;
                        }
                       

                    }
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Reset all the controls to the user's default Control color.  
        private void ResetAllControlsBackColor(Control control, Color BackColor, Color ForeColor)
        {
            if (control.HasChildren)
            {
                // Recursively call this method for each child control. 
                foreach (Control childControl in control.Controls)
                {
                    childControl.BackColor = BackColor;
                    childControl.ForeColor = ForeColor;
                    ResetAllControlsBackColor(childControl, BackColor, ForeColor);
                }
            }
        }

        int CurrentCagegory = 0;
        int CurParCat = 0;
        private void CategoryClick(object sender, EventArgs e)
        {
            Button btn =  (Button)sender;
            int cat_click_id = Convert.ToInt32(btn.Tag.ToString());
            CurrentCagegory = cat_click_id;
            InitCategory(cat_click_id);
            
        }

        private void InitCategory(int cat_id)
        {
            PNL_PRODUCT.Controls.Clear();
            try
            {
                DataTable dt_category = new DataTable();
                dt_category = DBAccess.OperationGet.Get_by_direct("CATEGORY", "*", "Cat_status=1 and Cat_parent_id=" + cat_id);
                if (dt_category.Rows.Count > 0)
                {
                    CurParCat = cat_id;
                    PNL_CATEGORY.Controls.Clear();

                    int x = 0, y = 0, width_space = 9, heigh_space = 9, horizontal_num = 3;
                    int item = PNL_CATEGORY.Width / (BTN_CAT.Width);
                    for (int i = 1; i <= dt_category.Rows.Count; i++)
                    {

                        // 
                        // BTN_CAT
                        // 
                        Button btn_cat = new Button();
                        btn_cat.BackColor = BTN_CAT.BackColor;
                        btn_cat.FlatStyle = BTN_CAT.FlatStyle;
                        btn_cat.Font = new Font("Microsoft Sans Serif", 12); 
                        btn_cat.Location = new System.Drawing.Point(x, y);
                        btn_cat.Name = "BTN_CAT_" + dt_category.Rows[i - 1]["Cat_id"].ToString();
                        btn_cat.Tag = dt_category.Rows[i - 1]["Cat_id"].ToString();
                        btn_cat.Size = new Size(BTN_CAT.Width, 50);
                        btn_cat.Text = dt_category.Rows[i-1]["Cat_name_en"].ToString();

                        btn_cat.Click += new EventHandler(CategoryClick);

                        PNL_CATEGORY.Controls.Add(btn_cat);
                        x += BTN_CAT.Width + width_space;

                        if (i % item == 0)
                        {
                            x = 0;
                            y += 50 + heigh_space;
                        }
                    }
                }
               
                InitProduct(cat_id);
                
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            
          
        }

        

        private void TIMER1_Tick(object sender, EventArgs e)
        {
            LBL_DATETIME.Text = DateTime.Now.ToString();
        }


        private void PIC_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_NEW_INVOICE_Click(object sender, EventArgs e)
        {
            if (TXT_INVOICE_NO.Text!="")
            {
                DialogResult resultat = MessageBox.Show("Do you really want to add new invoice?", "New Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultat == DialogResult.Yes)
                {
                    INIT_INVOICE();
                }   
            }
            else
            {
                INIT_INVOICE();
            }
        }



        private void INIT_INVOICE()
        {
            if (AddNewInvoice())
            {
                TXT_INVOICE_NO.Clear();
                TXT_INVOICE_DATETIME.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                TXT_BARCODE.Clear();
                DGV_ORDERED_PRODUCT.Rows.Clear();
                TXT_SUB_TOTAL.Text = "0.00";
                TXT_TAX.Text = "0.00";
                TXT_TAX_AMT.Text = "0.00";
                TXT_DIS_PERCENT.Text = "0.00";
                TXT_DIS_AMT.Text = "0.00";
                TXT_GRANT_TOTAL.Text = "0.00";
                TXT_INVOICE_NO.Text = GetInvoiceNumber();
            }

        }

        private bool AddNewInvoice()
        {
            dynamic[] dynamic_field = new dynamic[4];
            dynamic_field[0]="Inv_no";
            dynamic_field[1]="Inv_date";
            dynamic_field[2]="Brh_id";
            dynamic_field[3]="Usr_id";

            int newId = 0;
            newId=DBAccess.OperationInsert.Insert_by_direct_return_id("INVOICE", dynamic_field, GetInvoiceNumber(), DateTime.Now, 1, Properties.Settings.Default.User_id);
            TXT_INVOICE_NO.Tag = newId;

            if (newId>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetInvoiceNumber()
        {
            string inv_num = "";
            DataTable dt_category = new DataTable();
            dt_category = DBAccess.OperationGet.Get_by_direct("INVOICE", " COUNT(Inv_no) as 'count' ", "CONVERT(VARCHAR, Inv_date, 112) = CONVERT(VARCHAR, GETDATE(), 112)");
            if (Convert.ToInt32(dt_category.Rows[0]["count"]) > 0)
            {
                inv_num = DateTime.Now.ToString("yyyyMMddHHmm") + (Convert.ToInt32(dt_category.Rows[0]["count"]) + 1).ToString("D4");
            }
            else
            {
                inv_num = DateTime.Now.ToString("yyyyMMddHHmm") + "0001";
            }
            return inv_num;
        }

        private void BTN_UNPAID_INVOICE_Click(object sender, EventArgs e)
        {
            FRM_UNPAID_INVOICE frm = new FRM_UNPAID_INVOICE();
            frm.Show();
        }

        private void BTN_PRINT_BILL_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CLOSE_INVOICE_Click(object sender, EventArgs e)
        {

        }

        private void BTN_PAYMENT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CAT_BACK_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_category = new DataTable();
                dt_category = DBAccess.OperationGet.Get_by_direct("CATEGORY", "Cat_parent_id", "Cat_status=1 and Cat_id=" + CurParCat);
                if (dt_category.Rows.Count > 0)
                {
                    CurParCat = Convert.ToInt32(dt_category.Rows[0]["Cat_parent_id"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            InitCategory(CurParCat);
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (TXT_INVOICE_NO.Tag.ToString()!="" && DGV_ORDERED_PRODUCT.Rows.Count>0)
            {
                for (int i = 0; i < DGV_ORDERED_PRODUCT.Rows.Count; i++)
                {
                    
                    dynamic dynamic_field = new dynamic[13];
                    dynamic_field[0] = "Inv_id";
                    dynamic_field[1] = "Pro_id";
                    dynamic_field[2] = "Pro_code";
                    dynamic_field[3] = "Pro_name_en";
                    dynamic_field[4] = "Pro_name_kh";
                    dynamic_field[5] = "Ind_qty";
                    dynamic_field[6] = "Ind_price";
                    dynamic_field[7] = "Prn_id";
                    dynamic_field[8] = "Ind_sale_price";
                    dynamic_field[9] = "Usr_id";
                    dynamic_field[10] = "Ind_status";
                    dynamic_field[11] = "Ind_modify_by";
                    dynamic_field[12] = "Ind_modify_date";


                    dynamic dynamic_value = new dynamic[13];
                    dynamic_value[0] = TXT_INVOICE_NO.Tag;
                    dynamic_value[1] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_ID"];
                    dynamic_value[2] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_CODE"];
                    dynamic_value[3] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_NAME_EN"];
                    dynamic_value[4] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_NAME_KH"];
                    dynamic_value[5] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_QTY"];
                    dynamic_value[6] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_PRICE"];
                    dynamic_value[7] = null;
                    dynamic_value[8] = DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_PRO_PRICE"];
                    dynamic_value[9] = Properties.Settings.Default.User_id;
                    dynamic_value[10] = 1;
                    dynamic_value[11] = Properties.Settings.Default.User_id;
                    dynamic_value[12] = DateTime.Now;

                    DBAccess.OperationInsert.Insert_by_Procedure("Ins_InvoiceDetail", dynamic_field, dynamic_value);
                }
            }
        }

        private void TXT_BARCODE_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("enter");
            //TextBox txt = (TextBox)sender;

            //AddProductToGDVByBarcode(txt.Text);

        }

        private void TXT_BARCODE_MouseEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            AddProductToDGVByBarcode(txt.Text);
        }

        private void TXT_BARCODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text!="")
                {
                    AddProductToDGVByBarcode(txt.Text.Trim());
                }
            }
        }

        private void DGV_ORDERED_PRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = DGV_ORDERED_PRODUCT.CurrentCell.ColumnIndex;
            string columnName = DGV_ORDERED_PRODUCT.Columns[columnIndex].Name;
            int rowIndex=DGV_ORDERED_PRODUCT.CurrentCell.RowIndex;

            if (columnName=="DGVBTN_MINUS")
            {
                int qty = Convert.ToInt32(DGV_ORDERED_PRODUCT.Rows[rowIndex].Cells["DGVTXT_QTY"].Value) - 1;
                if (qty>0)
                {
                    DGV_ORDERED_PRODUCT.Rows[rowIndex].Cells["DGVTXT_QTY"].Value = qty;
                }
                else
                {
                    DGV_ORDERED_PRODUCT.Rows.RemoveAt(rowIndex);
                }
            }

            else if (columnName == "DGVBTN_PLUS")
            {
                int qty = Convert.ToInt32(DGV_ORDERED_PRODUCT.Rows[rowIndex].Cells["DGVTXT_QTY"].Value) + 1;
                DGV_ORDERED_PRODUCT.Rows[rowIndex].Cells["DGVTXT_QTY"].Value = qty;
            }

        }

        private void DeleteZeroQtyRows()
        {
            for (int i = 0; i < DGV_ORDERED_PRODUCT.Rows.Count; i++)
            {
                int qty = Convert.ToInt32(DGV_ORDERED_PRODUCT.Rows[i].Cells["DGVTXT_QTY"].Value);
                if (qty == 0)
                {
                    DGV_ORDERED_PRODUCT.Rows.RemoveAt(i);
                }
            }
        }


        private void DGV_ORDERED_PRODUCT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DeleteZeroQtyRows();
        }


    }
}
