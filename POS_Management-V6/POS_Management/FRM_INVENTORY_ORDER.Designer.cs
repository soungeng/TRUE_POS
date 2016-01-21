namespace POS_Management
{
    partial class FRM_INVENTORY_ORDER
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
            this.GRB_ORDER_SEARCH = new System.Windows.Forms.GroupBox();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.LBL_ORDER_NUM = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.LBL_INVENTORY_ORDER_LIST = new System.Windows.Forms.Label();
            this.BTN_PERCHASE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_ORDER = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_ORDER_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_VENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_TOTAL_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DTP_ORDER_DATE = new System.Windows.Forms.DateTimePicker();
            this.LBL_ORDER_DATE = new System.Windows.Forms.Label();
            this.LBL_VENDOR = new System.Windows.Forms.Label();
            this.CMB_VENDOR = new System.Windows.Forms.ComboBox();
            this.GRB_ORDER_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // GRB_ORDER_SEARCH
            // 
            this.GRB_ORDER_SEARCH.Controls.Add(this.DTP_ORDER_DATE);
            this.GRB_ORDER_SEARCH.Controls.Add(this.CMB_VENDOR);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_VENDOR);
            this.GRB_ORDER_SEARCH.Controls.Add(this.CMB_STATUS);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_STATUS);
            this.GRB_ORDER_SEARCH.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_ORDER_DATE);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_ORDER_NUM);
            this.GRB_ORDER_SEARCH.Controls.Add(this.TXT_NAME);
            this.GRB_ORDER_SEARCH.Location = new System.Drawing.Point(430, 58);
            this.GRB_ORDER_SEARCH.Name = "GRB_ORDER_SEARCH";
            this.GRB_ORDER_SEARCH.Size = new System.Drawing.Size(573, 83);
            this.GRB_ORDER_SEARCH.TabIndex = 33;
            this.GRB_ORDER_SEARCH.TabStop = false;
            this.GRB_ORDER_SEARCH.Text = "Search Option";
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(347, 52);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(121, 21);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(296, 55);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 9;
            this.LBL_STATUS.Text = "Status:";
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(488, 24);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(63, 23);
            this.BTN_SEARCH_PRODUCT.TabIndex = 8;
            this.BTN_SEARCH_PRODUCT.Text = "Search";
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = true;
            // 
            // LBL_ORDER_NUM
            // 
            this.LBL_ORDER_NUM.AutoSize = true;
            this.LBL_ORDER_NUM.Location = new System.Drawing.Point(24, 29);
            this.LBL_ORDER_NUM.Name = "LBL_ORDER_NUM";
            this.LBL_ORDER_NUM.Size = new System.Drawing.Size(76, 13);
            this.LBL_ORDER_NUM.TabIndex = 5;
            this.LBL_ORDER_NUM.Text = "Order Number:";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(107, 25);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(147, 20);
            this.TXT_NAME.TabIndex = 6;
            // 
            // DGV_ORDER
            // 
            this.DGV_ORDER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ORDER.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_ORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_ORDER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCMB_PRODUCT,
            this.DGVTXT_ID,
            this.DGVTXT_ORDER_NUM,
            this.DGVTXT_ORDER_DATE,
            this.DGVTXT_VENDER,
            this.DGVTXT_TOTAL_AMT,
            this.DGVTXT_STATUS,
            this.DGVBTN_EDIT,
            this.DGVBTN_DELETE});
            this.DGV_ORDER.Location = new System.Drawing.Point(143, 160);
            this.DGV_ORDER.Name = "DGV_ORDER";
            this.DGV_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.RowHeadersVisible = false;
            this.DGV_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDER.Size = new System.Drawing.Size(863, 580);
            this.DGV_ORDER.TabIndex = 34;
            // 
            // LBL_INVENTORY_ORDER_LIST
            // 
            this.LBL_INVENTORY_ORDER_LIST.AutoSize = true;
            this.LBL_INVENTORY_ORDER_LIST.Location = new System.Drawing.Point(392, 19);
            this.LBL_INVENTORY_ORDER_LIST.Name = "LBL_INVENTORY_ORDER_LIST";
            this.LBL_INVENTORY_ORDER_LIST.Size = new System.Drawing.Size(138, 13);
            this.LBL_INVENTORY_ORDER_LIST.TabIndex = 32;
            this.LBL_INVENTORY_ORDER_LIST.Text = "INVENTORY ORDER LIST";
            // 
            // BTN_PERCHASE
            // 
            this.BTN_PERCHASE.BackColor = System.Drawing.Color.White;
            this.BTN_PERCHASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PERCHASE.Location = new System.Drawing.Point(19, 151);
            this.BTN_PERCHASE.Name = "BTN_PERCHASE";
            this.BTN_PERCHASE.Size = new System.Drawing.Size(94, 33);
            this.BTN_PERCHASE.TabIndex = 30;
            this.BTN_PERCHASE.Text = "PERCHASE";
            this.BTN_PERCHASE.UseVisualStyleBackColor = false;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Location = new System.Drawing.Point(143, 88);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(63, 23);
            this.BTN_ADD.TabIndex = 28;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_ORDER
            // 
            this.BTN_ORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ORDER.Location = new System.Drawing.Point(19, 109);
            this.BTN_ORDER.Name = "BTN_ORDER";
            this.BTN_ORDER.Size = new System.Drawing.Size(94, 33);
            this.BTN_ORDER.TabIndex = 29;
            this.BTN_ORDER.Text = "ORDER";
            this.BTN_ORDER.UseVisualStyleBackColor = false;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(143, 118);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 27;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 127;
            this.lineShape1.X2 = 127;
            this.lineShape1.Y1 = 45;
            this.lineShape1.Y2 = 737;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1024, 768);
            this.shapeContainer2.TabIndex = 35;
            this.shapeContainer2.TabStop = false;
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
            this.DGVTXT_ID.Width = 70;
            // 
            // DGVTXT_ORDER_NUM
            // 
            this.DGVTXT_ORDER_NUM.HeaderText = "ORDER NUMBER";
            this.DGVTXT_ORDER_NUM.Name = "DGVTXT_ORDER_NUM";
            this.DGVTXT_ORDER_NUM.Width = 120;
            // 
            // DGVTXT_ORDER_DATE
            // 
            this.DGVTXT_ORDER_DATE.HeaderText = "ORDER DATE";
            this.DGVTXT_ORDER_DATE.Name = "DGVTXT_ORDER_DATE";
            this.DGVTXT_ORDER_DATE.Width = 150;
            // 
            // DGVTXT_VENDER
            // 
            this.DGVTXT_VENDER.HeaderText = "VENDER";
            this.DGVTXT_VENDER.Name = "DGVTXT_VENDER";
            this.DGVTXT_VENDER.Width = 150;
            // 
            // DGVTXT_TOTAL_AMT
            // 
            this.DGVTXT_TOTAL_AMT.HeaderText = "TOTAL AMOUNT";
            this.DGVTXT_TOTAL_AMT.Name = "DGVTXT_TOTAL_AMT";
            this.DGVTXT_TOTAL_AMT.Width = 120;
            // 
            // DGVTXT_STATUS
            // 
            this.DGVTXT_STATUS.HeaderText = "STATUS";
            this.DGVTXT_STATUS.Name = "DGVTXT_STATUS";
            this.DGVTXT_STATUS.Width = 80;
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
            // DTP_ORDER_DATE
            // 
            this.DTP_ORDER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_ORDER_DATE.Location = new System.Drawing.Point(107, 52);
            this.DTP_ORDER_DATE.Name = "DTP_ORDER_DATE";
            this.DTP_ORDER_DATE.Size = new System.Drawing.Size(147, 20);
            this.DTP_ORDER_DATE.TabIndex = 11;
            this.DTP_ORDER_DATE.Value = new System.DateTime(2016, 1, 11, 15, 33, 35, 0);
            // 
            // LBL_ORDER_DATE
            // 
            this.LBL_ORDER_DATE.AutoSize = true;
            this.LBL_ORDER_DATE.Location = new System.Drawing.Point(24, 55);
            this.LBL_ORDER_DATE.Name = "LBL_ORDER_DATE";
            this.LBL_ORDER_DATE.Size = new System.Drawing.Size(62, 13);
            this.LBL_ORDER_DATE.TabIndex = 5;
            this.LBL_ORDER_DATE.Text = "Order Date:";
            // 
            // LBL_VENDOR
            // 
            this.LBL_VENDOR.AutoSize = true;
            this.LBL_VENDOR.Location = new System.Drawing.Point(296, 28);
            this.LBL_VENDOR.Name = "LBL_VENDOR";
            this.LBL_VENDOR.Size = new System.Drawing.Size(44, 13);
            this.LBL_VENDOR.TabIndex = 9;
            this.LBL_VENDOR.Text = "Vendor:";
            // 
            // CMB_VENDOR
            // 
            this.CMB_VENDOR.FormattingEnabled = true;
            this.CMB_VENDOR.Location = new System.Drawing.Point(347, 25);
            this.CMB_VENDOR.Name = "CMB_VENDOR";
            this.CMB_VENDOR.Size = new System.Drawing.Size(121, 21);
            this.CMB_VENDOR.TabIndex = 10;
            // 
            // FRM_INVENTORY_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.GRB_ORDER_SEARCH);
            this.Controls.Add(this.DGV_ORDER);
            this.Controls.Add(this.LBL_INVENTORY_ORDER_LIST);
            this.Controls.Add(this.BTN_PERCHASE);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_ORDER);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_INVENTORY_ORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_INVENTORY_ORDER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GRB_ORDER_SEARCH.ResumeLayout(false);
            this.GRB_ORDER_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRB_ORDER_SEARCH;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.Label LBL_ORDER_NUM;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.Label LBL_INVENTORY_ORDER_LIST;
        private System.Windows.Forms.Button BTN_PERCHASE;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_ORDER;
        private System.Windows.Forms.Button BTN_DELETE;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ORDER_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_VENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_TOTAL_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_STATUS;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
        private System.Windows.Forms.DateTimePicker DTP_ORDER_DATE;
        private System.Windows.Forms.Label LBL_ORDER_DATE;
        private System.Windows.Forms.ComboBox CMB_VENDOR;
        private System.Windows.Forms.Label LBL_VENDOR;
    }
}