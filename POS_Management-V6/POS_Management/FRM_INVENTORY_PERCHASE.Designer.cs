namespace POS_Management
{
    partial class FRM_INVENTORY_PERCHASE
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
            this.DTP_ORDER_DATE = new System.Windows.Forms.DateTimePicker();
            this.CMB_VENDOR = new System.Windows.Forms.ComboBox();
            this.LBL_ORDER_DATE = new System.Windows.Forms.Label();
            this.LBL_VENDOR = new System.Windows.Forms.Label();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.LBL_INVENTORY_PERCHASE_LIST = new System.Windows.Forms.Label();
            this.BTN_PERCHASE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_ORDER = new System.Windows.Forms.Button();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.LBL_PERCHASE_NUM = new System.Windows.Forms.Label();
            this.TXT_PERCHASE_NUM = new System.Windows.Forms.TextBox();
            this.GRB_ORDER_SEARCH = new System.Windows.Forms.GroupBox();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TXT_ORDER_NUM = new System.Windows.Forms.TextBox();
            this.LBL_ORDER_NUM = new System.Windows.Forms.Label();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_PERCHASE_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_ORDER_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_PERCHASE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_VENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_TOTAL_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.GRB_ORDER_SEARCH.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_ORDER_DATE
            // 
            this.DTP_ORDER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_ORDER_DATE.Location = new System.Drawing.Point(126, 52);
            this.DTP_ORDER_DATE.Name = "DTP_ORDER_DATE";
            this.DTP_ORDER_DATE.Size = new System.Drawing.Size(147, 20);
            this.DTP_ORDER_DATE.TabIndex = 11;
            this.DTP_ORDER_DATE.Value = new System.DateTime(2016, 1, 11, 15, 33, 35, 0);
            // 
            // CMB_VENDOR
            // 
            this.CMB_VENDOR.FormattingEnabled = true;
            this.CMB_VENDOR.Location = new System.Drawing.Point(368, 25);
            this.CMB_VENDOR.Name = "CMB_VENDOR";
            this.CMB_VENDOR.Size = new System.Drawing.Size(121, 21);
            this.CMB_VENDOR.TabIndex = 10;
            // 
            // LBL_ORDER_DATE
            // 
            this.LBL_ORDER_DATE.AutoSize = true;
            this.LBL_ORDER_DATE.Location = new System.Drawing.Point(24, 55);
            this.LBL_ORDER_DATE.Name = "LBL_ORDER_DATE";
            this.LBL_ORDER_DATE.Size = new System.Drawing.Size(81, 13);
            this.LBL_ORDER_DATE.TabIndex = 5;
            this.LBL_ORDER_DATE.Text = "Perchase Date:";
            // 
            // LBL_VENDOR
            // 
            this.LBL_VENDOR.AutoSize = true;
            this.LBL_VENDOR.Location = new System.Drawing.Point(287, 28);
            this.LBL_VENDOR.Name = "LBL_VENDOR";
            this.LBL_VENDOR.Size = new System.Drawing.Size(44, 13);
            this.LBL_VENDOR.TabIndex = 9;
            this.LBL_VENDOR.Text = "Vendor:";
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
            this.DGVTXT_PERCHASE_NUM,
            this.DGVTXT_ORDER_NUMBER,
            this.DGVTXT_PERCHASE_DATE,
            this.DGVTXT_VENDER,
            this.DGVTXT_TOTAL_AMT,
            this.DGVTXT_STATUS,
            this.DGVBTN_EDIT,
            this.DGVBTN_DELETE});
            this.DGV_ORDER.Location = new System.Drawing.Point(143, 165);
            this.DGV_ORDER.Name = "DGV_ORDER";
            this.DGV_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.RowHeadersVisible = false;
            this.DGV_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDER.Size = new System.Drawing.Size(863, 580);
            this.DGV_ORDER.TabIndex = 41;
            // 
            // LBL_INVENTORY_PERCHASE_LIST
            // 
            this.LBL_INVENTORY_PERCHASE_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_INVENTORY_PERCHASE_LIST.AutoSize = true;
            this.LBL_INVENTORY_PERCHASE_LIST.Location = new System.Drawing.Point(392, 24);
            this.LBL_INVENTORY_PERCHASE_LIST.Name = "LBL_INVENTORY_PERCHASE_LIST";
            this.LBL_INVENTORY_PERCHASE_LIST.Size = new System.Drawing.Size(157, 13);
            this.LBL_INVENTORY_PERCHASE_LIST.TabIndex = 39;
            this.LBL_INVENTORY_PERCHASE_LIST.Text = "INVENTORY PERCHASE LIST";
            // 
            // BTN_PERCHASE
            // 
            this.BTN_PERCHASE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_PERCHASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PERCHASE.Location = new System.Drawing.Point(19, 156);
            this.BTN_PERCHASE.Name = "BTN_PERCHASE";
            this.BTN_PERCHASE.Size = new System.Drawing.Size(94, 33);
            this.BTN_PERCHASE.TabIndex = 38;
            this.BTN_PERCHASE.Text = "PERCHASE";
            this.BTN_PERCHASE.UseVisualStyleBackColor = false;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Location = new System.Drawing.Point(143, 99);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(63, 23);
            this.BTN_ADD.TabIndex = 36;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // BTN_ORDER
            // 
            this.BTN_ORDER.BackColor = System.Drawing.Color.White;
            this.BTN_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ORDER.Location = new System.Drawing.Point(19, 114);
            this.BTN_ORDER.Name = "BTN_ORDER";
            this.BTN_ORDER.Size = new System.Drawing.Size(94, 33);
            this.BTN_ORDER.TabIndex = 37;
            this.BTN_ORDER.Text = "ORDER";
            this.BTN_ORDER.UseVisualStyleBackColor = false;
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(546, 25);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(121, 21);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(499, 28);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 9;
            this.LBL_STATUS.Text = "Status:";
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(604, 54);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(63, 23);
            this.BTN_SEARCH_PRODUCT.TabIndex = 8;
            this.BTN_SEARCH_PRODUCT.Text = "Search";
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = true;
            // 
            // LBL_PERCHASE_NUM
            // 
            this.LBL_PERCHASE_NUM.AutoSize = true;
            this.LBL_PERCHASE_NUM.Location = new System.Drawing.Point(24, 29);
            this.LBL_PERCHASE_NUM.Name = "LBL_PERCHASE_NUM";
            this.LBL_PERCHASE_NUM.Size = new System.Drawing.Size(95, 13);
            this.LBL_PERCHASE_NUM.TabIndex = 5;
            this.LBL_PERCHASE_NUM.Text = "Perchase Number:";
            // 
            // TXT_PERCHASE_NUM
            // 
            this.TXT_PERCHASE_NUM.Location = new System.Drawing.Point(126, 25);
            this.TXT_PERCHASE_NUM.Name = "TXT_PERCHASE_NUM";
            this.TXT_PERCHASE_NUM.Size = new System.Drawing.Size(147, 20);
            this.TXT_PERCHASE_NUM.TabIndex = 6;
            // 
            // GRB_ORDER_SEARCH
            // 
            this.GRB_ORDER_SEARCH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRB_ORDER_SEARCH.Controls.Add(this.DTP_ORDER_DATE);
            this.GRB_ORDER_SEARCH.Controls.Add(this.CMB_VENDOR);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_VENDOR);
            this.GRB_ORDER_SEARCH.Controls.Add(this.CMB_STATUS);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_STATUS);
            this.GRB_ORDER_SEARCH.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_ORDER_DATE);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_ORDER_NUM);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_PERCHASE_NUM);
            this.GRB_ORDER_SEARCH.Controls.Add(this.TXT_ORDER_NUM);
            this.GRB_ORDER_SEARCH.Controls.Add(this.TXT_PERCHASE_NUM);
            this.GRB_ORDER_SEARCH.Location = new System.Drawing.Point(317, 56);
            this.GRB_ORDER_SEARCH.Name = "GRB_ORDER_SEARCH";
            this.GRB_ORDER_SEARCH.Size = new System.Drawing.Size(686, 96);
            this.GRB_ORDER_SEARCH.TabIndex = 40;
            this.GRB_ORDER_SEARCH.TabStop = false;
            this.GRB_ORDER_SEARCH.Text = "Search Option";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(143, 129);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 35;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 129;
            this.lineShape1.X2 = 129;
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
            this.shapeContainer1.TabIndex = 42;
            this.shapeContainer1.TabStop = false;
            // 
            // TXT_ORDER_NUM
            // 
            this.TXT_ORDER_NUM.Location = new System.Drawing.Point(368, 55);
            this.TXT_ORDER_NUM.Name = "TXT_ORDER_NUM";
            this.TXT_ORDER_NUM.Size = new System.Drawing.Size(121, 20);
            this.TXT_ORDER_NUM.TabIndex = 6;
            // 
            // LBL_ORDER_NUM
            // 
            this.LBL_ORDER_NUM.AutoSize = true;
            this.LBL_ORDER_NUM.Location = new System.Drawing.Point(287, 58);
            this.LBL_ORDER_NUM.Name = "LBL_ORDER_NUM";
            this.LBL_ORDER_NUM.Size = new System.Drawing.Size(76, 13);
            this.LBL_ORDER_NUM.TabIndex = 5;
            this.LBL_ORDER_NUM.Text = "Order Number:";
            // 
            // DGVCMB_PRODUCT
            // 
            this.DGVCMB_PRODUCT.HeaderText = "Check";
            this.DGVCMB_PRODUCT.Name = "DGVCMB_PRODUCT";
            this.DGVCMB_PRODUCT.Width = 40;
            // 
            // DGVTXT_ID
            // 
            this.DGVTXT_ID.HeaderText = "ID";
            this.DGVTXT_ID.Name = "DGVTXT_ID";
            this.DGVTXT_ID.Width = 70;
            // 
            // DGVTXT_PERCHASE_NUM
            // 
            this.DGVTXT_PERCHASE_NUM.HeaderText = "PERCHASE NUM";
            this.DGVTXT_PERCHASE_NUM.Name = "DGVTXT_PERCHASE_NUM";
            this.DGVTXT_PERCHASE_NUM.Width = 120;
            // 
            // DGVTXT_ORDER_NUMBER
            // 
            this.DGVTXT_ORDER_NUMBER.HeaderText = "ORDER NUM";
            this.DGVTXT_ORDER_NUMBER.Name = "DGVTXT_ORDER_NUMBER";
            this.DGVTXT_ORDER_NUMBER.Width = 120;
            // 
            // DGVTXT_PERCHASE_DATE
            // 
            this.DGVTXT_PERCHASE_DATE.HeaderText = "PERCHASE DATE";
            this.DGVTXT_PERCHASE_DATE.Name = "DGVTXT_PERCHASE_DATE";
            this.DGVTXT_PERCHASE_DATE.Width = 120;
            // 
            // DGVTXT_VENDER
            // 
            this.DGVTXT_VENDER.HeaderText = "VENDER";
            this.DGVTXT_VENDER.Name = "DGVTXT_VENDER";
            this.DGVTXT_VENDER.Width = 130;
            // 
            // DGVTXT_TOTAL_AMT
            // 
            this.DGVTXT_TOTAL_AMT.HeaderText = "TOTAL AMOUNT";
            this.DGVTXT_TOTAL_AMT.Name = "DGVTXT_TOTAL_AMT";
            // 
            // DGVTXT_STATUS
            // 
            this.DGVTXT_STATUS.HeaderText = "STATUS";
            this.DGVTXT_STATUS.Name = "DGVTXT_STATUS";
            this.DGVTXT_STATUS.Width = 60;
            // 
            // DGVBTN_EDIT
            // 
            this.DGVBTN_EDIT.HeaderText = "EDIT";
            this.DGVBTN_EDIT.Name = "DGVBTN_EDIT";
            this.DGVBTN_EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_EDIT.Width = 50;
            // 
            // DGVBTN_DELETE
            // 
            this.DGVBTN_DELETE.HeaderText = "DELETE";
            this.DGVBTN_DELETE.Name = "DGVBTN_DELETE";
            this.DGVBTN_DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_DELETE.Width = 50;
            // 
            // FRM_INVENTORY_PERCHASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.DGV_ORDER);
            this.Controls.Add(this.LBL_INVENTORY_PERCHASE_LIST);
            this.Controls.Add(this.BTN_PERCHASE);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_ORDER);
            this.Controls.Add(this.GRB_ORDER_SEARCH);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_INVENTORY_PERCHASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_INVENTORY_PERCHASE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.GRB_ORDER_SEARCH.ResumeLayout(false);
            this.GRB_ORDER_SEARCH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_ORDER_DATE;
        private System.Windows.Forms.ComboBox CMB_VENDOR;
        private System.Windows.Forms.Label LBL_ORDER_DATE;
        private System.Windows.Forms.Label LBL_VENDOR;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.Label LBL_INVENTORY_PERCHASE_LIST;
        private System.Windows.Forms.Button BTN_PERCHASE;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_ORDER;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.Label LBL_PERCHASE_NUM;
        private System.Windows.Forms.TextBox TXT_PERCHASE_NUM;
        private System.Windows.Forms.GroupBox GRB_ORDER_SEARCH;
        private System.Windows.Forms.Button BTN_DELETE;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label LBL_ORDER_NUM;
        private System.Windows.Forms.TextBox TXT_ORDER_NUM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PERCHASE_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ORDER_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PERCHASE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_VENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_TOTAL_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_STATUS;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
    }
}