namespace POS_Management
{
    partial class FRM_ADD_CATEGORY
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
            this.LBL_NAME_KH = new System.Windows.Forms.Label();
            this.LBL_NAME_EN = new System.Windows.Forms.Label();
            this.TXT_NAME_KH = new System.Windows.Forms.TextBox();
            this.TXT_PRO_NAME_EN = new System.Windows.Forms.TextBox();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.LBL_ADD_CATEGORY = new System.Windows.Forms.Label();
            this.GRB_PRODUCT = new System.Windows.Forms.GroupBox();
            this.CMB_PARENT_CAT = new System.Windows.Forms.ComboBox();
            this.LBL_PARENT_CAT = new System.Windows.Forms.Label();
            this.LBL_PRO_ID = new System.Windows.Forms.Label();
            this.TXT_PRO_ID = new System.Windows.Forms.TextBox();
            this.pnlCat = new System.Windows.Forms.Panel();
            this.GRB_PRODUCT.SuspendLayout();
            this.pnlCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_NAME_KH
            // 
            this.LBL_NAME_KH.AutoSize = true;
            this.LBL_NAME_KH.Location = new System.Drawing.Point(57, 131);
            this.LBL_NAME_KH.Name = "LBL_NAME_KH";
            this.LBL_NAME_KH.Size = new System.Drawing.Size(78, 20);
            this.LBL_NAME_KH.TabIndex = 26;
            this.LBL_NAME_KH.Text = "Name Kh:";
            // 
            // LBL_NAME_EN
            // 
            this.LBL_NAME_EN.AutoSize = true;
            this.LBL_NAME_EN.Location = new System.Drawing.Point(57, 89);
            this.LBL_NAME_EN.Name = "LBL_NAME_EN";
            this.LBL_NAME_EN.Size = new System.Drawing.Size(79, 20);
            this.LBL_NAME_EN.TabIndex = 25;
            this.LBL_NAME_EN.Text = "Name En:";
            // 
            // TXT_NAME_KH
            // 
            this.TXT_NAME_KH.Location = new System.Drawing.Point(202, 131);
            this.TXT_NAME_KH.Name = "TXT_NAME_KH";
            this.TXT_NAME_KH.Size = new System.Drawing.Size(221, 26);
            this.TXT_NAME_KH.TabIndex = 15;
            // 
            // TXT_PRO_NAME_EN
            // 
            this.TXT_PRO_NAME_EN.Location = new System.Drawing.Point(202, 89);
            this.TXT_PRO_NAME_EN.Name = "TXT_PRO_NAME_EN";
            this.TXT_PRO_NAME_EN.Size = new System.Drawing.Size(221, 26);
            this.TXT_PRO_NAME_EN.TabIndex = 14;
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(202, 215);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(221, 28);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(57, 214);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(60, 20);
            this.LBL_STATUS.TabIndex = 8;
            this.LBL_STATUS.Text = "Status:";
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(411, 377);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(94, 33);
            this.BTN_CANCEL.TabIndex = 12;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(302, 377);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(94, 33);
            this.BTN_SAVE.TabIndex = 13;
            this.BTN_SAVE.Text = "ADD";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR.Location = new System.Drawing.Point(192, 377);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(94, 33);
            this.BTN_CLEAR.TabIndex = 14;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            // 
            // LBL_ADD_CATEGORY
            // 
            this.LBL_ADD_CATEGORY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_ADD_CATEGORY.AutoSize = true;
            this.LBL_ADD_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ADD_CATEGORY.Location = new System.Drawing.Point(200, 20);
            this.LBL_ADD_CATEGORY.Name = "LBL_ADD_CATEGORY";
            this.LBL_ADD_CATEGORY.Size = new System.Drawing.Size(171, 25);
            this.LBL_ADD_CATEGORY.TabIndex = 10;
            this.LBL_ADD_CATEGORY.Text = "ADD CATEGORY";
            // 
            // GRB_PRODUCT
            // 
            this.GRB_PRODUCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GRB_PRODUCT.Controls.Add(this.CMB_PARENT_CAT);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PARENT_CAT);
            this.GRB_PRODUCT.Controls.Add(this.LBL_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.LBL_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PRO_ID);
            this.GRB_PRODUCT.Controls.Add(this.TXT_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRO_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRO_ID);
            this.GRB_PRODUCT.Controls.Add(this.CMB_STATUS);
            this.GRB_PRODUCT.Controls.Add(this.LBL_STATUS);
            this.GRB_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRB_PRODUCT.Location = new System.Drawing.Point(44, 66);
            this.GRB_PRODUCT.Name = "GRB_PRODUCT";
            this.GRB_PRODUCT.Size = new System.Drawing.Size(461, 287);
            this.GRB_PRODUCT.TabIndex = 11;
            this.GRB_PRODUCT.TabStop = false;
            // 
            // CMB_PARENT_CAT
            // 
            this.CMB_PARENT_CAT.FormattingEnabled = true;
            this.CMB_PARENT_CAT.Location = new System.Drawing.Point(202, 172);
            this.CMB_PARENT_CAT.Name = "CMB_PARENT_CAT";
            this.CMB_PARENT_CAT.Size = new System.Drawing.Size(221, 28);
            this.CMB_PARENT_CAT.TabIndex = 28;
            // 
            // LBL_PARENT_CAT
            // 
            this.LBL_PARENT_CAT.AutoSize = true;
            this.LBL_PARENT_CAT.Location = new System.Drawing.Point(57, 172);
            this.LBL_PARENT_CAT.Name = "LBL_PARENT_CAT";
            this.LBL_PARENT_CAT.Size = new System.Drawing.Size(128, 20);
            this.LBL_PARENT_CAT.TabIndex = 27;
            this.LBL_PARENT_CAT.Text = "Parent Category:";
            // 
            // LBL_PRO_ID
            // 
            this.LBL_PRO_ID.AutoSize = true;
            this.LBL_PRO_ID.Location = new System.Drawing.Point(57, 48);
            this.LBL_PRO_ID.Name = "LBL_PRO_ID";
            this.LBL_PRO_ID.Size = new System.Drawing.Size(26, 20);
            this.LBL_PRO_ID.TabIndex = 23;
            this.LBL_PRO_ID.Text = "ID";
            // 
            // TXT_PRO_ID
            // 
            this.TXT_PRO_ID.Enabled = false;
            this.TXT_PRO_ID.Location = new System.Drawing.Point(202, 48);
            this.TXT_PRO_ID.Name = "TXT_PRO_ID";
            this.TXT_PRO_ID.Size = new System.Drawing.Size(221, 26);
            this.TXT_PRO_ID.TabIndex = 21;
            // 
            // pnlCat
            // 
            this.pnlCat.Controls.Add(this.LBL_ADD_CATEGORY);
            this.pnlCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCat.Location = new System.Drawing.Point(0, 0);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(564, 73);
            this.pnlCat.TabIndex = 15;
            // 
            // FRM_ADD_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(564, 440);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.pnlCat);
            this.Controls.Add(this.GRB_PRODUCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_CATEGORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD_CATEGORY";
            this.Load += new System.EventHandler(this.FRM_ADD_CATEGORY_Load);
            this.GRB_PRODUCT.ResumeLayout(false);
            this.GRB_PRODUCT.PerformLayout();
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_NAME_KH;
        private System.Windows.Forms.Label LBL_NAME_EN;
        private System.Windows.Forms.TextBox TXT_NAME_KH;
        private System.Windows.Forms.TextBox TXT_PRO_NAME_EN;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Label LBL_ADD_CATEGORY;
        private System.Windows.Forms.GroupBox GRB_PRODUCT;
        private System.Windows.Forms.ComboBox CMB_PARENT_CAT;
        private System.Windows.Forms.Label LBL_PARENT_CAT;
        private System.Windows.Forms.Label LBL_PRO_ID;
        private System.Windows.Forms.TextBox TXT_PRO_ID;
        private System.Windows.Forms.Panel pnlCat;
    }
}