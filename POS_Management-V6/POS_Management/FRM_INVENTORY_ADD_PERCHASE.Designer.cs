namespace POS_Management
{
    partial class FRM_INVENTORY_ADD_PERCHASE
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
            this.DGVTXT_PRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTP_PERCHASE_DATE = new System.Windows.Forms.DateTimePicker();
            this.LBL_TOTAL_AMT = new System.Windows.Forms.Label();
            this.CMB_PAYMENT_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_PAYMENT_STATUS = new System.Windows.Forms.Label();
            this.DGVTXT_UNIT_COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_DIS_AMT = new System.Windows.Forms.Label();
            this.LBL_PERCHASE_DATE = new System.Windows.Forms.Label();
            this.LBL_PERCHASE_NUM = new System.Windows.Forms.Label();
            this.DGV_ORDER = new System.Windows.Forms.DataGridView();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_PRO_NAME_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TXT_DIS_AMT = new System.Windows.Forms.TextBox();
            this.TXT_PERCHASE_NUM = new System.Windows.Forms.TextBox();
            this.TXT_DIS_PERCENT = new System.Windows.Forms.TextBox();
            this.LBL_DIS_PERCENT = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.GRB_ADD_ORDER = new System.Windows.Forms.GroupBox();
            this.LBL_ADD_PERCHASE = new System.Windows.Forms.Label();
            this.LBL_OR = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TXT_PERCHASE_ID = new System.Windows.Forms.TextBox();
            this.LBL_PERCHASE_ID = new System.Windows.Forms.Label();
            this.TXT_TOTAL_AMT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).BeginInit();
            this.GRB_ADD_ORDER.SuspendLayout();
            this.SuspendLayout();
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
            // DTP_PERCHASE_DATE
            // 
            this.DTP_PERCHASE_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_PERCHASE_DATE.Location = new System.Drawing.Point(743, 23);
            this.DTP_PERCHASE_DATE.Name = "DTP_PERCHASE_DATE";
            this.DTP_PERCHASE_DATE.Size = new System.Drawing.Size(147, 20);
            this.DTP_PERCHASE_DATE.TabIndex = 61;
            this.DTP_PERCHASE_DATE.Value = new System.DateTime(2016, 1, 11, 15, 33, 35, 0);
            // 
            // LBL_TOTAL_AMT
            // 
            this.LBL_TOTAL_AMT.AutoSize = true;
            this.LBL_TOTAL_AMT.Location = new System.Drawing.Point(656, 56);
            this.LBL_TOTAL_AMT.Name = "LBL_TOTAL_AMT";
            this.LBL_TOTAL_AMT.Size = new System.Drawing.Size(73, 13);
            this.LBL_TOTAL_AMT.TabIndex = 57;
            this.LBL_TOTAL_AMT.Text = "Total Amount:";
            // 
            // CMB_PAYMENT_STATUS
            // 
            this.CMB_PAYMENT_STATUS.FormattingEnabled = true;
            this.CMB_PAYMENT_STATUS.Location = new System.Drawing.Point(743, 79);
            this.CMB_PAYMENT_STATUS.Name = "CMB_PAYMENT_STATUS";
            this.CMB_PAYMENT_STATUS.Size = new System.Drawing.Size(147, 21);
            this.CMB_PAYMENT_STATUS.TabIndex = 60;
            // 
            // LBL_PAYMENT_STATUS
            // 
            this.LBL_PAYMENT_STATUS.AutoSize = true;
            this.LBL_PAYMENT_STATUS.Location = new System.Drawing.Point(656, 83);
            this.LBL_PAYMENT_STATUS.Name = "LBL_PAYMENT_STATUS";
            this.LBL_PAYMENT_STATUS.Size = new System.Drawing.Size(84, 13);
            this.LBL_PAYMENT_STATUS.TabIndex = 58;
            this.LBL_PAYMENT_STATUS.Text = "Payment Status:";
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
            // LBL_DIS_AMT
            // 
            this.LBL_DIS_AMT.AutoSize = true;
            this.LBL_DIS_AMT.Location = new System.Drawing.Point(387, 80);
            this.LBL_DIS_AMT.Name = "LBL_DIS_AMT";
            this.LBL_DIS_AMT.Size = new System.Drawing.Size(91, 13);
            this.LBL_DIS_AMT.TabIndex = 50;
            this.LBL_DIS_AMT.Text = "Discount Amount:";
            // 
            // LBL_PERCHASE_DATE
            // 
            this.LBL_PERCHASE_DATE.AutoSize = true;
            this.LBL_PERCHASE_DATE.Location = new System.Drawing.Point(656, 29);
            this.LBL_PERCHASE_DATE.Name = "LBL_PERCHASE_DATE";
            this.LBL_PERCHASE_DATE.Size = new System.Drawing.Size(81, 13);
            this.LBL_PERCHASE_DATE.TabIndex = 51;
            this.LBL_PERCHASE_DATE.Text = "Perchase Date:";
            // 
            // LBL_PERCHASE_NUM
            // 
            this.LBL_PERCHASE_NUM.AutoSize = true;
            this.LBL_PERCHASE_NUM.Location = new System.Drawing.Point(387, 26);
            this.LBL_PERCHASE_NUM.Name = "LBL_PERCHASE_NUM";
            this.LBL_PERCHASE_NUM.Size = new System.Drawing.Size(95, 13);
            this.LBL_PERCHASE_NUM.TabIndex = 52;
            this.LBL_PERCHASE_NUM.Text = "Perchase Number:";
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
            // DGVTXT_PRO_NAME_KH
            // 
            this.DGVTXT_PRO_NAME_KH.HeaderText = "PRODUCT NAME KH";
            this.DGVTXT_PRO_NAME_KH.Name = "DGVTXT_PRO_NAME_KH";
            this.DGVTXT_PRO_NAME_KH.Width = 150;
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
            // TXT_DIS_AMT
            // 
            this.TXT_DIS_AMT.Location = new System.Drawing.Point(483, 76);
            this.TXT_DIS_AMT.Name = "TXT_DIS_AMT";
            this.TXT_DIS_AMT.Size = new System.Drawing.Size(147, 20);
            this.TXT_DIS_AMT.TabIndex = 54;
            // 
            // TXT_PERCHASE_NUM
            // 
            this.TXT_PERCHASE_NUM.Location = new System.Drawing.Point(483, 22);
            this.TXT_PERCHASE_NUM.Name = "TXT_PERCHASE_NUM";
            this.TXT_PERCHASE_NUM.Size = new System.Drawing.Size(147, 20);
            this.TXT_PERCHASE_NUM.TabIndex = 55;
            // 
            // TXT_DIS_PERCENT
            // 
            this.TXT_DIS_PERCENT.Location = new System.Drawing.Point(483, 49);
            this.TXT_DIS_PERCENT.Name = "TXT_DIS_PERCENT";
            this.TXT_DIS_PERCENT.Size = new System.Drawing.Size(147, 20);
            this.TXT_DIS_PERCENT.TabIndex = 56;
            // 
            // LBL_DIS_PERCENT
            // 
            this.LBL_DIS_PERCENT.AutoSize = true;
            this.LBL_DIS_PERCENT.Location = new System.Drawing.Point(387, 54);
            this.LBL_DIS_PERCENT.Name = "LBL_DIS_PERCENT";
            this.LBL_DIS_PERCENT.Size = new System.Drawing.Size(63, 13);
            this.LBL_DIS_PERCENT.TabIndex = 53;
            this.LBL_DIS_PERCENT.Text = "Discount %:";
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
            this.GRB_ADD_ORDER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRB_ADD_ORDER.Controls.Add(this.DTP_PERCHASE_DATE);
            this.GRB_ADD_ORDER.Controls.Add(this.comboBox1);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_OR);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_TOTAL_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.CMB_PAYMENT_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PAYMENT_STATUS);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_DIS_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PERCHASE_DATE);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PERCHASE_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_PERCHASE_NUM);
            this.GRB_ADD_ORDER.Controls.Add(this.LBL_DIS_PERCENT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_DIS_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_PERCHASE_ID);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_PERCHASE_NUM);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_TOTAL_AMT);
            this.GRB_ADD_ORDER.Controls.Add(this.TXT_DIS_PERCENT);
            this.GRB_ADD_ORDER.Controls.Add(this.DGV_ORDER);
            this.GRB_ADD_ORDER.Controls.Add(this.BTN_DELETE);
            this.GRB_ADD_ORDER.Location = new System.Drawing.Point(52, 57);
            this.GRB_ADD_ORDER.Name = "GRB_ADD_ORDER";
            this.GRB_ADD_ORDER.Size = new System.Drawing.Size(921, 627);
            this.GRB_ADD_ORDER.TabIndex = 56;
            this.GRB_ADD_ORDER.TabStop = false;
            // 
            // LBL_ADD_PERCHASE
            // 
            this.LBL_ADD_PERCHASE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_ADD_PERCHASE.AutoSize = true;
            this.LBL_ADD_PERCHASE.Location = new System.Drawing.Point(443, 23);
            this.LBL_ADD_PERCHASE.Name = "LBL_ADD_PERCHASE";
            this.LBL_ADD_PERCHASE.Size = new System.Drawing.Size(157, 13);
            this.LBL_ADD_PERCHASE.TabIndex = 52;
            this.LBL_ADD_PERCHASE.Text = "ADD INVENTORY PERCHASE";
            // 
            // LBL_OR
            // 
            this.LBL_OR.AutoSize = true;
            this.LBL_OR.Location = new System.Drawing.Point(146, 29);
            this.LBL_OR.Name = "LBL_OR";
            this.LBL_OR.Size = new System.Drawing.Size(44, 13);
            this.LBL_OR.TabIndex = 57;
            this.LBL_OR.Text = "Vendor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // TXT_PERCHASE_ID
            // 
            this.TXT_PERCHASE_ID.Enabled = false;
            this.TXT_PERCHASE_ID.Location = new System.Drawing.Point(219, 73);
            this.TXT_PERCHASE_ID.Name = "TXT_PERCHASE_ID";
            this.TXT_PERCHASE_ID.Size = new System.Drawing.Size(147, 20);
            this.TXT_PERCHASE_ID.TabIndex = 55;
            // 
            // LBL_PERCHASE_ID
            // 
            this.LBL_PERCHASE_ID.AutoSize = true;
            this.LBL_PERCHASE_ID.Location = new System.Drawing.Point(146, 76);
            this.LBL_PERCHASE_ID.Name = "LBL_PERCHASE_ID";
            this.LBL_PERCHASE_ID.Size = new System.Drawing.Size(67, 13);
            this.LBL_PERCHASE_ID.TabIndex = 52;
            this.LBL_PERCHASE_ID.Text = "Perchase Id:";
            // 
            // TXT_TOTAL_AMT
            // 
            this.TXT_TOTAL_AMT.Location = new System.Drawing.Point(743, 51);
            this.TXT_TOTAL_AMT.Name = "TXT_TOTAL_AMT";
            this.TXT_TOTAL_AMT.Size = new System.Drawing.Size(147, 20);
            this.TXT_TOTAL_AMT.TabIndex = 56;
            // 
            // FRM_INVENTORY_ADD_PERCHASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.GRB_ADD_ORDER);
            this.Controls.Add(this.LBL_ADD_PERCHASE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_INVENTORY_ADD_PERCHASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_INVENTORY_ADD_PERCHASE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDER)).EndInit();
            this.GRB_ADD_ORDER.ResumeLayout(false);
            this.GRB_ADD_ORDER.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EN;
        private System.Windows.Forms.DateTimePicker DTP_PERCHASE_DATE;
        private System.Windows.Forms.Label LBL_TOTAL_AMT;
        private System.Windows.Forms.ComboBox CMB_PAYMENT_STATUS;
        private System.Windows.Forms.Label LBL_PAYMENT_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_UNIT_COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_QUANTITY;
        private System.Windows.Forms.Label LBL_DIS_AMT;
        private System.Windows.Forms.Label LBL_PERCHASE_DATE;
        private System.Windows.Forms.Label LBL_PERCHASE_NUM;
        private System.Windows.Forms.DataGridView DGV_ORDER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_PRO_NAME_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_UNIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
        private System.Windows.Forms.TextBox TXT_DIS_AMT;
        private System.Windows.Forms.TextBox TXT_PERCHASE_NUM;
        private System.Windows.Forms.TextBox TXT_DIS_PERCENT;
        private System.Windows.Forms.Label LBL_DIS_PERCENT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.GroupBox GRB_ADD_ORDER;
        private System.Windows.Forms.Label LBL_ADD_PERCHASE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_OR;
        private System.Windows.Forms.Label LBL_PERCHASE_ID;
        private System.Windows.Forms.TextBox TXT_PERCHASE_ID;
        private System.Windows.Forms.TextBox TXT_TOTAL_AMT;
    }
}