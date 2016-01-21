namespace POS_Management
{
    partial class FRM_PROMOTION
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
            this.LBL_TITLE_KH = new System.Windows.Forms.Label();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.LBL_TITLE_EN = new System.Windows.Forms.Label();
            this.TXT_TITLE_EN = new System.Windows.Forms.TextBox();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.LBL_PROMOTION_LIST = new System.Windows.Forms.Label();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.TXT_TITLE_KH = new System.Windows.Forms.TextBox();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_TITLE_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_TITLE_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GRB_ORDER_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // GRB_ORDER_SEARCH
            // 
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_TITLE_KH);
            this.GRB_ORDER_SEARCH.Controls.Add(this.BTN_SEARCH);
            this.GRB_ORDER_SEARCH.Controls.Add(this.LBL_TITLE_EN);
            this.GRB_ORDER_SEARCH.Controls.Add(this.TXT_TITLE_KH);
            this.GRB_ORDER_SEARCH.Controls.Add(this.TXT_TITLE_EN);
            this.GRB_ORDER_SEARCH.Location = new System.Drawing.Point(560, 63);
            this.GRB_ORDER_SEARCH.Name = "GRB_ORDER_SEARCH";
            this.GRB_ORDER_SEARCH.Size = new System.Drawing.Size(384, 83);
            this.GRB_ORDER_SEARCH.TabIndex = 38;
            this.GRB_ORDER_SEARCH.TabStop = false;
            this.GRB_ORDER_SEARCH.Text = "Search Option";
            // 
            // LBL_TITLE_KH
            // 
            this.LBL_TITLE_KH.AutoSize = true;
            this.LBL_TITLE_KH.Location = new System.Drawing.Point(24, 57);
            this.LBL_TITLE_KH.Name = "LBL_TITLE_KH";
            this.LBL_TITLE_KH.Size = new System.Drawing.Size(46, 13);
            this.LBL_TITLE_KH.TabIndex = 9;
            this.LBL_TITLE_KH.Text = "Title Kh:";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Location = new System.Drawing.Point(294, 47);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(63, 23);
            this.BTN_SEARCH.TabIndex = 8;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            // 
            // LBL_TITLE_EN
            // 
            this.LBL_TITLE_EN.AutoSize = true;
            this.LBL_TITLE_EN.Location = new System.Drawing.Point(24, 29);
            this.LBL_TITLE_EN.Name = "LBL_TITLE_EN";
            this.LBL_TITLE_EN.Size = new System.Drawing.Size(49, 13);
            this.LBL_TITLE_EN.TabIndex = 5;
            this.LBL_TITLE_EN.Text = "Tittle En:";
            // 
            // TXT_TITLE_EN
            // 
            this.TXT_TITLE_EN.Location = new System.Drawing.Point(107, 25);
            this.TXT_TITLE_EN.Name = "TXT_TITLE_EN";
            this.TXT_TITLE_EN.Size = new System.Drawing.Size(147, 20);
            this.TXT_TITLE_EN.TabIndex = 6;
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
            this.DGVTXT_TITLE_EN,
            this.DGVTXT_TITLE_KH,
            this.DGVTXT_PRICE,
            this.DGVTXT_STATUS,
            this.DGVBTN_EDIT,
            this.DGVBTN_DELETE});
            this.DGV_ORDER.Location = new System.Drawing.Point(81, 165);
            this.DGV_ORDER.Name = "DGV_ORDER";
            this.DGV_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.RowHeadersVisible = false;
            this.DGV_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDER.Size = new System.Drawing.Size(863, 580);
            this.DGV_ORDER.TabIndex = 39;
            // 
            // LBL_PROMOTION_LIST
            // 
            this.LBL_PROMOTION_LIST.AutoSize = true;
            this.LBL_PROMOTION_LIST.Location = new System.Drawing.Point(330, 24);
            this.LBL_PROMOTION_LIST.Name = "LBL_PROMOTION_LIST";
            this.LBL_PROMOTION_LIST.Size = new System.Drawing.Size(99, 13);
            this.LBL_PROMOTION_LIST.TabIndex = 37;
            this.LBL_PROMOTION_LIST.Text = "PROMOTION LIST";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Location = new System.Drawing.Point(81, 93);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(63, 23);
            this.BTN_ADD.TabIndex = 36;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(81, 123);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 35;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // TXT_TITLE_KH
            // 
            this.TXT_TITLE_KH.Location = new System.Drawing.Point(107, 54);
            this.TXT_TITLE_KH.Name = "TXT_TITLE_KH";
            this.TXT_TITLE_KH.Size = new System.Drawing.Size(147, 20);
            this.TXT_TITLE_KH.TabIndex = 6;
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
            // DGVTXT_TITLE_EN
            // 
            this.DGVTXT_TITLE_EN.HeaderText = "TITLE EN";
            this.DGVTXT_TITLE_EN.Name = "DGVTXT_TITLE_EN";
            this.DGVTXT_TITLE_EN.Width = 200;
            // 
            // DGVTXT_TITLE_KH
            // 
            this.DGVTXT_TITLE_KH.HeaderText = "TITLE KH";
            this.DGVTXT_TITLE_KH.Name = "DGVTXT_TITLE_KH";
            this.DGVTXT_TITLE_KH.Width = 200;
            // 
            // DGVTXT_PRICE
            // 
            this.DGVTXT_PRICE.HeaderText = "PRICE";
            this.DGVTXT_PRICE.Name = "DGVTXT_PRICE";
            this.DGVTXT_PRICE.Width = 140;
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
            // FRM_PROMOTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.GRB_ORDER_SEARCH);
            this.Controls.Add(this.DGV_ORDER);
            this.Controls.Add(this.LBL_PROMOTION_LIST);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_DELETE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PROMOTION";
            this.Text = "FRM_PROMOTION";
            this.GRB_ORDER_SEARCH.ResumeLayout(false);
            this.GRB_ORDER_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRB_ORDER_SEARCH;
        private System.Windows.Forms.Label LBL_TITLE_KH;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Label LBL_TITLE_EN;
        private System.Windows.Forms.TextBox TXT_TITLE_KH;
        private System.Windows.Forms.TextBox TXT_TITLE_EN;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.Label LBL_PROMOTION_LIST;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_TITLE_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_TITLE_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_STATUS;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
    }
}