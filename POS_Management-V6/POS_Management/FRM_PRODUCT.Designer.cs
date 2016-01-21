namespace POS_Management
{
    partial class FRM_PRODUCT
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
            this.LBL_SEARCH_NAME = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.txtPro_Code = new System.Windows.Forms.TextBox();
            this.btnConf_del = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_PRODUCT_LIST = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPro = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlCate = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblProlist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_SEARCH_NAME
            // 
            this.LBL_SEARCH_NAME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_SEARCH_NAME.AutoSize = true;
            this.LBL_SEARCH_NAME.Location = new System.Drawing.Point(377, 30);
            this.LBL_SEARCH_NAME.Name = "LBL_SEARCH_NAME";
            this.LBL_SEARCH_NAME.Size = new System.Drawing.Size(59, 20);
            this.LBL_SEARCH_NAME.TabIndex = 5;
            this.LBL_SEARCH_NAME.Text = "Name: ";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXT_NAME.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_NAME.Location = new System.Drawing.Point(437, 27);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(149, 26);
            this.TXT_NAME.TabIndex = 6;
            this.TXT_NAME.TextChanged += new System.EventHandler(this.TXT_NAME_TextChanged);
            // 
            // BTN_SEARCH_PRODUCT
            // 
            this.BTN_SEARCH_PRODUCT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_SEARCH_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH_PRODUCT.Location = new System.Drawing.Point(603, 21);
            this.BTN_SEARCH_PRODUCT.Name = "BTN_SEARCH_PRODUCT";
            this.BTN_SEARCH_PRODUCT.Size = new System.Drawing.Size(92, 35);
            this.BTN_SEARCH_PRODUCT.TabIndex = 8;
            this.BTN_SEARCH_PRODUCT.Text = "Search";
            this.BTN_SEARCH_PRODUCT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddnew);
            this.groupBox2.Controls.Add(this.txtPro_Code);
            this.groupBox2.Controls.Add(this.btnConf_del);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.BTN_SEARCH_PRODUCT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LBL_SEARCH_NAME);
            this.groupBox2.Controls.Add(this.TXT_NAME);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1020, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnew.Location = new System.Drawing.Point(6, 19);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(126, 38);
            this.btnAddnew.TabIndex = 9;
            this.btnAddnew.Text = "+ ADD  NEW";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // txtPro_Code
            // 
            this.txtPro_Code.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPro_Code.BackColor = System.Drawing.SystemColors.Control;
            this.txtPro_Code.Location = new System.Drawing.Point(194, 27);
            this.txtPro_Code.Name = "txtPro_Code";
            this.txtPro_Code.Size = new System.Drawing.Size(177, 26);
            this.txtPro_Code.TabIndex = 6;
            this.txtPro_Code.TextChanged += new System.EventHandler(this.txtPro_Code_TextChanged);
            // 
            // btnConf_del
            // 
            this.btnConf_del.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConf_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf_del.Location = new System.Drawing.Point(781, 21);
            this.btnConf_del.Name = "btnConf_del";
            this.btnConf_del.Size = new System.Drawing.Size(127, 36);
            this.btnConf_del.TabIndex = 8;
            this.btnConf_del.Text = "&Confirm Delete";
            this.btnConf_del.UseVisualStyleBackColor = true;
            this.btnConf_del.Visible = false;
            this.btnConf_del.Click += new System.EventHandler(this.btnConf_del_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(914, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code:";
            // 
            // LBL_PRODUCT_LIST
            // 
            this.LBL_PRODUCT_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_PRODUCT_LIST.AutoSize = true;
            this.LBL_PRODUCT_LIST.Location = new System.Drawing.Point(378, 28);
            this.LBL_PRODUCT_LIST.Name = "LBL_PRODUCT_LIST";
            this.LBL_PRODUCT_LIST.Size = new System.Drawing.Size(86, 13);
            this.LBL_PRODUCT_LIST.TabIndex = 3;
            this.LBL_PRODUCT_LIST.Text = "PRODUCT LIST";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPro);
            this.panel1.Controls.Add(this.pnlFooter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 768);
            this.panel1.TabIndex = 10;
            // 
            // pnlPro
            // 
            this.pnlPro.AutoScroll = true;
            this.pnlPro.BackColor = System.Drawing.Color.LightGray;
            this.pnlPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPro.Location = new System.Drawing.Point(0, 118);
            this.pnlPro.Name = "pnlPro";
            this.pnlPro.Size = new System.Drawing.Size(1020, 461);
            this.pnlPro.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.pnlCate);
            this.pnlFooter.Controls.Add(this.panel5);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 579);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1020, 189);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlCate
            // 
            this.pnlCate.AutoScroll = true;
            this.pnlCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCate.Location = new System.Drawing.Point(0, 55);
            this.pnlCate.Name = "pnlCate";
            this.pnlCate.Size = new System.Drawing.Size(1020, 134);
            this.pnlCate.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 55);
            this.panel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pnlHead);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 118);
            this.panel3.TabIndex = 0;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Silver;
            this.pnlHead.Controls.Add(this.lblProlist);
            this.pnlHead.Controls.Add(this.groupBox2);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1020, 118);
            this.pnlHead.TabIndex = 11;
            // 
            // lblProlist
            // 
            this.lblProlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProlist.AutoSize = true;
            this.lblProlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProlist.Location = new System.Drawing.Point(477, 14);
            this.lblProlist.Name = "lblProlist";
            this.lblProlist.Size = new System.Drawing.Size(189, 29);
            this.lblProlist.TabIndex = 10;
            this.lblProlist.Text = "PRODUCT LIST";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1020, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_PRODUCT_LIST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PRODUCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_PRODUCT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_SEARCH_NAME;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.Button BTN_SEARCH_PRODUCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPro_Code;
        private System.Windows.Forms.Label LBL_PRODUCT_LIST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlCate;
        private System.Windows.Forms.Panel pnlPro;
        private System.Windows.Forms.Label lblProlist;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConf_del;
        private System.Windows.Forms.Button btnAddnew;
    }
}