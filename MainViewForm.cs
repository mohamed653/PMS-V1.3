using System;
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
    public partial class MainViewForm :Form
    {
        Panel panel_view;
        public  MainViewForm(Panel panelView)
        {
            InitializeComponent();
            panel_view = panelView;
        }


        
        private void btnMedicine_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            Form Medicine = new Medicine_Form();
            Medicine.TopLevel = false;
            panel_view.Controls.Add(Medicine);
            Medicine.Dock = DockStyle.Fill;
            Medicine.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            Form Notification = new Notification_Form();
            Notification.TopLevel = false;
            panel_view.Controls.Add(Notification);
            Notification.Dock = DockStyle.Fill;
            Notification.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            Form Bill = new Bills_Form();
            Bill.TopLevel = false;
            panel_view.Controls.Add(Bill);
            Bill.Dock = DockStyle.Fill;
            Bill.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            Form Report = new Report_Form();
            Report.TopLevel = false;
            panel_view.Controls.Add(Report);
            Report.Dock = DockStyle.Fill;
            Report.Show();
        }
    }
}
