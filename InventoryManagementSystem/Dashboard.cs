using InventoryManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            siticonePanel2.Controls.Clear();
            siticonePanel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();
            addUserControl(uc);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Reports uc = new UC_Reports();
            addUserControl(uc);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UC_Customers uc = new UC_Customers();
            addUserControl(uc);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            UC_Orders uc = new UC_Orders();
            addUserControl(uc);
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
