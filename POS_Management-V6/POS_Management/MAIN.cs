using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Management
{

    public partial class MAIN : Form
    {
        //[DllImport("user32.dll")]
        //public static extern long GetAsyncKeyState(long vKey);
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(UInt16 virtualKeyCode);
       // [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]

        public MAIN()
        {
            InitializeComponent();
        }



        private void MAIN_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            InitializeMenu();
            SetHeadLocation();
            MainMenu.TitlePanel.Hide();
        }
        private void InitializeMenu()
        {
            dynamic[] MenuText = new dynamic[10];
            Button[] arrMenu = new Button[10];
            Color MenuForeColor = Properties.Settings.Default.MenuForeColor;
            pnlHead.BackColor = Properties.Settings.Default.HeadColor;
            MenuText[0] = "SALE";
            MenuText[1] = "CLOSE SHIFT";
            MenuText[2] = "PRODUCT";
            MenuText[3] = "CATEGORY";
            MenuText[4] = "BRAND";
            MenuText[5] = "PROMOTION";
            MenuText[6] = "STOCK ORDER";
            MenuText[7] = "STOCK PURCHASE";
            MenuText[8] = "SYSTEM SETTING";
            MenuText[9] = "REPORT";
            
            PnlMenu.Controls.Clear();
            int x=5, y=10;
            for (int i = 0; i < arrMenu.Length; i++)
            {

                arrMenu[i] = new Button();
                arrMenu[i].Text = MenuText[i];
                arrMenu[i].Tag = i + 1;
                arrMenu[i].Size = new Size(PnlMenu.Width-10,45);
                arrMenu[i].Location = new Point(x,y);
                arrMenu[i].FlatStyle = FlatStyle.Flat;
                arrMenu[i].Font= new Font("Microsoft Sans Serif, 12pt",11);
                arrMenu[i].ForeColor = MenuForeColor;
                arrMenu[i].Click += new System.EventHandler(Menu_Click);
                PnlMenu.Controls.Add(arrMenu[i]);
                y += arrMenu[i].Height + 10;
            }
        }
        private void Menu_Click(Object sender, EventArgs e)
        {
            int Menu_Status = Convert.ToInt16( ((Button)sender).Tag.ToString());
            switch (Menu_Status)
            {
                case 1:
                    btnMenu.PerformClick();
                     var sale =new FRM_SALE();
                     sale.ShowDialog();
                    break;
                case 2:
                    break;
                case 3:
                    btnMenu.PerformClick();
                    LoadForm(new FRM_PRODUCT());
                    break;
                case 4:
                    btnMenu.PerformClick();
                    LoadForm(new FRM_CATEGORY());
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    btnMenu.PerformClick();
                    LoadForm(new FRM_SYSTEM_SETTING());
                    break;
                case 10:
                    break;

            }
        }
        private void SetHeadLocation()
        {
            lblDate.Location = new Point((pnlHead.Width / 2) - (lblDate.Width / 2), (pnlHead.Height / 2) - (lblDate.Height / 2));
            lblaboutUs.Location = new Point(pnlHead.Width - (lblaboutUs.Width), (pnlHead.Height / 2) - (lblaboutUs.Height / 2));
            lblUsrs.Location = new Point((PicLogo.Width + btnMenu.Width) + ((lblUsrs.Height + 10) / 2), (pnlHead.Height / 2) - (lblUsrs.Height / 2));
            lblUsrs.Text = " User: " + Properties.Settings.Default.User_id + " ( " + Properties.Settings.Default.uname + " )";


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnMenu.Tag.ToString() == "1")
            {
                MainMenu.Visible = true;
                MainMenu.Expanded = true;
                btnMenu.Tag = "0";
            }
            else
            {
                btnMenu.Tag = "1";
                MainMenu.Expanded = false;
                MainMenu.Visible = false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            lblDate.Text="Date: " + DateTime.Now;
           //+ " / User: (" + Properties.Settings.Default.User_id + ") " + Properties.Settings.Default.uname+"                             Powerd by True Soft";
            if (MainMenu.Visible == false)
            {
                
                if (Cursor.Position.X > MainMenu.Width & Cursor.Position.Y > 0 | Cursor.Position.X > 0 & Cursor.Position.Y < MainMenu.Height - ((MainMenu.Height / 2) - btnMenu.Height))
                {
                    MainMenu.Visible = false;
                }
            } 
        }
        private void MAIN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                MainMenu.Visible = false;
            }
        }

        void LoadForm(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Properties.Resources.POS_menu;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackgroundImage = Properties.Resources.POSmenu;
        }
    }
}
