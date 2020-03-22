using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Mangment_System
{
    public partial class Main_Form : Form
    {
        bool isSideMenu = false;
        string[] sideButonsText = new string[8];

        // *important* passing the username variable from the loginForm to the mainForm 
        public Main_Form(string username)
        {
            InitializeComponent();
            // welcome text
            if (username == "Username")
            {
                username = "";
            }
            txtWelcome.Text = username;
            // date show
            var date = DateTime.Now;
            txtdate.Text = date.ToLongDateString();
            addMainView();
            config();
  
        }
        private void config()
        {
           // string[] sideButonsText = new string[8];
            sideButonsText[0] = btnHome.Text; sideButonsText[1] = btn_Medicine.Text;
            sideButonsText[2] = btn_Report.Text; sideButonsText[3] = btn_Notification.Text;
            sideButonsText[4] = btn_Bill.Text; sideButonsText[5] = btnSetting.Text;
            sideButonsText[6] = btnAbout.Text; sideButonsText[7] = btnLogout.Text;

        }
        private void del()
        {
            btnHome.Text = null;
            btn_Medicine.Text = null;
            btn_Report.Text = null;
            btn_Notification.Text = null;
            btn_Bill.Text = null;
            btnSetting.Text = null;
            btnAbout.Text = null;
            btnLogout.Text = null;
        }
        private void retr()
        {
            btnHome.Text = sideButonsText[0];   btn_Medicine.Text=sideButonsText[1];
            btn_Report.Text = sideButonsText[2]; btn_Notification.Text =sideButonsText[3];
            btn_Bill.Text = sideButonsText[4]; btnSetting.Text = sideButonsText[5];
            btnAbout.Text =sideButonsText[6] ;  btnLogout.Text= sideButonsText[7];
        }

        private void addMainView()
        {
            Form MainView = new MainViewForm(panelView);
            panelView.Controls.Clear();
            MainView.TopLevel = false;
            panelView.Controls.Add(MainView);
            MainView.Dock = DockStyle.Fill;
            MainView.Show();
        }

        private void ExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Login = new Login_Form();
            Login.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {

            panelView.Controls.Clear();
            Form Medicine = new Medicine_Form();
            Medicine.TopLevel = false;
            panelView.Controls.Add(Medicine);
            Medicine.Dock = DockStyle.Fill;
            Medicine.Show();
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            panelView.Controls.Clear();
            Form Report = new Report_Form();
            Report.TopLevel = false;
            panelView.Controls.Add(Report);
            Report.Dock = DockStyle.Fill;
            Report.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Form Bill = new Bills_Form();
            Bill.TopLevel = false;
            panelView.Controls.Add(Bill);
            Bill.Dock = DockStyle.Fill;
            Bill.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Form Notification = new Notification_Form();
            Notification.TopLevel = false;
            panelView.Controls.Add(Notification);
            Notification.Dock = DockStyle.Fill;
            Notification.Show();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addMainView();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxi.Image = Pharmacy_Mangment_System.Properties.Resources.icons8_restore_down_32px;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

                btnMaxi.Image = Pharmacy_Mangment_System.Properties.Resources.icons8_maximize_button_32px;
            }
            
        }
        private void btnCollapase_Click_1(object sender, EventArgs e)
        {
            if (isSideMenu==false)
            {
                tableLayoutPanel2.ColumnStyles[0].Width = 5F;
                tableLayoutPanel2.ColumnStyles[1].Width = 95F;
                del();
                isSideMenu = true;

            }
            else
            {
                tableLayoutPanel2.ColumnStyles[0].Width = 15F;
                tableLayoutPanel2.ColumnStyles[1].Width = 85F;
                isSideMenu = false;
                retr();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            Form Setting = new Setting_Form();
            Setting.TopLevel = false;
            panelView.Controls.Add(Setting);
            Setting.Dock = DockStyle.Fill;
            Setting.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            panelView.Controls.Add(Doc);
            Doc.Dock = DockStyle.Fill;
            Doc.Show();
            
        }
    }
}
