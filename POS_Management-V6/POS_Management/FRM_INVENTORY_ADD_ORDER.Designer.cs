namespace POS_Management
{
    partial class FRM_INVENTORY_ADD_ORDER
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
            this.LBL_ADD_ORDER = new System.Windows.Forms.Label();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.GRB_ADD_ORDER = new System.Windows.Forms.GroupBox();
            this.DTP_ORDER_DATE = new System.Windows.Forms.DateTimePicker();
            this.CMB_VENDOR = new System.Windows.Forms.ComboBox();
            this.LBL_VENDOR = new System.Windows.Forms.Label();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.LBL_ORDER_DATE = new System.Windows.Forms.Label();
            this.LBL_TOTAL_AMOUNT = new System.Windows.Forms.Label();
            this.LBL_ORDER_ID = new System.Windows.Forms.Label();
            this.LBL_ORDER_NUM = new System.Windows.Forms.Label();
            this.TXT_TOTAL_AMT = new System.Windows.Forms.TextBox();
            this.TXT_ORDER_ID = new System.Windows.Forms.TextBox();
            this.TXT_ORDER_NUM = new System.Windows.Forms.TextBox();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_PRO_NAME_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_UNIT_COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.GRB_ADD_ORDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ADD_ORDER
            // 
            this.LBL_ADD_ORDER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_ADD_ORDER.AutoSize = true;
            this.LBL_ADD_ORDER.Location = new System.Drawing.Point(443, 22);
            this.LBL_ADD_ORDER.Name = "LBL_ADD_ORDER";
            this.LBL_ADD_ORDER.Size = new System.Drawing.Size(138, 13);
            this.LBL_ADD_ORDER.TabIndex = 37;
            this.LBL_ADD_ORDER.Text = "ADD INVENTORY ORDER";
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(850, 711);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(94, 33);
            this.BTN_CANCEL.TabIndex = 48;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(741, 711);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(94, 33);
            this.BTN_SAVE.TabIndex = 49;
            this.BTN_SAVE.Text = "ADD";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR.Location = new System.Drawing.Point(631, 711);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(94, 33);
            this.BTN_CLEAR.TabIndex = 50;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            // 
            // GRB_ADD_ORDER
            // 
            this.GRB_ADD_ORDER.Controls.Add(this.DTP_ORDER_DATE);
            this.GRB_ADD_ORDER.Controls.Add(this.CMB_VENDOR);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_VENDOR);
            this.GRB_ADD_ORDER.Controls.Add(this.CMB_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_ORDER_DATE);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_TOTAL_AMOUNT);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_ORDER_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_ORDER_NUM);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_TOTAL_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_ORDER_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_ORDER_NUM);
            this.GRB_ADD_ORDER.Controls.Add(this.DGV_ORDER);
            this.GRB_ADD_ORDER.Controls.Add(this.BTN_DELETE);
            this.GRB_ADD_ORDER.Location = new System.Drawing.Point(52, 56);
            this.GRB_ADD_ORDER.Name = "GRB_ADD_ORDER";
            this.GRB_ADD_ORDER.Size = new System.Drawing.Size(921, 627);
            this.GRB_ADD_ORDER.TabIndex = 51;
            this.GRB_ADD_ORDER.TabStop = false;
            // 
            // DTP_ORDER_DATE
            // 
            this.DTP_ORDER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_ORDER_DATE.Location = new System.Drawing.Point(417, 77);
            this.DTP_ORDER_DATE.Name = "DTP_ORDER_DATE";
            this.DTP_ORDER_DATE.Size = new System.Drawing.Size(147, 20);
            this.DTP_ORDER_DATE.TabIndex = 61;
            this.DTP_ORDER_DATE.Value = new System.DateTime(2016, 1, 11, 15, 33, 35, 0);
            // 
            // CMB_VENDOR
            // 
            this.CMB_VENDOR.FormattingEnabled = true;
            this.CMB_VENDOR.Location = new System.Drawing.Point(742, 52);
            this.CMB_VENDOR.Name = "CMB_VENDOR";
            this.CMB_VENDOR.Size = new System.Drawing.Size(150, 21);
            this.CMB_VENDOR.TabIndex = 59;
            // 
            // LBL_VENDOR
            // 
            this.LBL_VENDOR.AutoSize = true;
            this.LBL_VENDOR.Location = new System.Drawing.Point(663, 56);
            this.LBL_VENDOR.Name = "LBL_VENDOR";
            this.LBL_VENDOR.Size = new System.Drawing.Size(44, 13);
            this.LBL_VENDOR.TabIndex = 57;
            this.LBL_VENDOR.Text = "Vendor:";
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(742, 79);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(150, 21);
            this.CMB_STATUS.TabIndex = 60;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(663, 83);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 58;
            this.LBL_STATUS.Text = "Status:";
            // 
            // LBL_ORDER_DATE
            // 
            this.LBL_ORDER_DATE.AutoSize = true;
            this.LBL_ORDER_DATE.Location = new System.Drawing.Point(334, 80);
            this.LBL_ORDER_DATE.Name = "LBL_ORDER_DATE";
            this.LBL_ORDER_DATE.Size = new System.Drawing.Size(62, 13);
            this.LBL_ORDER_DATE.TabIndex = 50;
            this.LBL_ORDER_DATE.Text = "Order Date:";
            // 
            // LBL_TOTAL_AMOUNT
            // 
            this.LBL_TOTAL_AMOUNT.AutoSize = true;
            this.LBL_TOTAL_AMOUNT.Location = new System.Drawing.Point(663, 29);
            this.LBL_TOTAL_AMOUNT.Name = "LBL_TOTAL_AMOUNT";
            this.LBL_TOTAL_AMOUNT.Size = new System.Drawing.Size(73, 13);
            this.LBL_TOTAL_AMOUNT.TabIndex = 51;
            this.LBL_TOTAL_AMOUNT.Text = "Total Amount:";
            // 
            // LBL_ORDER_ID
            // 
            this.LBL_ORDER_ID.AutoSize = true;
            this.LBL_ORDER_ID.Location = new System.Drawing.Point(334, 26);
            this.LBL_ORDER_ID.Name = "LBL_ORDER_ID";
            this.LBL_ORDER_ID.Size = new System.Drawing.Size(48, 13);
            this.LBL_ORDER_ID.TabIndex = 52;
            this.LBL_ORDER_ID.Text = "Order Id:";
            // 
            // LBL_ORDER_NUM
            // 
            this.LBL_ORDER_NUM.AutoSize = true;
            this.LBL_ORDER_NUM.Location = new System.Drawing.Point(334, 54);
            this.LBL_ORDER_NUM.Name = "LBL_ORDER_NUM";
            this.LBL_ORDER_NUM.Size = new System.Drawing.Size(76, 13);
            this.LBL_ORDER_NUM.TabIndex = 53;
            this.LBL_ORDER_NUM.Text = "Order Number:";
            // 
            // TXT_TOTAL_AMT
            // 
            this.TXT_TOTAL_AMT.Location = new System.Drawing.Point(742, 25);
            this.TXT_TOTAL_AMT.Name = "TXT_TOTAL_AMT";
            this.TXT_TOTAL_AMT.Size = new System.Drawing.Size(150, 20);
            this.TXT_TOTAL_AMT.TabIndex = 54;
            // 
            // TXT_ORDER_ID
            // 
            this.TXT_ORDER_ID.Location = new System.Drawing.Point(417, 22);
            this.TXT_ORDER_ID.Name = "TXT_ORDER_ID";
            this.TXT_ORDER_ID.Size = new System.Drawing.Size(147, 20);
            this.TXT_ORDER_ID.TabIndex = 55;
            // 
            // TXT_ORDER_NUM
            // 
            this.TXT_ORDER_NUM.Location = new System.Drawing.Point(417, 50);
            this.TXT_ORDER_NUM.Name = "TXT_ORDER_NUM";
            this.TXT_ORDER_NUM.Size = new System.Drawing.Size(147, 20);
            this.TXT_ORDER_NUM.TabIndex = 56;
            // 
            // DGV_ORDER
            // 
            this.DGV_ORDER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ORDER.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_ORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_ORDER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCMB_PRODUCT,
            this.DGVTXT_PRO_ID,
            this._EN,
            this.DGVTXT_PRO_NAME_KH,
            this.DGVTXT_UNIT_COST,
            this.DGVTXT_QUANTITY,
            this.DGVTXT_UNIT,
            this.DGVBTN_DELETE});
            this.DGV_ORDER.Location = new System.Drawing.Point(29, 119);
            this.DGV_ORDER.Name = "DGV_ORDER";
            this.DGV_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.RowHeadersVisible = false;
            this.DGV_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDER.Size = new System.Drawing.Size(863, 485);
            this.DGV_ORDER.TabIndex = 49;
            // 
            // DGVCMB_PRODUCT
            // 
            this.DGVCMB_PRODUCT.HeaderText = "Check";
            this.DGVCMB_PRODUCT.Name = "DGVCMB_PRODUCT";
            this.DGVCMB_PRODUCT.Width = 50;
            // 
            // DGVTXT_PRO_ID
            // 
            this.DGVTXT_PRO_ID.HeaderText = "PRODUCT ID";
            this.DGVTXT_PRO_ID.Name = "DGVTXT_PRO_ID";
            // 
            // _EN
            // 
            this._EN.HeaderText = "PRODUCT NAME EN";
            this._EN.Name = "_EN";
            this._EN.Width = 150;
            // 
            // DGVTXT_PRO_NAME_KH
            // 
            this.DGVTXT_PRO_NAME_KH.HeaderText = "PRODUCT NAME KH";
            this.DGVTXT_PRO_NAME_KH.Name = "DGVTXT_PRO_NAME_KH";
            this.DGVTXT_PRO_NAME_KH.Width = 150;
            // 
            // DGVTXT_UNIT_COST
            // 
            this.DGVTXT_UNIT_COST.HeaderText = "UNIT COST";
            this.DGVTXT_UNIT_COST.Name = "DGVTXT_UNIT_COST";
            this.DGVTXT_UNIT_COST.Width = 150;
            // 
            // DGVTXT_QUANTITY
            // 
            this.DGVTXT_QUANTITY.HeaderText = "QUANTITY";
            this.DGVTXT_QUANTITY.Name = "DGVTXT_QUANTITY";
            this.DGVTXT_QUANTITY.Width = 120;
            // 
            // DGVTXT_UNIT
            // 
            this.DGVTXT_UNIT.HeaderText = "UNIT";
            this.DGVTXT_UNIT.Name = "DGVTXT_UNIT";
            this.DGVTXT_UNIT.Width = 80;
            // 
            // DGVBTN_DELETE
            // 
            this.DGVBTN_DELETE.HeaderText = "DELETE";
            this.DGVBTN_DELETE.Name = "DGVBTN_DELETE";
            this.DGVBTN_DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_DELETE.Width = 60;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(29, 77);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 48;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // FRM_INVENTORY_ADD_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.LBL_ADD_ORDER);
            this.Controls.Add(this.GRB_ADD_ORDER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_INVENTORY_ADD_ORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_INVENTORY_ADD_ORDER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GRB_ADD_ORDER.ResumeLayout(false);
            this.GRB_ADD_ORDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ADD_ORDER;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.GroupBox GRB_ADD_ORDER;
        private System.Windows.Forms.DateTimePicker DTP_ORDER_DATE;
        private System.Windows.Forms.ComboBox CMB_VENDOR;
        private System.Windows.Forms.Label LBL_VENDOR;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Label LBL_ORDER_DATE;
        private System.Windows.Forms.Label LBL_TOTAL_AMOUNT;
        private System.Windows.Forms.Label LBL_ORDER_ID;
        private System.Windows.Forms.Label LBL_ORDER_NUM;
        private System.Windows.Forms.TextBox TXT_TOTAL_AMT;
        private System.Windows.Forms.TextBox TXT_ORDER_ID;
        private System.Windows.Forms.TextBox TXT_ORDER_NUM;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_NAME_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_UNIT_COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_UNIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
        private System.Windows.Forms.Button BTN_DELETE;
    }
}