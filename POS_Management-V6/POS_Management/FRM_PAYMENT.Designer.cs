namespace POS_Management
{
    partial class FRM_PAYMENT
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
            this.LBL_UNPAID_INVOICE_LIST = new System.Windows.Forms.Label();
            this.LBL_INV_NUM = new System.Windows.Forms.Label();
            this.TXT_INV_NUM = new System.Windows.Forms.TextBox();
            this.TXT_TOTAL_USD = new System.Windows.Forms.TextBox();
            this.LBL_GRANT_TOTAL = new System.Windows.Forms.Label();
            this.LBL_USD = new System.Windows.Forms.Label();
            this.TXT_TOTAL_KHR = new System.Windows.Forms.TextBox();
            this.LBL_KHR = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BTN_PAY_BY_CASH = new System.Windows.Forms.Button();
            this.BTN_PAY_BY_CARD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_BALANCE_USD = new System.Windows.Forms.TextBox();
            this.TXT_BALANCE_KHR = new System.Windows.Forms.TextBox();
            this.LBL_BALANCE = new System.Windows.Forms.Label();
            this.LBL_BALANCE_USD = new System.Windows.Forms.Label();
            this.LBL_BALANCE_KHR = new System.Windows.Forms.Label();
            this.LBL_CHANGE_USD = new System.Windows.Forms.Label();
            this.LBL_CHANGE_KHR = new System.Windows.Forms.Label();
            this.LBL_CHANGE = new System.Windows.Forms.Label();
            this.TXT_CHANGE_USD = new System.Windows.Forms.TextBox();
            this.TXT_CHANGE_KHR = new System.Windows.Forms.TextBox();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_PRINT_INV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_UNPAID_INVOICE_LIST
            // 
            this.LBL_UNPAID_INVOICE_LIST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_UNPAID_INVOICE_LIST.AutoSize = true;
            this.LBL_UNPAID_INVOICE_LIST.Location = new System.Drawing.Point(446, 9);
            this.LBL_UNPAID_INVOICE_LIST.Name = "LBL_UNPAID_INVOICE_LIST";
            this.LBL_UNPAID_INVOICE_LIST.Size = new System.Drawing.Size(120, 13);
            this.LBL_UNPAID_INVOICE_LIST.TabIndex = 20;
            this.LBL_UNPAID_INVOICE_LIST.Text = "UNPAID INVOICE LIST";
            // 
            // LBL_INV_NUM
            // 
            this.LBL_INV_NUM.AutoSize = true;
            this.LBL_INV_NUM.Location = new System.Drawing.Point(225, 77);
            this.LBL_INV_NUM.Name = "LBL_INV_NUM";
            this.LBL_INV_NUM.Size = new System.Drawing.Size(85, 13);
            this.LBL_INV_NUM.TabIndex = 21;
            this.LBL_INV_NUM.Text = "Invoice Number:";
            // 
            // TXT_INV_NUM
            // 
            this.TXT_INV_NUM.Enabled = false;
            this.TXT_INV_NUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_INV_NUM.Location = new System.Drawing.Point(340, 70);
            this.TXT_INV_NUM.Name = "TXT_INV_NUM";
            this.TXT_INV_NUM.Size = new System.Drawing.Size(197, 29);
            this.TXT_INV_NUM.TabIndex = 22;
            // 
            // TXT_TOTAL_USD
            // 
            this.TXT_TOTAL_USD.Enabled = false;
            this.TXT_TOTAL_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL_USD.Location = new System.Drawing.Point(340, 105);
            this.TXT_TOTAL_USD.Name = "TXT_TOTAL_USD";
            this.TXT_TOTAL_USD.Size = new System.Drawing.Size(197, 29);
            this.TXT_TOTAL_USD.TabIndex = 22;
            // 
            // LBL_GRANT_TOTAL
            // 
            this.LBL_GRANT_TOTAL.AutoSize = true;
            this.LBL_GRANT_TOTAL.Location = new System.Drawing.Point(225, 112);
            this.LBL_GRANT_TOTAL.Name = "LBL_GRANT_TOTAL";
            this.LBL_GRANT_TOTAL.Size = new System.Drawing.Size(63, 13);
            this.LBL_GRANT_TOTAL.TabIndex = 21;
            this.LBL_GRANT_TOTAL.Text = "Grant Total:";
            // 
            // LBL_USD
            // 
            this.LBL_USD.AutoSize = true;
            this.LBL_USD.Location = new System.Drawing.Point(543, 108);
            this.LBL_USD.Name = "LBL_USD";
            this.LBL_USD.Size = new System.Drawing.Size(30, 13);
            this.LBL_USD.TabIndex = 21;
            this.LBL_USD.Text = "USD";
            // 
            // TXT_TOTAL_KHR
            // 
            this.TXT_TOTAL_KHR.Enabled = false;
            this.TXT_TOTAL_KHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL_KHR.Location = new System.Drawing.Point(615, 105);
            this.TXT_TOTAL_KHR.Name = "TXT_TOTAL_KHR";
            this.TXT_TOTAL_KHR.Size = new System.Drawing.Size(197, 29);
            this.TXT_TOTAL_KHR.TabIndex = 22;
            // 
            // LBL_KHR
            // 
            this.LBL_KHR.AutoSize = true;
            this.LBL_KHR.Location = new System.Drawing.Point(819, 108);
            this.LBL_KHR.Name = "LBL_KHR";
            this.LBL_KHR.Size = new System.Drawing.Size(30, 13);
            this.LBL_KHR.TabIndex = 21;
            this.LBL_KHR.Text = "KHR";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 768);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 584;
            this.lineShape1.X2 = 584;
            this.lineShape1.Y1 = 107;
            this.lineShape1.Y2 = 121;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 229;
            this.lineShape2.X2 = 847;
            this.lineShape2.Y1 = 153;
            this.lineShape2.Y2 = 153;
            // 
            // BTN_PAY_BY_CASH
            // 
            this.BTN_PAY_BY_CASH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PAY_BY_CASH.Location = new System.Drawing.Point(229, 186);
            this.BTN_PAY_BY_CASH.Name = "BTN_PAY_BY_CASH";
            this.BTN_PAY_BY_CASH.Size = new System.Drawing.Size(308, 53);
            this.BTN_PAY_BY_CASH.TabIndex = 24;
            this.BTN_PAY_BY_CASH.Text = "PAY BY CASH";
            this.BTN_PAY_BY_CASH.UseVisualStyleBackColor = true;
            // 
            // BTN_PAY_BY_CARD
            // 
            this.BTN_PAY_BY_CARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PAY_BY_CARD.Location = new System.Drawing.Point(546, 186);
            this.BTN_PAY_BY_CARD.Name = "BTN_PAY_BY_CARD";
            this.BTN_PAY_BY_CARD.Size = new System.Drawing.Size(308, 53);
            this.BTN_PAY_BY_CARD.TabIndex = 24;
            this.BTN_PAY_BY_CARD.Text = "PAY BY CARD";
            this.BTN_PAY_BY_CARD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXT_CHANGE_KHR);
            this.panel1.Controls.Add(this.TXT_BALANCE_KHR);
            this.panel1.Controls.Add(this.TXT_CHANGE_USD);
            this.panel1.Controls.Add(this.LBL_CHANGE);
            this.panel1.Controls.Add(this.TXT_BALANCE_USD);
            this.panel1.Controls.Add(this.LBL_CHANGE_KHR);
            this.panel1.Controls.Add(this.LBL_BALANCE);
            this.panel1.Controls.Add(this.LBL_CHANGE_USD);
            this.panel1.Controls.Add(this.LBL_BALANCE_KHR);
            this.panel1.Controls.Add(this.LBL_BALANCE_USD);
            this.panel1.Location = new System.Drawing.Point(229, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 174);
            this.panel1.TabIndex = 25;
            // 
            // TXT_BALANCE_USD
            // 
            this.TXT_BALANCE_USD.Enabled = false;
            this.TXT_BALANCE_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_BALANCE_USD.Location = new System.Drawing.Point(22, 55);
            this.TXT_BALANCE_USD.Name = "TXT_BALANCE_USD";
            this.TXT_BALANCE_USD.Size = new System.Drawing.Size(197, 29);
            this.TXT_BALANCE_USD.TabIndex = 22;
            // 
            // TXT_BALANCE_KHR
            // 
            this.TXT_BALANCE_KHR.Enabled = false;
            this.TXT_BALANCE_KHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_BALANCE_KHR.Location = new System.Drawing.Point(22, 90);
            this.TXT_BALANCE_KHR.Name = "TXT_BALANCE_KHR";
            this.TXT_BALANCE_KHR.Size = new System.Drawing.Size(197, 29);
            this.TXT_BALANCE_KHR.TabIndex = 22;
            // 
            // LBL_BALANCE
            // 
            this.LBL_BALANCE.AutoSize = true;
            this.LBL_BALANCE.Location = new System.Drawing.Point(19, 23);
            this.LBL_BALANCE.Name = "LBL_BALANCE";
            this.LBL_BALANCE.Size = new System.Drawing.Size(59, 13);
            this.LBL_BALANCE.TabIndex = 21;
            this.LBL_BALANCE.Text = "BALANCE:";
            // 
            // LBL_BALANCE_USD
            // 
            this.LBL_BALANCE_USD.AutoSize = true;
            this.LBL_BALANCE_USD.Location = new System.Drawing.Point(225, 66);
            this.LBL_BALANCE_USD.Name = "LBL_BALANCE_USD";
            this.LBL_BALANCE_USD.Size = new System.Drawing.Size(30, 13);
            this.LBL_BALANCE_USD.TabIndex = 21;
            this.LBL_BALANCE_USD.Text = "USD";
            // 
            // LBL_BALANCE_KHR
            // 
            this.LBL_BALANCE_KHR.AutoSize = true;
            this.LBL_BALANCE_KHR.Location = new System.Drawing.Point(225, 101);
            this.LBL_BALANCE_KHR.Name = "LBL_BALANCE_KHR";
            this.LBL_BALANCE_KHR.Size = new System.Drawing.Size(30, 13);
            this.LBL_BALANCE_KHR.TabIndex = 21;
            this.LBL_BALANCE_KHR.Text = "KHR";
            // 
            // LBL_CHANGE_USD
            // 
            this.LBL_CHANGE_USD.AutoSize = true;
            this.LBL_CHANGE_USD.Location = new System.Drawing.Point(520, 61);
            this.LBL_CHANGE_USD.Name = "LBL_CHANGE_USD";
            this.LBL_CHANGE_USD.Size = new System.Drawing.Size(30, 13);
            this.LBL_CHANGE_USD.TabIndex = 21;
            this.LBL_CHANGE_USD.Text = "USD";
            // 
            // LBL_CHANGE_KHR
            // 
            this.LBL_CHANGE_KHR.AutoSize = true;
            this.LBL_CHANGE_KHR.Location = new System.Drawing.Point(520, 96);
            this.LBL_CHANGE_KHR.Name = "LBL_CHANGE_KHR";
            this.LBL_CHANGE_KHR.Size = new System.Drawing.Size(30, 13);
            this.LBL_CHANGE_KHR.TabIndex = 21;
            this.LBL_CHANGE_KHR.Text = "KHR";
            // 
            // LBL_CHANGE
            // 
            this.LBL_CHANGE.AutoSize = true;
            this.LBL_CHANGE.Location = new System.Drawing.Point(314, 18);
            this.LBL_CHANGE.Name = "LBL_CHANGE";
            this.LBL_CHANGE.Size = new System.Drawing.Size(55, 13);
            this.LBL_CHANGE.TabIndex = 21;
            this.LBL_CHANGE.Text = "CHANGE:";
            // 
            // TXT_CHANGE_USD
            // 
            this.TXT_CHANGE_USD.Enabled = false;
            this.TXT_CHANGE_USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CHANGE_USD.Location = new System.Drawing.Point(317, 50);
            this.TXT_CHANGE_USD.Name = "TXT_CHANGE_USD";
            this.TXT_CHANGE_USD.Size = new System.Drawing.Size(197, 29);
            this.TXT_CHANGE_USD.TabIndex = 22;
            // 
            // TXT_CHANGE_KHR
            // 
            this.TXT_CHANGE_KHR.Enabled = false;
            this.TXT_CHANGE_KHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CHANGE_KHR.Location = new System.Drawing.Point(317, 85);
            this.TXT_CHANGE_KHR.Name = "TXT_CHANGE_KHR";
            this.TXT_CHANGE_KHR.Size = new System.Drawing.Size(197, 29);
            this.TXT_CHANGE_KHR.TabIndex = 22;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Location = new System.Drawing.Point(229, 460);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(308, 53);
            this.BTN_CANCEL.TabIndex = 24;
            this.BTN_CANCEL.Text = "CANCEL";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            // 
            // BTN_PRINT_INV
            // 
            this.BTN_PRINT_INV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRINT_INV.Location = new System.Drawing.Point(546, 460);
            this.BTN_PRINT_INV.Name = "BTN_PRINT_INV";
            this.BTN_PRINT_INV.Size = new System.Drawing.Size(308, 53);
            this.BTN_PRINT_INV.TabIndex = 24;
            this.BTN_PRINT_INV.Text = "PRINT INVOICE";
            this.BTN_PRINT_INV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(228, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 26;
            // 
            // FRM_PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTN_PRINT_INV);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_PAY_BY_CARD);
            this.Controls.Add(this.BTN_PAY_BY_CASH);
            this.Controls.Add(this.LBL_KHR);
            this.Controls.Add(this.LBL_USD);
            this.Controls.Add(this.LBL_GRANT_TOTAL);
            this.Controls.Add(this.LBL_INV_NUM);
            this.Controls.Add(this.TXT_TOTAL_KHR);
            this.Controls.Add(this.TXT_TOTAL_USD);
            this.Controls.Add(this.TXT_INV_NUM);
            this.Controls.Add(this.LBL_UNPAID_INVOICE_LIST);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_PAYMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PAYMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_UNPAID_INVOICE_LIST;
        private System.Windows.Forms.Label LBL_INV_NUM;
        private System.Windows.Forms.TextBox TXT_INV_NUM;
        private System.Windows.Forms.TextBox TXT_TOTAL_USD;
        private System.Windows.Forms.Label LBL_GRANT_TOTAL;
        private System.Windows.Forms.Label LBL_USD;
        private System.Windows.Forms.TextBox TXT_TOTAL_KHR;
        private System.Windows.Forms.Label LBL_KHR;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button BTN_PAY_BY_CASH;
        private System.Windows.Forms.Button BTN_PAY_BY_CARD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_BALANCE_KHR;
        private System.Windows.Forms.TextBox TXT_BALANCE_USD;
        private System.Windows.Forms.Label LBL_BALANCE;
        private System.Windows.Forms.Label LBL_BALANCE_KHR;
        private System.Windows.Forms.Label LBL_BALANCE_USD;
        private System.Windows.Forms.TextBox TXT_CHANGE_KHR;
        private System.Windows.Forms.TextBox TXT_CHANGE_USD;
        private System.Windows.Forms.Label LBL_CHANGE;
        private System.Windows.Forms.Label LBL_CHANGE_KHR;
        private System.Windows.Forms.Label LBL_CHANGE_USD;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_PRINT_INV;
        private System.Windows.Forms.Panel panel2;
    }
}