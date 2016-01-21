namespace POS_Management
{
    partial class FRM_USER
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
            this.LBL_ROLE = new System.Windows.Forms.Label();
            this.LBL_NAME_KH = new System.Windows.Forms.Label();
            this.GRB_SEARCH = new System.Windows.Forms.GroupBox();
            this.CMB_ROLE = new System.Windows.Forms.ComboBox();
            this.TXT_NAME_KH = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.LBL_USER_ID = new System.Windows.Forms.Label();
            this.TXT_USER_ID = new System.Windows.Forms.TextBox();
            this.DGV_PRODUCT = new System.Windows.Forms.DataGridView();
            this.LBL_USER_LIST = new System.Windows.Forms.Label();
            this.BTN_PERMISSION = new System.Windows.Forms.Button();
            this.BTN_ROLE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_USER = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.TXT_NAME_EN = new System.Windows.Forms.TextBox();
            this.DGVCMB_PRODUCT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVTXT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_NAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_NAME_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTXT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVBTN_EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DGVBTN_DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GRB_SEARCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_ROLE
            // 
            this.LBL_ROLE.AutoSize = true;
            this.LBL_ROLE.Location = new System.Drawing.Point(23, 61);
            this.LBL_ROLE.Name = "LBL_ROLE";
            this.LBL_ROLE.Size = new System.Drawing.Size(32, 13);
            this.LBL_ROLE.TabIndex = 5;
            this.LBL_ROLE.Text = "Role:";
            // 
            // LBL_NAME_KH
            // 
            this.LBL_NAME_KH.AutoSize = true;
            this.LBL_NAME_KH.Location = new System.Drawing.Point(245, 28);
            this.LBL_NAME_KH.Name = "LBL_NAME_KH";
            this.LBL_NAME_KH.Size = new System.Drawing.Size(54, 13);
            this.LBL_NAME_KH.TabIndex = 5;
            this.LBL_NAME_KH.Text = "Name Kh:";
            // 
            // GRB_SEARCH
            // 
            this.GRB_SEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GRB_SEARCH.Controls.Add(this.CMB_ROLE);
            this.GRB_SEARCH.Controls.Add(this.LBL_ROLE);
            this.GRB_SEARCH.Controls.Add(this.TXT_NAME_EN);
            this.GRB_SEARCH.Controls.Add(this.TXT_NAME_KH);
            this.GRB_SEARCH.Controls.Add(this.LBL_NAME);
            this.GRB_SEARCH.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.GRB_SEARCH.Controls.Add(this.LBL_NAME_KH);
            this.GRB_SEARCH.Controls.Add(this.LBL_USER_ID);
            this.GRB_SEARCH.Controls.Add(this.TXT_USER_ID);
            this.GRB_SEARCH.Location = new System.Drawing.Point(468, 51);
            this.GRB_SEARCH.Name = "GRB_SEARCH";
            this.GRB_SEARCH.Size = new System.Drawing.Size(533, 90);
            this.GRB_SEARCH.TabIndex = 17;
            this.GRB_SEARCH.TabStop = false;
            this.GRB_SEARCH.Text = "Search Option";
            // 
            // CMB_ROLE
            // 
            this.CMB_ROLE.FormattingEnabled = true;
            this.CMB_ROLE.Location = new System.Drawing.Point(72, 58);
            this.CMB_ROLE.Name = "CMB_ROLE";
            this.CMB_ROLE.Size = new System.Drawing.Size(130, 21);
            this.CMB_ROLE.TabIndex = 7;
            // 
            // TXT_NAME_KH
            // 
            this.TXT_NAME_KH.Location = new System.Drawing.Point(310, 26);
            this.TXT_NAME_KH.Name = "TXT_NAME_KH";
            this.TXT_NAME_KH.Size = new System.Drawing.Size(111, 20);
            this.TXT_NAME_KH.TabIndex = 6;
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(445, 55);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(63, 23);
            this.BTN_SEARCH_PRODUCT.TabIndex = 8;
            this.BTN_SEARCH_PRODUCT.Text = "Search";
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = true;
            // 
            // LBL_USER_ID
            // 
            this.LBL_USER_ID.AutoSize = true;
            this.LBL_USER_ID.Location = new System.Drawing.Point(24, 29);
            this.LBL_USER_ID.Name = "LBL_USER_ID";
            this.LBL_USER_ID.Size = new System.Drawing.Size(21, 13);
            this.LBL_USER_ID.TabIndex = 5;
            this.LBL_USER_ID.Text = "ID:";
            // 
            // TXT_USER_ID
            // 
            this.TXT_USER_ID.Location = new System.Drawing.Point(72, 25);
            this.TXT_USER_ID.Name = "TXT_USER_ID";
            this.TXT_USER_ID.Size = new System.Drawing.Size(130, 20);
            this.TXT_USER_ID.TabIndex = 6;
            // 
            // DGV_PRODUCT
            // 
            this.DGV_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_PRODUCT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_PRODUCT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_PRODUCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCMB_PRODUCT,
            this.DGVTXT_ID,
            this.DGVTXT_NAME_EN,
            this.DGVTXT_NAME_KH,
            this.DGVTXT_USERNAME,
            this.DGVTXT_ROLE,
            this.DGVTXT_STATUS,
            this.DGVBTN_EDIT,
            this.DGVBTN_DELETE});
            this.DGV_PRODUCT.Location = new System.Drawing.Point(143, 160);
            this.DGV_PRODUCT.Name = "DGV_PRODUCT";
            this.DGV_PRODUCT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_PRODUCT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_PRODUCT.RowHeadersVisible = false;
            this.DGV_PRODUCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCT.Size = new System.Drawing.Size(863, 580);
            this.DGV_PRODUCT.TabIndex = 18;
            // 
            // LBL_USER_LIST
            // 
            this.LBL_USER_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_USER_LIST.AutoSize = true;
            this.LBL_USER_LIST.Location = new System.Drawing.Point(357, 9);
            this.LBL_USER_LIST.Name = "LBL_USER_LIST";
            this.LBL_USER_LIST.Size = new System.Drawing.Size(63, 13);
            this.LBL_USER_LIST.TabIndex = 16;
            this.LBL_USER_LIST.Text = "USER LIST";
            // 
            // BTN_PERMISSION
            // 
            this.BTN_PERMISSION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PERMISSION.Location = new System.Drawing.Point(19, 191);
            this.BTN_PERMISSION.Name = "BTN_PERMISSION";
            this.BTN_PERMISSION.Size = new System.Drawing.Size(94, 33);
            this.BTN_PERMISSION.TabIndex = 15;
            this.BTN_PERMISSION.Text = "PERMISSION";
            this.BTN_PERMISSION.UseVisualStyleBackColor = true;
            // 
            // BTN_ROLE
            // 
            this.BTN_ROLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROLE.Location = new System.Drawing.Point(19, 151);
            this.BTN_ROLE.Name = "BTN_ROLE";
            this.BTN_ROLE.Size = new System.Drawing.Size(94, 33);
            this.BTN_ROLE.TabIndex = 14;
            this.BTN_ROLE.Text = "ROLE";
            this.BTN_ROLE.UseVisualStyleBackColor = true;
            this.BTN_ROLE.Click += new System.EventHandler(this.BTN_ROLE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Location = new System.Drawing.Point(143, 118);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(63, 23);
            this.BTN_DELETE.TabIndex = 11;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Location = new System.Drawing.Point(143, 88);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(63, 23);
            this.BTN_ADD.TabIndex = 12;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // BTN_USER
            // 
            this.BTN_USER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_USER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_USER.Location = new System.Drawing.Point(19, 109);
            this.BTN_USER.Name = "BTN_USER";
            this.BTN_USER.Size = new System.Drawing.Size(94, 33);
            this.BTN_USER.TabIndex = 13;
            this.BTN_USER.Text = "USER";
            this.BTN_USER.UseVisualStyleBackColor = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 127;
            this.lineShape1.X2 = 127;
            this.lineShape1.Y1 = 51;
            this.lineShape1.Y2 = 743;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 768);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.AutoSize = true;
            this.LBL_NAME.Location = new System.Drawing.Point(245, 62);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(54, 13);
            this.LBL_NAME.TabIndex = 5;
            this.LBL_NAME.Text = "Name En:";
            // 
            // TXT_NAME_EN
            // 
            this.TXT_NAME_EN.Location = new System.Drawing.Point(310, 58);
            this.TXT_NAME_EN.Name = "TXT_NAME_EN";
            this.TXT_NAME_EN.Size = new System.Drawing.Size(111, 20);
            this.TXT_NAME_EN.TabIndex = 6;
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
            this.DGVTXT_ID.Width = 60;
            // 
            // DGVTXT_NAME_EN
            // 
            this.DGVTXT_NAME_EN.HeaderText = "NAME EN";
            this.DGVTXT_NAME_EN.Name = "DGVTXT_NAME_EN";
            this.DGVTXT_NAME_EN.Width = 170;
            // 
            // DGVTXT_NAME_KH
            // 
            this.DGVTXT_NAME_KH.HeaderText = "NAME_KH";
            this.DGVTXT_NAME_KH.Name = "DGVTXT_NAME_KH";
            this.DGVTXT_NAME_KH.Width = 170;
            // 
            // DGVTXT_USERNAME
            // 
            this.DGVTXT_USERNAME.HeaderText = "USERNAME";
            this.DGVTXT_USERNAME.Name = "DGVTXT_USERNAME";
            this.DGVTXT_USERNAME.Width = 96;
            // 
            // DGVTXT_ROLE
            // 
            this.DGVTXT_ROLE.HeaderText = "ROLE";
            this.DGVTXT_ROLE.Name = "DGVTXT_ROLE";
            this.DGVTXT_ROLE.Width = 95;
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
            // FRM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.GRB_SEARCH);
            this.Controls.Add(this.DGV_PRODUCT);
            this.Controls.Add(this.LBL_USER_LIST);
            this.Controls.Add(this.BTN_PERMISSION);
            this.Controls.Add(this.BTN_ROLE);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_USER);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_USER";
            this.Text = "FRM_USER";
            this.GRB_SEARCH.ResumeLayout(false);
            this.GRB_SEARCH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ROLE;
        private System.Windows.Forms.Label LBL_NAME_KH;
        private System.Windows.Forms.GroupBox GRB_SEARCH;
        private System.Windows.Forms.ComboBox CMB_ROLE;
        private System.Windows.Forms.TextBox TXT_NAME_KH;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.Label LBL_USER_ID;
        private System.Windows.Forms.TextBox TXT_USER_ID;
        private System.Windows.Forms.DataGridView DGV_PRODUCT;
        private System.Windows.Forms.Label LBL_USER_LIST;
        private System.Windows.Forms.Button BTN_PERMISSION;
        private System.Windows.Forms.Button BTN_ROLE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_USER;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox TXT_NAME_EN;
        private System.Windows.Forms.Label LBL_NAME;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGVCMB_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_NAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_NAME_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTXT_STATUS;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DGVBTN_DELETE;
    }
}