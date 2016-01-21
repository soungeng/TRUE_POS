namespace POS_Management
{
    partial class FRM_BRAND
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
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.GRB_BRAND_SEARCH = new System.Windows.Forms.GroupBox();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.LBL_SEARCH_NAME = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.DGV_CATEGORY = new System.Windows.Forms.DataGridView();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_NAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_NAME_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LBL_BRAND_LIST = new System.Windows.Forms.Label();
            this.BTN_BRAND = new System.Windows.Forms.Button();
            this.BTN_CATEGORY = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_PRODUCT = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.GRB_BRAND_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORY)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(239, 29);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 9;
            this.LBL_STATUS.Text = "Status:";
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(290, 26);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(121, 21);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // GRB_BRAND_SEARCH
            // 
            this.GRB_BRAND_SEARCH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRB_BRAND_SEARCH.Controls.Add(this.CMB_STATUS);
            this.GRB_BRAND_SEARCH.Controls.Add(this.LBL_STATUS);
            this.GRB_BRAND_SEARCH.Controls.Add(this.LBL_SEARCH_NAME);
            this.GRB_BRAND_SEARCH.Controls.Add(this.TXT_NAME);
            this.GRB_BRAND_SEARCH.Location = new System.Drawing.Point(483, 78);
            this.GRB_BRAND_SEARCH.Name = "GRB_BRAND_SEARCH";
            this.GRB_BRAND_SEARCH.Size = new System.Drawing.Size(521, 63);
            this.GRB_BRAND_SEARCH.TabIndex = 25;
            this.GRB_BRAND_SEARCH.TabStop = false;
            this.GRB_BRAND_SEARCH.Text = "Search Option";
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SEARCH_PRODUCT.BackColor = System.Drawing.Color.Red;
            this.BTN_SEARCH_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(976, 0);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(48, 41);
            this.BTN_SEARCH_PRODUCT.TabIndex = 8;
            this.BTN_SEARCH_PRODUCT.Text = "X";
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_SEARCH_PRODUCT.Click += new System.EventHandler(this.BTN_SEARCH_PRODUCT_Click);
            // 
            // LBL_SEARCH_NAME
            // 
            this.LBL_SEARCH_NAME.AutoSize = true;
            this.LBL_SEARCH_NAME.Location = new System.Drawing.Point(24, 29);
            this.LBL_SEARCH_NAME.Name = "LBL_SEARCH_NAME";
            this.LBL_SEARCH_NAME.Size = new System.Drawing.Size(41, 13);
            this.LBL_SEARCH_NAME.TabIndex = 5;
            this.LBL_SEARCH_NAME.Text = "Name: ";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(72, 25);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(147, 20);
            this.TXT_NAME.TabIndex = 6;
            // 
            // DGV_CATEGORY
            // 
            this.DGV_CATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_CATEGORY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_CATEGORY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_CATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_CATEGORY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCMB_PRODUCT,
            this.DGVTXT_ID,
            this.DGVTXT_NAME_EN,
            this.DGVTXT_NAME_KH,
            this.DGVTXT_STATUS,
            this.DGVBTN_EDIT,
            this.DGVBTN_DELETE});
            this.DGV_CATEGORY.Location = new System.Drawing.Point(143, 160);
            this.DGV_CATEGORY.Name = "DGV_CATEGORY";
            this.DGV_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_CATEGORY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_CATEGORY.RowHeadersVisible = false;
            this.DGV_CATEGORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORY.Size = new System.Drawing.Size(863, 580);
            this.DGV_CATEGORY.TabIndex = 26;
            // 
            // DGVCMB_PRODUCT
            // 
            this.DGVCMB_PRODUCT.HeaderText = "Check";
            this.DGVCMB_PRODUCT.Name = "DGVCMB_PRODUCT";
            this.DGVCMB_PRODUCT.Width = 50;
            // 
            // DGVTXT_ID
            // 
            this.DGVTXT_ID.HeaderText = "ID";
            this.DGVTXT_ID.Name = "DGVTXT_ID";
            this.DGVTXT_ID.Width = 90;
            // 
            // DGVTXT_NAME_EN
            // 
            this.DGVTXT_NAME_EN.HeaderText = "NAME EN";
            this.DGVTXT_NAME_EN.Name = "DGVTXT_NAME_EN";
            this.DGVTXT_NAME_EN.Width = 250;
            // 
            // DGVTXT_NAME_KH
            // 
            this.DGVTXT_NAME_KH.HeaderText = "NAME_KH";
            this.DGVTXT_NAME_KH.Name = "DGVTXT_NAME_KH";
            this.DGVTXT_NAME_KH.Width = 250;
            // 
            // DGVTXT_STATUS
            // 
            this.DGVTXT_STATUS.HeaderText = "STATUS";
            this.DGVTXT_STATUS.Name = "DGVTXT_STATUS";
            this.DGVTXT_STATUS.Width = 95;
            // 
            // DGVBTN_EDIT
            // 
            this.DGVBTN_EDIT.HeaderText = "EDIT";
            this.DGVBTN_EDIT.Name = "DGVBTN_EDIT";
            this.DGVBTN_EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_EDIT.Width = 60;
            // 
            // DGVBTN_DELETE
            // 
            this.DGVBTN_DELETE.HeaderText = "DELETE";
            this.DGVBTN_DELETE.Name = "DGVBTN_DELETE";
            this.DGVBTN_DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_DELETE.Width = 60;
            // 
            // LBL_BRAND_LIST
            // 
            this.LBL_BRAND_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_BRAND_LIST.AutoSize = true;
            this.LBL_BRAND_LIST.Location = new System.Drawing.Point(387, 28);
            this.LBL_BRAND_LIST.Name = "LBL_BRAND_LIST";
            this.LBL_BRAND_LIST.Size = new System.Drawing.Size(71, 13);
            this.LBL_BRAND_LIST.TabIndex = 24;
            this.LBL_BRAND_LIST.Text = "BRAND LIST";
            // 
            // BTN_BRAND
            // 
            this.BTN_BRAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_BRAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BRAND.Location = new System.Drawing.Point(19, 191);
            this.BTN_BRAND.Name = "BTN_BRAND";
            this.BTN_BRAND.Size = new System.Drawing.Size(94, 33);
            this.BTN_BRAND.TabIndex = 23;
            this.BTN_BRAND.Text = "BRAND";
            this.BTN_BRAND.UseVisualStyleBackColor = false;
            // 
            // BTN_CATEGORY
            // 
            this.BTN_CATEGORY.BackColor = System.Drawing.Color.White;
            this.BTN_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CATEGORY.Location = new System.Drawing.Point(19, 151);
            this.BTN_CATEGORY.Name = "BTN_CATEGORY";
            this.BTN_CATEGORY.Size = new System.Drawing.Size(94, 33);
            this.BTN_CATEGORY.TabIndex = 22;
            this.BTN_CATEGORY.Text = "CATEGORY";
            this.BTN_CATEGORY.UseVisualStyleBackColor = false;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(143, 118);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 19;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Location = new System.Drawing.Point(143, 88);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(63, 23);
            this.BTN_ADD.TabIndex = 20;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_PRODUCT
            // 
            this.BTN_PRODUCT.BackColor = System.Drawing.Color.White;
            this.BTN_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCT.Location = new System.Drawing.Point(19, 109);
            this.BTN_PRODUCT.Name = "BTN_PRODUCT";
            this.BTN_PRODUCT.Size = new System.Drawing.Size(94, 33);
            this.BTN_PRODUCT.TabIndex = 21;
            this.BTN_PRODUCT.Text = "PRODUCT";
            this.BTN_PRODUCT.UseVisualStyleBackColor = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 128;
            this.lineShape1.X2 = 128;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 742;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 768);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // FRM_BRAND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.Controls.Add(this.GRB_BRAND_SEARCH);
            this.Controls.Add(this.DGV_CATEGORY);
            this.Controls.Add(this.LBL_BRAND_LIST);
            this.Controls.Add(this.BTN_BRAND);
            this.Controls.Add(this.BTN_CATEGORY);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_PRODUCT);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BRAND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_BRAND";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GRB_BRAND_SEARCH.ResumeLayout(false);
            this.GRB_BRAND_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.GroupBox GRB_BRAND_SEARCH;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.Label LBL_SEARCH_NAME;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.DataGridView DGV_CATEGORY;
        private System.Windows.Forms.Label LBL_BRAND_LIST;
        private System.Windows.Forms.Button BTN_BRAND;
        private System.Windows.Forms.Button BTN_CATEGORY;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_PRODUCT;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_NAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_NAME_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_STATUS;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
    }
}