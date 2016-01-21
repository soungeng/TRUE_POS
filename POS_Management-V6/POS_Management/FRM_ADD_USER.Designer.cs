namespace POS_Management
{
    partial class FRM_ADD_USER
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
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.LBL_ADDRESS_KH = new System.Windows.Forms.Label();
            this.LBL_ADDRESS_EN = new System.Windows.Forms.Label();
            this.LBL_DOB = new System.Windows.Forms.Label();
            this.LBL_CONFIRM_PASS = new System.Windows.Forms.Label();
            this.LBL_USERNAME = new System.Windows.Forms.Label();
            this.LBL_L_NAME_KH = new System.Windows.Forms.Label();
            this.LBL_F_NAME_KH = new System.Windows.Forms.Label();
            this.LBL_L_NAME_EN = new System.Windows.Forms.Label();
            this.LBL_USER_ID = new System.Windows.Forms.Label();
            this.LBL_F_NAME_EN = new System.Windows.Forms.Label();
            this.TXT_F_NAME_EN = new System.Windows.Forms.TextBox();
            this.TXT_ADDRESS_KH = new System.Windows.Forms.TextBox();
            this.TXT_ADDRESS_EN = new System.Windows.Forms.TextBox();
            this.LBL_ADD_USER = new System.Windows.Forms.Label();
            this.GRB_PRODUCT = new System.Windows.Forms.GroupBox();
            this.TXT_CONFIRM_PASS = new System.Windows.Forms.TextBox();
            this.TXT_PRICE = new System.Windows.Forms.TextBox();
            this.TXT_L_NAME_KH = new System.Windows.Forms.TextBox();
            this.TXT_F_NAME_KH = new System.Windows.Forms.TextBox();
            this.TXT_L_NAME_EN = new System.Windows.Forms.TextBox();
            this.TXT_USER_ID = new System.Windows.Forms.TextBox();
            this.CMB_STATUS = new System.Windows.Forms.ComboBox();
            this.LBL_PHONE = new System.Windows.Forms.Label();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.LBL_ROLE = new System.Windows.Forms.Label();
            this.CLB_ROLE = new System.Windows.Forms.CheckedListBox();
            this.CLB_SPECIAL_PER = new System.Windows.Forms.CheckedListBox();
            this.LBL_SPECIAL_PER = new System.Windows.Forms.Label();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.LBL_PASSWORD = new System.Windows.Forms.Label();
            this.DTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.TXT_PHONE = new System.Windows.Forms.TextBox();
            this.GRB_PRODUCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(885, 714);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(94, 33);
            this.BTN_CANCEL.TabIndex = 12;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Location = new System.Drawing.Point(776, 714);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(94, 33);
            this.BTN_SAVE.TabIndex = 13;
            this.BTN_SAVE.Text = "ADD";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR.Location = new System.Drawing.Point(666, 714);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(94, 33);
            this.BTN_CLEAR.TabIndex = 14;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            // 
            // LBL_ADDRESS_KH
            // 
            this.LBL_ADDRESS_KH.AutoSize = true;
            this.LBL_ADDRESS_KH.Location = new System.Drawing.Point(487, 134);
            this.LBL_ADDRESS_KH.Name = "LBL_ADDRESS_KH";
            this.LBL_ADDRESS_KH.Size = new System.Drawing.Size(64, 13);
            this.LBL_ADDRESS_KH.TabIndex = 32;
            this.LBL_ADDRESS_KH.Text = "Address Kh:";
            // 
            // LBL_ADDRESS_EN
            // 
            this.LBL_ADDRESS_EN.AutoSize = true;
            this.LBL_ADDRESS_EN.Location = new System.Drawing.Point(487, 100);
            this.LBL_ADDRESS_EN.Name = "LBL_ADDRESS_EN";
            this.LBL_ADDRESS_EN.Size = new System.Drawing.Size(64, 13);
            this.LBL_ADDRESS_EN.TabIndex = 31;
            this.LBL_ADDRESS_EN.Text = "Address En:";
            // 
            // LBL_DOB
            // 
            this.LBL_DOB.AutoSize = true;
            this.LBL_DOB.Location = new System.Drawing.Point(487, 66);
            this.LBL_DOB.Name = "LBL_DOB";
            this.LBL_DOB.Size = new System.Drawing.Size(71, 13);
            this.LBL_DOB.TabIndex = 30;
            this.LBL_DOB.Text = "Date Of Birth:";
            // 
            // LBL_CONFIRM_PASS
            // 
            this.LBL_CONFIRM_PASS.AutoSize = true;
            this.LBL_CONFIRM_PASS.Location = new System.Drawing.Point(487, 32);
            this.LBL_CONFIRM_PASS.Name = "LBL_CONFIRM_PASS";
            this.LBL_CONFIRM_PASS.Size = new System.Drawing.Size(94, 13);
            this.LBL_CONFIRM_PASS.TabIndex = 29;
            this.LBL_CONFIRM_PASS.Text = "Confirm Password:";
            // 
            // LBL_USERNAME
            // 
            this.LBL_USERNAME.AutoSize = true;
            this.LBL_USERNAME.Location = new System.Drawing.Point(50, 193);
            this.LBL_USERNAME.Name = "LBL_USERNAME";
            this.LBL_USERNAME.Size = new System.Drawing.Size(58, 13);
            this.LBL_USERNAME.TabIndex = 28;
            this.LBL_USERNAME.Text = "Username:";
            // 
            // LBL_L_NAME_KH
            // 
            this.LBL_L_NAME_KH.AutoSize = true;
            this.LBL_L_NAME_KH.Location = new System.Drawing.Point(50, 160);
            this.LBL_L_NAME_KH.Name = "LBL_L_NAME_KH";
            this.LBL_L_NAME_KH.Size = new System.Drawing.Size(77, 13);
            this.LBL_L_NAME_KH.TabIndex = 26;
            this.LBL_L_NAME_KH.Text = "Last Name Kh:";
            // 
            // LBL_F_NAME_KH
            // 
            this.LBL_F_NAME_KH.AutoSize = true;
            this.LBL_F_NAME_KH.Location = new System.Drawing.Point(50, 127);
            this.LBL_F_NAME_KH.Name = "LBL_F_NAME_KH";
            this.LBL_F_NAME_KH.Size = new System.Drawing.Size(76, 13);
            this.LBL_F_NAME_KH.TabIndex = 25;
            this.LBL_F_NAME_KH.Text = "First Name Kh:";
            // 
            // LBL_L_NAME_EN
            // 
            this.LBL_L_NAME_EN.AutoSize = true;
            this.LBL_L_NAME_EN.Location = new System.Drawing.Point(50, 94);
            this.LBL_L_NAME_EN.Name = "LBL_L_NAME_EN";
            this.LBL_L_NAME_EN.Size = new System.Drawing.Size(77, 13);
            this.LBL_L_NAME_EN.TabIndex = 24;
            this.LBL_L_NAME_EN.Text = "Last Name En:";
            // 
            // LBL_USER_ID
            // 
            this.LBL_USER_ID.AutoSize = true;
            this.LBL_USER_ID.Location = new System.Drawing.Point(50, 28);
            this.LBL_USER_ID.Name = "LBL_USER_ID";
            this.LBL_USER_ID.Size = new System.Drawing.Size(46, 13);
            this.LBL_USER_ID.TabIndex = 23;
            this.LBL_USER_ID.Text = "User ID:";
            // 
            // LBL_F_NAME_EN
            // 
            this.LBL_F_NAME_EN.AutoSize = true;
            this.LBL_F_NAME_EN.Location = new System.Drawing.Point(50, 61);
            this.LBL_F_NAME_EN.Name = "LBL_F_NAME_EN";
            this.LBL_F_NAME_EN.Size = new System.Drawing.Size(76, 13);
            this.LBL_F_NAME_EN.TabIndex = 23;
            this.LBL_F_NAME_EN.Text = "First Name En:";
            // 
            // TXT_F_NAME_EN
            // 
            this.TXT_F_NAME_EN.Location = new System.Drawing.Point(166, 61);
            this.TXT_F_NAME_EN.Name = "TXT_F_NAME_EN";
            this.TXT_F_NAME_EN.Size = new System.Drawing.Size(219, 20);
            this.TXT_F_NAME_EN.TabIndex = 22;
            // 
            // TXT_ADDRESS_KH
            // 
            this.TXT_ADDRESS_KH.Location = new System.Drawing.Point(603, 134);
            this.TXT_ADDRESS_KH.Name = "TXT_ADDRESS_KH";
            this.TXT_ADDRESS_KH.Size = new System.Drawing.Size(219, 20);
            this.TXT_ADDRESS_KH.TabIndex = 20;
            // 
            // TXT_ADDRESS_EN
            // 
            this.TXT_ADDRESS_EN.Location = new System.Drawing.Point(603, 100);
            this.TXT_ADDRESS_EN.Name = "TXT_ADDRESS_EN";
            this.TXT_ADDRESS_EN.Size = new System.Drawing.Size(219, 20);
            this.TXT_ADDRESS_EN.TabIndex = 19;
            // 
            // LBL_ADD_USER
            // 
            this.LBL_ADD_USER.AutoSize = true;
            this.LBL_ADD_USER.Location = new System.Drawing.Point(451, 22);
            this.LBL_ADD_USER.Name = "LBL_ADD_USER";
            this.LBL_ADD_USER.Size = new System.Drawing.Size(63, 13);
            this.LBL_ADD_USER.TabIndex = 10;
            this.LBL_ADD_USER.Text = "ADD USER";
            // 
            // GRB_PRODUCT
            // 
            this.GRB_PRODUCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GRB_PRODUCT.Controls.Add(this.DTP_DOB);
            this.GRB_PRODUCT.Controls.Add(this.LBL_SPECIAL_PER);
            this.GRB_PRODUCT.Controls.Add(this.LBL_ROLE);
            this.GRB_PRODUCT.Controls.Add(this.CLB_SPECIAL_PER);
            this.GRB_PRODUCT.Controls.Add(this.CLB_ROLE);
            this.GRB_PRODUCT.Controls.Add(this.LBL_ADDRESS_KH);
            this.GRB_PRODUCT.Controls.Add(this.LBL_ADDRESS_EN);
            this.GRB_PRODUCT.Controls.Add(this.LBL_DOB);
            this.GRB_PRODUCT.Controls.Add(this.LBL_CONFIRM_PASS);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PASSWORD);
            this.GRB_PRODUCT.Controls.Add(this.LBL_USERNAME);
            this.GRB_PRODUCT.Controls.Add(this.LBL_L_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.LBL_F_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.LBL_L_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.LBL_USER_ID);
            this.GRB_PRODUCT.Controls.Add(this.LBL_F_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_F_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PHONE);
            this.GRB_PRODUCT.Controls.Add(this.TXT_ADDRESS_KH);
            this.GRB_PRODUCT.Controls.Add(this.TXT_ADDRESS_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_CONFIRM_PASS);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PASSWORD);
            this.GRB_PRODUCT.Controls.Add(this.TXT_PRICE);
            this.GRB_PRODUCT.Controls.Add(this.TXT_L_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.TXT_F_NAME_KH);
            this.GRB_PRODUCT.Controls.Add(this.TXT_L_NAME_EN);
            this.GRB_PRODUCT.Controls.Add(this.TXT_USER_ID);
            this.GRB_PRODUCT.Controls.Add(this.CMB_STATUS);
            this.GRB_PRODUCT.Controls.Add(this.LBL_PHONE);
            this.GRB_PRODUCT.Controls.Add(this.LBL_STATUS);
            this.GRB_PRODUCT.Location = new System.Drawing.Point(46, 52);
            this.GRB_PRODUCT.Name = "GRB_PRODUCT";
            this.GRB_PRODUCT.Size = new System.Drawing.Size(933, 647);
            this.GRB_PRODUCT.TabIndex = 11;
            this.GRB_PRODUCT.TabStop = false;
            // 
            // TXT_CONFIRM_PASS
            // 
            this.TXT_CONFIRM_PASS.Location = new System.Drawing.Point(603, 32);
            this.TXT_CONFIRM_PASS.Name = "TXT_CONFIRM_PASS";
            this.TXT_CONFIRM_PASS.Size = new System.Drawing.Size(219, 20);
            this.TXT_CONFIRM_PASS.TabIndex = 17;
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Location = new System.Drawing.Point(166, 193);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(219, 20);
            this.TXT_PRICE.TabIndex = 16;
            // 
            // TXT_L_NAME_KH
            // 
            this.TXT_L_NAME_KH.Location = new System.Drawing.Point(166, 160);
            this.TXT_L_NAME_KH.Name = "TXT_L_NAME_KH";
            this.TXT_L_NAME_KH.Size = new System.Drawing.Size(219, 20);
            this.TXT_L_NAME_KH.TabIndex = 15;
            // 
            // TXT_F_NAME_KH
            // 
            this.TXT_F_NAME_KH.Location = new System.Drawing.Point(166, 127);
            this.TXT_F_NAME_KH.Name = "TXT_F_NAME_KH";
            this.TXT_F_NAME_KH.Size = new System.Drawing.Size(219, 20);
            this.TXT_F_NAME_KH.TabIndex = 14;
            // 
            // TXT_L_NAME_EN
            // 
            this.TXT_L_NAME_EN.Location = new System.Drawing.Point(166, 94);
            this.TXT_L_NAME_EN.Name = "TXT_L_NAME_EN";
            this.TXT_L_NAME_EN.Size = new System.Drawing.Size(219, 20);
            this.TXT_L_NAME_EN.TabIndex = 13;
            // 
            // TXT_USER_ID
            // 
            this.TXT_USER_ID.Enabled = false;
            this.TXT_USER_ID.Location = new System.Drawing.Point(166, 28);
            this.TXT_USER_ID.Name = "TXT_USER_ID";
            this.TXT_USER_ID.Size = new System.Drawing.Size(219, 20);
            this.TXT_USER_ID.TabIndex = 21;
            // 
            // CMB_STATUS
            // 
            this.CMB_STATUS.FormattingEnabled = true;
            this.CMB_STATUS.Location = new System.Drawing.Point(603, 202);
            this.CMB_STATUS.Name = "CMB_STATUS";
            this.CMB_STATUS.Size = new System.Drawing.Size(219, 21);
            this.CMB_STATUS.TabIndex = 10;
            // 
            // LBL_PHONE
            // 
            this.LBL_PHONE.AutoSize = true;
            this.LBL_PHONE.Location = new System.Drawing.Point(487, 168);
            this.LBL_PHONE.Name = "LBL_PHONE";
            this.LBL_PHONE.Size = new System.Drawing.Size(81, 13);
            this.LBL_PHONE.TabIndex = 6;
            this.LBL_PHONE.Text = "Phone Number:";
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Location = new System.Drawing.Point(487, 202);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(40, 13);
            this.LBL_STATUS.TabIndex = 8;
            this.LBL_STATUS.Text = "Status:";
            // 
            // LBL_ROLE
            // 
            this.LBL_ROLE.AutoSize = true;
            this.LBL_ROLE.Location = new System.Drawing.Point(50, 256);
            this.LBL_ROLE.Name = "LBL_ROLE";
            this.LBL_ROLE.Size = new System.Drawing.Size(32, 13);
            this.LBL_ROLE.TabIndex = 34;
            this.LBL_ROLE.Text = "Role:";
            // 
            // CLB_ROLE
            // 
            this.CLB_ROLE.FormattingEnabled = true;
            this.CLB_ROLE.Location = new System.Drawing.Point(51, 274);
            this.CLB_ROLE.Name = "CLB_ROLE";
            this.CLB_ROLE.Size = new System.Drawing.Size(401, 349);
            this.CLB_ROLE.TabIndex = 33;
            // 
            // CLB_SPECIAL_PER
            // 
            this.CLB_SPECIAL_PER.FormattingEnabled = true;
            this.CLB_SPECIAL_PER.Location = new System.Drawing.Point(489, 274);
            this.CLB_SPECIAL_PER.Name = "CLB_SPECIAL_PER";
            this.CLB_SPECIAL_PER.Size = new System.Drawing.Size(401, 349);
            this.CLB_SPECIAL_PER.TabIndex = 33;
            // 
            // LBL_SPECIAL_PER
            // 
            this.LBL_SPECIAL_PER.AutoSize = true;
            this.LBL_SPECIAL_PER.Location = new System.Drawing.Point(487, 252);
            this.LBL_SPECIAL_PER.Name = "LBL_SPECIAL_PER";
            this.LBL_SPECIAL_PER.Size = new System.Drawing.Size(98, 13);
            this.LBL_SPECIAL_PER.TabIndex = 34;
            this.LBL_SPECIAL_PER.Text = "Special Permission:";
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(166, 223);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.Size = new System.Drawing.Size(219, 20);
            this.TXT_PASSWORD.TabIndex = 16;
            // 
            // LBL_PASSWORD
            // 
            this.LBL_PASSWORD.AutoSize = true;
            this.LBL_PASSWORD.Location = new System.Drawing.Point(50, 223);
            this.LBL_PASSWORD.Name = "LBL_PASSWORD";
            this.LBL_PASSWORD.Size = new System.Drawing.Size(56, 13);
            this.LBL_PASSWORD.TabIndex = 28;
            this.LBL_PASSWORD.Text = "Password:";
            // 
            // DTP_DOB
            // 
            this.DTP_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DOB.Location = new System.Drawing.Point(603, 66);
            this.DTP_DOB.Name = "DTP_DOB";
            this.DTP_DOB.Size = new System.Drawing.Size(219, 20);
            this.DTP_DOB.TabIndex = 35;
            // 
            // TXT_PHONE
            // 
            this.TXT_PHONE.Location = new System.Drawing.Point(603, 168);
            this.TXT_PHONE.Name = "TXT_PHONE";
            this.TXT_PHONE.Size = new System.Drawing.Size(219, 20);
            this.TXT_PHONE.TabIndex = 20;
            // 
            // FRM_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.LBL_ADD_USER);
            this.Controls.Add(this.GRB_PRODUCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ADD_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD_USER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GRB_PRODUCT.ResumeLayout(false);
            this.GRB_PRODUCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Label LBL_ADDRESS_KH;
        private System.Windows.Forms.Label LBL_ADDRESS_EN;
        private System.Windows.Forms.Label LBL_DOB;
        private System.Windows.Forms.Label LBL_CONFIRM_PASS;
        private System.Windows.Forms.Label LBL_USERNAME;
        private System.Windows.Forms.Label LBL_L_NAME_KH;
        private System.Windows.Forms.Label LBL_F_NAME_KH;
        private System.Windows.Forms.Label LBL_L_NAME_EN;
        private System.Windows.Forms.Label LBL_USER_ID;
        private System.Windows.Forms.Label LBL_F_NAME_EN;
        private System.Windows.Forms.TextBox TXT_F_NAME_EN;
        private System.Windows.Forms.TextBox TXT_ADDRESS_KH;
        private System.Windows.Forms.TextBox TXT_ADDRESS_EN;
        private System.Windows.Forms.Label LBL_ADD_USER;
        private System.Windows.Forms.GroupBox GRB_PRODUCT;
        private System.Windows.Forms.Label LBL_ROLE;
        private System.Windows.Forms.CheckedListBox CLB_ROLE;
        private System.Windows.Forms.TextBox TXT_CONFIRM_PASS;
        private System.Windows.Forms.TextBox TXT_PRICE;
        private System.Windows.Forms.TextBox TXT_L_NAME_KH;
        private System.Windows.Forms.TextBox TXT_F_NAME_KH;
        private System.Windows.Forms.TextBox TXT_L_NAME_EN;
        private System.Windows.Forms.TextBox TXT_USER_ID;
        private System.Windows.Forms.ComboBox CMB_STATUS;
        private System.Windows.Forms.Label LBL_PHONE;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Label LBL_SPECIAL_PER;
        private System.Windows.Forms.CheckedListBox CLB_SPECIAL_PER;
        private System.Windows.Forms.Label LBL_PASSWORD;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.DateTimePicker DTP_DOB;
        private System.Windows.Forms.TextBox TXT_PHONE;
    }
}