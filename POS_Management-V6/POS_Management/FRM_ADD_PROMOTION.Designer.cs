namespace POS_Management
{
    partial class FRM_ADD_PROMOTION
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
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.LBL_TITLE_KH = new System.Windows.Forms.Label();
            this.LBL_PRICE = new System.Windows.Forms.Label();
            this.LBL_PROMO_ID = new System.Windows.Forms.Label();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.TXT_PRICE = new System.Windows.Forms.TextBox();
            this.TXT_PROMO_ID = new System.Windows.Forms.TextBox();
            this.TXT_TITLE_EN = new System.Windows.Forms.TextBox();
            this.LBL_TITLE_EN = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.GRB_ADD_ORDER = new System.Windows.Forms.GroupBox();
            this.LBL_ADD_PROMOTION = new System.Windows.Forms.Label();
            this.TXT_TITLE_KH = new System.Windows.Forms.TextBox();
            this.TXT_DIS_PERCENT = new System.Windows.Forms.TextBox();
            this.LBL_DIS_PERCENT = new System.Windows.Forms.Label();
            this.TXT_DIS_AMT = new System.Windows.Forms.TextBox();
            this.LBL_DIS_AMT = new System.Windows.Forms.Label();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_PRO_NAME_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.GRB_ADD_ORDER.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(726, 94);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(166, 21);
            this.CMB_STATUS.TabIndex = 60;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(616, 98);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 58;
            this.LBL_STATUS.Text = "Status:";
            // 
            // LBL_TITLE_KH
            // 
            this.LBL_TITLE_KH.AutoSize = true;
            this.LBL_TITLE_KH.Location = new System.Drawing.Point(334, 86);
            this.LBL_TITLE_KH.Name = "LBL_TITLE_KH";
            this.LBL_TITLE_KH.Size = new System.Drawing.Size(46, 13);
            this.LBL_TITLE_KH.TabIndex = 50;
            this.LBL_TITLE_KH.Text = "Title Kh:";
            // 
            // LBL_PRICE
            // 
            this.LBL_PRICE.AutoSize = true;
            this.LBL_PRICE.Location = new System.Drawing.Point(334, 116);
            this.LBL_PRICE.Name = "LBL_PRICE";
            this.LBL_PRICE.Size = new System.Drawing.Size(34, 13);
            this.LBL_PRICE.TabIndex = 51;
            this.LBL_PRICE.Text = "Price:";
            // 
            // LBL_PROMO_ID
            // 
            this.LBL_PROMO_ID.AutoSize = true;
            this.LBL_PROMO_ID.Location = new System.Drawing.Point(334, 26);
            this.LBL_PROMO_ID.Name = "LBL_PROMO_ID";
            this.LBL_PROMO_ID.Size = new System.Drawing.Size(69, 13);
            this.LBL_PROMO_ID.TabIndex = 52;
            this.LBL_PROMO_ID.Text = "Promotion Id:";
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
            this.DGVTXT_QUANTITY,
            this.DGVBTN_DELETE});
            this.DGV_ORDER.Location = new System.Drawing.Point(29, 178);
            this.DGV_ORDER.Name = "DGV_ORDER";
            this.DGV_ORDER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ORDER.RowHeadersVisible = false;
            this.DGV_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDER.Size = new System.Drawing.Size(863, 426);
            this.DGV_ORDER.TabIndex = 49;
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Location = new System.Drawing.Point(414, 112);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(166, 20);
            this.TXT_PRICE.TabIndex = 54;
            // 
            // TXT_PROMO_ID
            // 
            this.TXT_PROMO_ID.Location = new System.Drawing.Point(414, 22);
            this.TXT_PROMO_ID.Name = "TXT_PROMO_ID";
            this.TXT_PROMO_ID.Size = new System.Drawing.Size(166, 20);
            this.TXT_PROMO_ID.TabIndex = 55;
            // 
            // TXT_TITLE_EN
            // 
            this.TXT_TITLE_EN.Location = new System.Drawing.Point(414, 52);
            this.TXT_TITLE_EN.Name = "TXT_TITLE_EN";
            this.TXT_TITLE_EN.Size = new System.Drawing.Size(166, 20);
            this.TXT_TITLE_EN.TabIndex = 56;
            // 
            // LBL_TITLE_EN
            // 
            this.LBL_TITLE_EN.AutoSize = true;
            this.LBL_TITLE_EN.Location = new System.Drawing.Point(334, 56);
            this.LBL_TITLE_EN.Name = "LBL_TITLE_EN";
            this.LBL_TITLE_EN.Size = new System.Drawing.Size(49, 13);
            this.LBL_TITLE_EN.TabIndex = 53;
            this.LBL_TITLE_EN.Text = "Tittle En:";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(29, 149);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 48;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(850, 712);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(94, 33);
            this.BTN_CANCEL.TabIndex = 53;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(741, 712);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(94, 33);
            this.BTN_SAVE.TabIndex = 54;
            this.BTN_SAVE.Text = "ADD";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR.Location = new System.Drawing.Point(631, 712);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(94, 33);
            this.BTN_CLEAR.TabIndex = 55;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            // 
            // GRB_ADD_ORDER
            // 
            this.GRB_ADD_ORDER.Controls.Add(this.CMB_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_TITLE_KH);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_DIS_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_DIS_PERCENT);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PRICE);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PROMO_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_TITLE_EN);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_DIS_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_DIS_PERCENT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_PRICE);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_PROMO_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_TITLE_KH);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_TITLE_EN);
            this.GRB_ADD_ORDER.Controls.Add(this.DGV_ORDER);
            this.GRB_ADD_ORDER.Controls.Add(this.BTN_DELETE);
            this.GRB_ADD_ORDER.Location = new System.Drawing.Point(52, 57);
            this.GRB_ADD_ORDER.Name = "GRB_ADD_ORDER";
            this.GRB_ADD_ORDER.Size = new System.Drawing.Size(921, 627);
            this.GRB_ADD_ORDER.TabIndex = 56;
            this.GRB_ADD_ORDER.TabStop = false;
            // 
            // LBL_ADD_PROMOTION
            // 
            this.LBL_ADD_PROMOTION.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_ADD_PROMOTION.AutoSize = true;
            this.LBL_ADD_PROMOTION.Location = new System.Drawing.Point(443, 23);
            this.LBL_ADD_PROMOTION.Name = "LBL_ADD_PROMOTION";
            this.LBL_ADD_PROMOTION.Size = new System.Drawing.Size(99, 13);
            this.LBL_ADD_PROMOTION.TabIndex = 52;
            this.LBL_ADD_PROMOTION.Text = "ADD PROMOTION";
            // 
            // TXT_TITLE_KH
            // 
            this.TXT_TITLE_KH.Location = new System.Drawing.Point(414, 82);
            this.TXT_TITLE_KH.Name = "TXT_TITLE_KH";
            this.TXT_TITLE_KH.Size = new System.Drawing.Size(166, 20);
            this.TXT_TITLE_KH.TabIndex = 56;
            // 
            // TXT_DIS_PERCENT
            // 
            this.TXT_DIS_PERCENT.Location = new System.Drawing.Point(726, 26);
            this.TXT_DIS_PERCENT.Name = "TXT_DIS_PERCENT";
            this.TXT_DIS_PERCENT.Size = new System.Drawing.Size(166, 20);
            this.TXT_DIS_PERCENT.TabIndex = 54;
            // 
            // LBL_DIS_PERCENT
            // 
            this.LBL_DIS_PERCENT.AutoSize = true;
            this.LBL_DIS_PERCENT.Location = new System.Drawing.Point(616, 30);
            this.LBL_DIS_PERCENT.Name = "LBL_DIS_PERCENT";
            this.LBL_DIS_PERCENT.Size = new System.Drawing.Size(63, 13);
            this.LBL_DIS_PERCENT.TabIndex = 51;
            this.LBL_DIS_PERCENT.Text = "Discount %:";
            // 
            // TXT_DIS_AMT
            // 
            this.TXT_DIS_AMT.Location = new System.Drawing.Point(726, 60);
            this.TXT_DIS_AMT.Name = "TXT_DIS_AMT";
            this.TXT_DIS_AMT.Size = new System.Drawing.Size(166, 20);
            this.TXT_DIS_AMT.TabIndex = 54;
            // 
            // LBL_DIS_AMT
            // 
            this.LBL_DIS_AMT.AutoSize = true;
            this.LBL_DIS_AMT.Location = new System.Drawing.Point(616, 64);
            this.LBL_DIS_AMT.Name = "LBL_DIS_AMT";
            this.LBL_DIS_AMT.Size = new System.Drawing.Size(91, 13);
            this.LBL_DIS_AMT.TabIndex = 51;
            this.LBL_DIS_AMT.Text = "Discount Amount:";
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
            this._EN.Width = 270;
            // 
            // DGVTXT_PRO_NAME_KH
            // 
            this.DGVTXT_PRO_NAME_KH.HeaderText = "PRODUCT NAME KH";
            this.DGVTXT_PRO_NAME_KH.Name = "DGVTXT_PRO_NAME_KH";
            this.DGVTXT_PRO_NAME_KH.Width = 270;
            // 
            // DGVTXT_QUANTITY
            // 
            this.DGVTXT_QUANTITY.HeaderText = "QUANTITY";
            this.DGVTXT_QUANTITY.Name = "DGVTXT_QUANTITY";
            this.DGVTXT_QUANTITY.Width = 110;
            // 
            // DGVBTN_DELETE
            // 
            this.DGVBTN_DELETE.HeaderText = "DELETE";
            this.DGVBTN_DELETE.Name = "DGVBTN_DELETE";
            this.DGVBTN_DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBTN_DELETE.Width = 60;
            // 
            // FRM_ADD_PROMOTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.GRB_ADD_ORDER);
            this.Controls.Add(this.LBL_ADD_PROMOTION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_PROMOTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD_PROMOTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.GRB_ADD_ORDER.ResumeLayout(false);
            this.GRB_ADD_ORDER.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Label LBL_TITLE_KH;
        private System.Windows.Forms.Label LBL_PRICE;
        private System.Windows.Forms.Label LBL_PROMO_ID;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.TextBox TXT_PRICE;
        private System.Windows.Forms.TextBox TXT_PROMO_ID;
        private System.Windows.Forms.TextBox TXT_TITLE_EN;
        private System.Windows.Forms.Label LBL_TITLE_EN;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.GroupBox GRB_ADD_ORDER;
        private System.Windows.Forms.Label LBL_DIS_PERCENT;
        private System.Windows.Forms.TextBox TXT_DIS_PERCENT;
        private System.Windows.Forms.TextBox TXT_TITLE_KH;
        private System.Windows.Forms.Label LBL_ADD_PROMOTION;
        private System.Windows.Forms.Label LBL_DIS_AMT;
        private System.Windows.Forms.TextBox TXT_DIS_AMT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_NAME_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_QUANTITY;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
    }
}