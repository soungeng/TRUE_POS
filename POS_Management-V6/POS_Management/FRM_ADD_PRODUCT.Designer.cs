namespace POS_Management
{
    partial class FRM_ADD_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduct = new System.Windows.Forms.Label();
            this.CLB_CATEGORY = new System.Windows.Forms.CheckedListBox();
            this.GRB_PRODUCT = new System.Windows.Forms.GroupBox();
            this.LBL_PRICE_LEVEL_4 = new System.Windows.Forms.Label();
            this.LBL_PRICE_LEVEL_3 = new System.Windows.Forms.Label();
            this.LBL_PRICE_LEVEL_2 = new System.Windows.Forms.Label();
            this.LBL_PRICE_LEVEL_1 = new System.Windows.Forms.Label();
            this.LBL_PRICE = new System.Windows.Forms.Label();
            this.LBL_CATEGORY = new System.Windows.Forms.Label();
            this.LBL_NAME_KH = new System.Windows.Forms.Label();
            this.LBL_NAME_EN = new System.Windows.Forms.Label();
            this.LBL_CODE = new System.Windows.Forms.Label();
            this.LBL_PRO_ID = new System.Windows.Forms.Label();
            this.LBL_ALERT = new System.Windows.Forms.Label();
            this.TXT_ALERT_QTY = new System.Windows.Forms.TextBox();
            this.TXT_PRICE_LEVEL_4 = new System.Windows.Forms.TextBox();
            this.TXT_PRICE_LEVEL_3 = new System.Windows.Forms.TextBox();
            this.TXT_PRICE_LEVEL_2 = new System.Windows.Forms.TextBox();
            this.TXT_PRICE_LEVEL_1 = new System.Windows.Forms.TextBox();
            this.TXT_PRICE = new System.Windows.Forms.TextBox();
            this.TXT_NAME_KH = new System.Windows.Forms.TextBox();
            this.TXT_PRO_NAME_EN = new System.Windows.Forms.TextBox();
            this.TXT_PRO_CODE = new System.Windows.Forms.TextBox();
            this.TXT_PRO_ID = new System.Windows.Forms.TextBox();
            this.PIC_PRO_IMG = new System.Windows.Forms.PictureBox();
            this.CMB_UNIT = new System.Windows.Forms.ComboBox();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_UNIT = new System.Windows.Forms.Label();
            this.CMB_BRAND = new System.Windows.Forms.ComboBox();
            this.LBL_BRAND = new System.Windows.Forms.Label();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.GRB_PRODUCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PRO_IMG)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(261, 27);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(157, 25);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "ADD PRODUCT";
            // 
            // CLB_CATEGORY
            // 
            this.CLB_CATEGORY.FormattingEnabled = true;
            this.CLB_CATEGORY.Location = new System.Drawing.Point(427, 211);
            this.CLB_CATEGORY.Name = "CLB_CATEGORY";
            this.CLB_CATEGORY.Size = new System.Drawing.Size(219, 244);
            this.CLB_CATEGORY.TabIndex = 7;
            // 
            // GRB_PRODUCT
            // 
            this.GRB_PRODUCT.BackColor = System.Drawing.Color.Transparent;
            this.GRB_PRODUCT.Controls.Add(this.BTN_CANCEL);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRICE_LEVEL_4);
            this.GRB_PRODUCT.Controls.Add(this.BTN_SAVE);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRICE_LEVEL_3);
            this.GRB_PRODUCT.Controls.Add(this.BTN_CLEAR);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRICE_LEVEL_2);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRICE_LEVEL_1);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRICE);
            this.GRB_PRODUCT.Controls.Add(this.LBL_CATEGORY);
            this.GRB_PRODUCT.Controls.Add(this.LBL_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.LBL_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.LBL_CODE);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRO_ID);
            this.GRB_PRODUCT.Controls.Add(this.LBL_ALERT);
            this.GRB_PRODUCT.Controls.Add(this.TXT_ALERT_QTY);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE_LEVEL_4);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE_LEVEL_3);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE_LEVEL_2);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE_LEVEL_1);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE);
            this.GRB_PRODUCT.Controls.Add(this.TXT_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRO_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRO_CODE);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRO_ID);
            this.GRB_PRODUCT.Controls.Add(this.PIC_PRO_IMG);
            this.GRB_PRODUCT.Controls.Add(this.CLB_CATEGORY);
            this.GRB_PRODUCT.Controls.Add(this.CMB_UNIT);
            this.GRB_PRODUCT.Controls.Add(this.CMB_STATUS);
            this.GRB_PRODUCT.Controls.Add(this.LBL_UNIT);
            this.GRB_PRODUCT.Controls.Add(this.CMB_BRAND);
            this.GRB_PRODUCT.Controls.Add(this.LBL_BRAND);
            this.GRB_PRODUCT.Controls.Add(this.LBL_STATUS);
            this.GRB_PRODUCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRB_PRODUCT.Location = new System.Drawing.Point(0, 76);
            this.GRB_PRODUCT.Name = "GRB_PRODUCT";
            this.GRB_PRODUCT.Size = new System.Drawing.Size(686, 520);
            this.GRB_PRODUCT.TabIndex = 8;
            this.GRB_PRODUCT.TabStop = false;
            // 
            // LBL_PRICE_LEVEL_4
            // 
            this.LBL_PRICE_LEVEL_4.AutoSize = true;
            this.LBL_PRICE_LEVEL_4.Location = new System.Drawing.Point(27, 326);
            this.LBL_PRICE_LEVEL_4.Name = "LBL_PRICE_LEVEL_4";
            this.LBL_PRICE_LEVEL_4.Size = new System.Drawing.Size(72, 13);
            this.LBL_PRICE_LEVEL_4.TabIndex = 32;
            this.LBL_PRICE_LEVEL_4.Text = "Price Level 4:";
            // 
            // LBL_PRICE_LEVEL_3
            // 
            this.LBL_PRICE_LEVEL_3.AutoSize = true;
            this.LBL_PRICE_LEVEL_3.Location = new System.Drawing.Point(27, 295);
            this.LBL_PRICE_LEVEL_3.Name = "LBL_PRICE_LEVEL_3";
            this.LBL_PRICE_LEVEL_3.Size = new System.Drawing.Size(72, 13);
            this.LBL_PRICE_LEVEL_3.TabIndex = 31;
            this.LBL_PRICE_LEVEL_3.Text = "Price Level 3:";
            // 
            // LBL_PRICE_LEVEL_2
            // 
            this.LBL_PRICE_LEVEL_2.AutoSize = true;
            this.LBL_PRICE_LEVEL_2.Location = new System.Drawing.Point(27, 262);
            this.LBL_PRICE_LEVEL_2.Name = "LBL_PRICE_LEVEL_2";
            this.LBL_PRICE_LEVEL_2.Size = new System.Drawing.Size(72, 13);
            this.LBL_PRICE_LEVEL_2.TabIndex = 30;
            this.LBL_PRICE_LEVEL_2.Text = "Price Level 2:";
            // 
            // LBL_PRICE_LEVEL_1
            // 
            this.LBL_PRICE_LEVEL_1.AutoSize = true;
            this.LBL_PRICE_LEVEL_1.Location = new System.Drawing.Point(27, 229);
            this.LBL_PRICE_LEVEL_1.Name = "LBL_PRICE_LEVEL_1";
            this.LBL_PRICE_LEVEL_1.Size = new System.Drawing.Size(72, 13);
            this.LBL_PRICE_LEVEL_1.TabIndex = 29;
            this.LBL_PRICE_LEVEL_1.Text = "Price Level 1:";
            // 
            // LBL_PRICE
            // 
            this.LBL_PRICE.AutoSize = true;
            this.LBL_PRICE.Location = new System.Drawing.Point(27, 193);
            this.LBL_PRICE.Name = "LBL_PRICE";
            this.LBL_PRICE.Size = new System.Drawing.Size(34, 13);
            this.LBL_PRICE.TabIndex = 28;
            this.LBL_PRICE.Text = "Price:";
            // 
            // LBL_CATEGORY
            // 
            this.LBL_CATEGORY.AutoSize = true;
            this.LBL_CATEGORY.Location = new System.Drawing.Point(439, 195);
            this.LBL_CATEGORY.Name = "LBL_CATEGORY";
            this.LBL_CATEGORY.Size = new System.Drawing.Size(52, 13);
            this.LBL_CATEGORY.TabIndex = 27;
            this.LBL_CATEGORY.Text = "Category:";
            // 
            // LBL_NAME_KH
            // 
            this.LBL_NAME_KH.AutoSize = true;
            this.LBL_NAME_KH.Location = new System.Drawing.Point(27, 161);
            this.LBL_NAME_KH.Name = "LBL_NAME_KH";
            this.LBL_NAME_KH.Size = new System.Drawing.Size(54, 13);
            this.LBL_NAME_KH.TabIndex = 26;
            this.LBL_NAME_KH.Text = "Name Kh:";
            // 
            // LBL_NAME_EN
            // 
            this.LBL_NAME_EN.AutoSize = true;
            this.LBL_NAME_EN.Location = new System.Drawing.Point(27, 126);
            this.LBL_NAME_EN.Name = "LBL_NAME_EN";
            this.LBL_NAME_EN.Size = new System.Drawing.Size(54, 13);
            this.LBL_NAME_EN.TabIndex = 25;
            this.LBL_NAME_EN.Text = "Name En:";
            // 
            // LBL_CODE
            // 
            this.LBL_CODE.AutoSize = true;
            this.LBL_CODE.Location = new System.Drawing.Point(27, 93);
            this.LBL_CODE.Name = "LBL_CODE";
            this.LBL_CODE.Size = new System.Drawing.Size(38, 13);
            this.LBL_CODE.TabIndex = 24;
            this.LBL_CODE.Text = "Code: ";
            // 
            // LBL_PRO_ID
            // 
            this.LBL_PRO_ID.AutoSize = true;
            this.LBL_PRO_ID.Location = new System.Drawing.Point(27, 29);
            this.LBL_PRO_ID.Name = "LBL_PRO_ID";
            this.LBL_PRO_ID.Size = new System.Drawing.Size(18, 13);
            this.LBL_PRO_ID.TabIndex = 23;
            this.LBL_PRO_ID.Text = "ID";
            // 
            // LBL_ALERT
            // 
            this.LBL_ALERT.AutoSize = true;
            this.LBL_ALERT.Location = new System.Drawing.Point(25, 60);
            this.LBL_ALERT.Name = "LBL_ALERT";
            this.LBL_ALERT.Size = new System.Drawing.Size(70, 13);
            this.LBL_ALERT.TabIndex = 23;
            this.LBL_ALERT.Text = "Alert Quantity";
            // 
            // TXT_ALERT_QTY
            // 
            this.TXT_ALERT_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ALERT_QTY.Location = new System.Drawing.Point(131, 57);
            this.TXT_ALERT_QTY.Name = "TXT_ALERT_QTY";
            this.TXT_ALERT_QTY.Size = new System.Drawing.Size(263, 26);
            this.TXT_ALERT_QTY.TabIndex = 22;
            // 
            // TXT_PRICE_LEVEL_4
            // 
            this.TXT_PRICE_LEVEL_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE_LEVEL_4.Location = new System.Drawing.Point(131, 322);
            this.TXT_PRICE_LEVEL_4.Name = "TXT_PRICE_LEVEL_4";
            this.TXT_PRICE_LEVEL_4.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRICE_LEVEL_4.TabIndex = 20;
            // 
            // TXT_PRICE_LEVEL_3
            // 
            this.TXT_PRICE_LEVEL_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE_LEVEL_3.Location = new System.Drawing.Point(131, 289);
            this.TXT_PRICE_LEVEL_3.Name = "TXT_PRICE_LEVEL_3";
            this.TXT_PRICE_LEVEL_3.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRICE_LEVEL_3.TabIndex = 19;
            // 
            // TXT_PRICE_LEVEL_2
            // 
            this.TXT_PRICE_LEVEL_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE_LEVEL_2.Location = new System.Drawing.Point(131, 256);
            this.TXT_PRICE_LEVEL_2.Name = "TXT_PRICE_LEVEL_2";
            this.TXT_PRICE_LEVEL_2.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRICE_LEVEL_2.TabIndex = 18;
            // 
            // TXT_PRICE_LEVEL_1
            // 
            this.TXT_PRICE_LEVEL_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE_LEVEL_1.Location = new System.Drawing.Point(131, 222);
            this.TXT_PRICE_LEVEL_1.Name = "TXT_PRICE_LEVEL_1";
            this.TXT_PRICE_LEVEL_1.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRICE_LEVEL_1.TabIndex = 17;
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE.Location = new System.Drawing.Point(131, 189);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRICE.TabIndex = 16;
            // 
            // TXT_NAME_KH
            // 
            this.TXT_NAME_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NAME_KH.Location = new System.Drawing.Point(131, 156);
            this.TXT_NAME_KH.Name = "TXT_NAME_KH";
            this.TXT_NAME_KH.Size = new System.Drawing.Size(263, 26);
            this.TXT_NAME_KH.TabIndex = 15;
            // 
            // TXT_PRO_NAME_EN
            // 
            this.TXT_PRO_NAME_EN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRO_NAME_EN.Location = new System.Drawing.Point(131, 123);
            this.TXT_PRO_NAME_EN.Name = "TXT_PRO_NAME_EN";
            this.TXT_PRO_NAME_EN.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRO_NAME_EN.TabIndex = 14;
            // 
            // TXT_PRO_CODE
            // 
            this.TXT_PRO_CODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRO_CODE.Location = new System.Drawing.Point(131, 90);
            this.TXT_PRO_CODE.Name = "TXT_PRO_CODE";
            this.TXT_PRO_CODE.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRO_CODE.TabIndex = 13;
            // 
            // TXT_PRO_ID
            // 
            this.TXT_PRO_ID.Enabled = false;
            this.TXT_PRO_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRO_ID.Location = new System.Drawing.Point(131, 24);
            this.TXT_PRO_ID.Name = "TXT_PRO_ID";
            this.TXT_PRO_ID.Size = new System.Drawing.Size(263, 26);
            this.TXT_PRO_ID.TabIndex = 21;
            // 
            // PIC_PRO_IMG
            // 
            this.PIC_PRO_IMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PIC_PRO_IMG.Location = new System.Drawing.Point(427, 24);
            this.PIC_PRO_IMG.Name = "PIC_PRO_IMG";
            this.PIC_PRO_IMG.Size = new System.Drawing.Size(219, 161);
            this.PIC_PRO_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_PRO_IMG.TabIndex = 12;
            this.PIC_PRO_IMG.TabStop = false;
            this.PIC_PRO_IMG.DoubleClick += new System.EventHandler(this.PIC_PRO_IMG_DoubleClick);
            // 
            // CMB_UNIT
            // 
            this.CMB_UNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_UNIT.FormattingEnabled = true;
            this.CMB_UNIT.Location = new System.Drawing.Point(131, 354);
            this.CMB_UNIT.Name = "CMB_UNIT";
            this.CMB_UNIT.Size = new System.Drawing.Size(265, 28);
            this.CMB_UNIT.TabIndex = 9;
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(133, 422);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(265, 28);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // LBL_UNIT
            // 
            this.LBL_UNIT.AutoSize = true;
            this.LBL_UNIT.Location = new System.Drawing.Point(25, 360);
            this.LBL_UNIT.Name = "LBL_UNIT";
            this.LBL_UNIT.Size = new System.Drawing.Size(29, 13);
            this.LBL_UNIT.TabIndex = 6;
            this.LBL_UNIT.Text = "Unit:";
            // 
            // CMB_BRAND
            // 
            this.CMB_BRAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_BRAND.FormattingEnabled = true;
            this.CMB_BRAND.Location = new System.Drawing.Point(131, 388);
            this.CMB_BRAND.Name = "CMB_BRAND";
            this.CMB_BRAND.Size = new System.Drawing.Size(265, 28);
            this.CMB_BRAND.TabIndex = 11;
            // 
            // LBL_BRAND
            // 
            this.LBL_BRAND.AutoSize = true;
            this.LBL_BRAND.Location = new System.Drawing.Point(25, 391);
            this.LBL_BRAND.Name = "LBL_BRAND";
            this.LBL_BRAND.Size = new System.Drawing.Size(38, 13);
            this.LBL_BRAND.TabIndex = 7;
            this.LBL_BRAND.Text = "Brand:";
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(25, 426);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 8;
            this.LBL_STATUS.Text = "Status:";
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR.Location = new System.Drawing.Point(333, 475);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(94, 33);
            this.BTN_CLEAR.TabIndex = 9;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(443, 475);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(94, 33);
            this.BTN_SAVE.TabIndex = 9;
            this.BTN_SAVE.Text = "ADD";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(552, 475);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(94, 33);
            this.BTN_CANCEL.TabIndex = 9;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblProduct);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(686, 76);
            this.pnlTitle.TabIndex = 9;
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(686, 596);
            this.Controls.Add(this.GRB_PRODUCT);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD_PRODUCT";
            this.Load += new System.EventHandler(this.FRM_ADD_PRODUCT_Load);
            this.GRB_PRODUCT.ResumeLayout(false);
            this.GRB_PRODUCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PRO_IMG)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.CheckedListBox CLB_CATEGORY;
        private System.Windows.Forms.GroupBox GRB_PRODUCT;
        private System.Windows.Forms.ComboBox CMB_UNIT;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_UNIT;
        private System.Windows.Forms.ComboBox CMB_BRAND;
        private System.Windows.Forms.Label LBL_BRAND;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Label LBL_PRICE_LEVEL_4;
        private System.Windows.Forms.Label LBL_PRICE_LEVEL_3;
        private System.Windows.Forms.Label LBL_PRICE_LEVEL_2;
        private System.Windows.Forms.Label LBL_PRICE_LEVEL_1;
        private System.Windows.Forms.Label LBL_PRICE;
        private System.Windows.Forms.Label LBL_CATEGORY;
        private System.Windows.Forms.Label LBL_NAME_KH;
        private System.Windows.Forms.Label LBL_NAME_EN;
        private System.Windows.Forms.Label LBL_CODE;
        private System.Windows.Forms.Label LBL_ALERT;
        private System.Windows.Forms.TextBox TXT_ALERT_QTY;
        private System.Windows.Forms.TextBox TXT_PRICE_LEVEL_4;
        private System.Windows.Forms.TextBox TXT_PRICE_LEVEL_3;
        private System.Windows.Forms.TextBox TXT_PRICE_LEVEL_2;
        private System.Windows.Forms.TextBox TXT_PRICE_LEVEL_1;
        private System.Windows.Forms.TextBox TXT_PRICE;
        private System.Windows.Forms.TextBox TXT_NAME_KH;
        private System.Windows.Forms.TextBox TXT_PRO_NAME_EN;
        private System.Windows.Forms.TextBox TXT_PRO_CODE;
        private System.Windows.Forms.TextBox TXT_PRO_ID;
        private System.Windows.Forms.PictureBox PIC_PRO_IMG;
        private System.Windows.Forms.Label LBL_PRO_ID;
        private System.Windows.Forms.Panel pnlTitle;
    }
}