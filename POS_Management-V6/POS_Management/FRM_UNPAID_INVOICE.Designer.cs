namespace POS_Management
{
    partial class FRM_UNPAID_INVOICE
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
            this.GRB_SEARCH = new System.Windows.Forms.GroupBox();
            this.LBL_INV_DATETIME = new System.Windows.Forms.Label();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.LBL_INV_NUM = new System.Windows.Forms.Label();
            this.TXT_INV_NUM = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCT = new System.Windows.Forms.DataGridView();
            this.LBL_UNPAID_INVOICE_LIST = new System.Windows.Forms.Label();
            this.DTP_INV_DATETIME = new System.Windows.Forms.DateTimePicker();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_INV_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_INV_DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_ITEM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_DIS_PERCENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_DIS_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_GRANT_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVLC_DETAIL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVLC_PAY = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GRB_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).BeginInit();
            this.SuspendLayout();
            // 
            // GRB_SEARCH
            // 
            this.GRB_SEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GRB_SEARCH.Controls.Add(this.DTP_INV_DATETIME);
            this.GRB_SEARCH.Controls.Add(this.LBL_INV_DATETIME);
            this.GRB_SEARCH.Controls.Add(this.BTN_SEARCH);
            this.GRB_SEARCH.Controls.Add(this.LBL_INV_NUM);
            this.GRB_SEARCH.Controls.Add(this.TXT_INV_NUM);
            this.GRB_SEARCH.Location = new System.Drawing.Point(513, 62);
            this.GRB_SEARCH.Name = "GRB_SEARCH";
            this.GRB_SEARCH.Size = new System.Drawing.Size(479, 91);
            this.GRB_SEARCH.TabIndex = 20;
            this.GRB_SEARCH.TabStop = false;
            this.GRB_SEARCH.Text = "Search Option";
            // 
            // LBL_INV_DATETIME
            // 
            this.LBL_INV_DATETIME.AutoSize = true;
            this.LBL_INV_DATETIME.Location = new System.Drawing.Point(23, 61);
            this.LBL_INV_DATETIME.Name = "LBL_INV_DATETIME";
            this.LBL_INV_DATETIME.Size = new System.Drawing.Size(52, 13);
            this.LBL_INV_DATETIME.TabIndex = 5;
            this.LBL_INV_DATETIME.Text = "Datetime:";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Location = new System.Drawing.Point(363, 55);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(63, 23);
            this.BTN_SEARCH.TabIndex = 8;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            // 
            // LBL_INV_NUM
            // 
            this.LBL_INV_NUM.AutoSize = true;
            this.LBL_INV_NUM.Location = new System.Drawing.Point(24, 29);
            this.LBL_INV_NUM.Name = "LBL_INV_NUM";
            this.LBL_INV_NUM.Size = new System.Drawing.Size(85, 13);
            this.LBL_INV_NUM.TabIndex = 5;
            this.LBL_INV_NUM.Text = "Invoice Number:";
            // 
            // TXT_INV_NUM
            // 
            this.TXT_INV_NUM.Location = new System.Drawing.Point(139, 22);
            this.TXT_INV_NUM.Name = "TXT_INV_NUM";
            this.TXT_INV_NUM.Size = new System.Drawing.Size(197, 20);
            this.TXT_INV_NUM.TabIndex = 6;
            // 
            // DGV_PRODUCT
            // 
            this.DGV_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_PRODUCT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_PRODUCT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PRODUCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVTXT_ID,
            this.DGVTXT_INV_NUM,
            this.DGVTXT_INV_DATETIME,
            this.DGVTXT_ITEM_QTY,
            this.DGVTXT_SUB_TOTAL,
            this.DGVTXT_DIS_PERCENT,
            this.DGVTXT_DIS_AMT,
            this.DGVTXT_GRANT_TOTAL,
            this.DGVLC_DETAIL,
            this.DGVLC_PAY});
            this.DGV_PRODUCT.Location = new System.Drawing.Point(27, 170);
            this.DGV_PRODUCT.Name = "DGV_PRODUCT";
            this.DGV_PRODUCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_PRODUCT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_PRODUCT.RowHeadersVisible = false;
            this.DGV_PRODUCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCT.Size = new System.Drawing.Size(975, 580);
            this.DGV_PRODUCT.TabIndex = 21;
            // 
            // LBL_UNPAID_INVOICE_LIST
            // 
            this.LBL_UNPAID_INVOICE_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_UNPAID_INVOICE_LIST.AutoSize = true;
            this.LBL_UNPAID_INVOICE_LIST.Location = new System.Drawing.Point(452, 18);
            this.LBL_UNPAID_INVOICE_LIST.Name = "LBL_UNPAID_INVOICE_LIST";
            this.LBL_UNPAID_INVOICE_LIST.Size = new System.Drawing.Size(120, 13);
            this.LBL_UNPAID_INVOICE_LIST.TabIndex = 19;
            this.LBL_UNPAID_INVOICE_LIST.Text = "UNPAID INVOICE LIST";
            // 
            // DTP_INV_DATETIME
            // 
            this.DTP_INV_DATETIME.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_INV_DATETIME.Location = new System.Drawing.Point(139, 58);
            this.DTP_INV_DATETIME.Name = "DTP_INV_DATETIME";
            this.DTP_INV_DATETIME.Size = new System.Drawing.Size(197, 20);
            this.DTP_INV_DATETIME.TabIndex = 9;
            // 
            // DGVTXT_ID
            // 
            this.DGVTXT_ID.HeaderText = "ID";
            this.DGVTXT_ID.Name = "DGVTXT_ID";
            this.DGVTXT_ID.Width = 80;
            // 
            // DGVTXT_INV_NUM
            // 
            this.DGVTXT_INV_NUM.HeaderText = "INVOICE NUM";
            this.DGVTXT_INV_NUM.Name = "DGVTXT_INV_NUM";
            this.DGVTXT_INV_NUM.Width = 170;
            // 
            // DGVTXT_INV_DATETIME
            // 
            this.DGVTXT_INV_DATETIME.HeaderText = "DATETIME";
            this.DGVTXT_INV_DATETIME.Name = "DGVTXT_INV_DATETIME";
            // 
            // DGVTXT_ITEM_QTY
            // 
            this.DGVTXT_ITEM_QTY.HeaderText = "ITEM QTY";
            this.DGVTXT_ITEM_QTY.Name = "DGVTXT_ITEM_QTY";
            this.DGVTXT_ITEM_QTY.Width = 96;
            // 
            // DGVTXT_SUB_TOTAL
            // 
            this.DGVTXT_SUB_TOTAL.HeaderText = "SUB TOTAL";
            this.DGVTXT_SUB_TOTAL.Name = "DGVTXT_SUB_TOTAL";
            // 
            // DGVTXT_DIS_PERCENT
            // 
            this.DGVTXT_DIS_PERCENT.HeaderText = "DISCOUNT %";
            this.DGVTXT_DIS_PERCENT.Name = "DGVTXT_DIS_PERCENT";
            this.DGVTXT_DIS_PERCENT.Width = 95;
            // 
            // DGVTXT_DIS_AMT
            // 
            this.DGVTXT_DIS_AMT.HeaderText = "DISCOUNT AMT";
            this.DGVTXT_DIS_AMT.Name = "DGVTXT_DIS_AMT";
            // 
            // DGVTXT_GRANT_TOTAL
            // 
            this.DGVTXT_GRANT_TOTAL.HeaderText = "GRANT TOTAL";
            this.DGVTXT_GRANT_TOTAL.Name = "DGVTXT_GRANT_TOTAL";
            this.DGVTXT_GRANT_TOTAL.Width = 110;
            // 
            // DGVLC_DETAIL
            // 
            this.DGVLC_DETAIL.HeaderText = "DETAIL";
            this.DGVLC_DETAIL.Name = "DGVLC_DETAIL";
            this.DGVLC_DETAIL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLC_DETAIL.Width = 60;
            // 
            // DGVLC_PAY
            // 
            this.DGVLC_PAY.HeaderText = "PAY";
            this.DGVLC_PAY.Name = "DGVLC_PAY";
            this.DGVLC_PAY.Width = 60;
            // 
            // FRM_UNPAID_INVOICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.GRB_SEARCH);
            this.Controls.Add(this.DGV_PRODUCT);
            this.Controls.Add(this.LBL_UNPAID_INVOICE_LIST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_UNPAID_INVOICE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_UNPAID_INVOICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GRB_SEARCH.ResumeLayout(false);
            this.GRB_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRB_SEARCH;
        private System.Windows.Forms.Label LBL_INV_DATETIME;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Label LBL_INV_NUM;
        private System.Windows.Forms.TextBox TXT_INV_NUM;
        private System.Windows.Forms.DataGridView DGV_PRODUCT;
        private System.Windows.Forms.Label LBL_UNPAID_INVOICE_LIST;
        private System.Windows.Forms.DateTimePicker DTP_INV_DATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_INV_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_INV_DATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ITEM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_SUB_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_DIS_PERCENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_DIS_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_GRANT_TOTAL;
        private System.Windows.Forms.DataGridViewLinkColumn DGVLC_DETAIL;
        private System.Windows.Forms.DataGridViewLinkColumn DGVLC_PAY;
    }
}