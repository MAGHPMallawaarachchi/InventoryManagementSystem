using InventoryManagementSystem.UserControls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Panel mainPanel;

        public Dashboard()
        {
            InitializeComponent();

            mainPanel = new Panel();
            mainPanel.BackColor = Color.FromArgb(240, 241, 243);
            mainPanel.Location = new Point(286, 106);
            mainPanel.Size = new Size(1136, 807);
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            Controls.Add(mainPanel);

            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
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
            UC_Invoices uc = new UC_Invoices();
            addUserControl(uc);
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

    }
}
