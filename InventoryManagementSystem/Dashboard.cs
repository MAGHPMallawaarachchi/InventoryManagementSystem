using InventoryManagementSystem.Messages;
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Check if the user is authenticated
            if (Session.Username == null)
            {
                // Redirect to the login form
                var login = new Login();
                login.ShowDialog();
                this.Close();
                return;
            }

            // Set the user label
            lblUser.Text = "Welcome, " + Session.Name + "!";
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
            uc.RefreshData();
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
            uc.RefreshData();
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

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            UC_NewInvoice uc = new UC_NewInvoice();
            addUserControl(uc);
        }

        private bool _isLoggingOut = false;

        private void LogOut()
        {
            LogoutConfirmation logoutConfirmation = new LogoutConfirmation();
            DialogResult result = logoutConfirmation.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Clear the session variables
                Session.Username = null;
                Session.Name = null;
                Session.IsAdmin = false;

                _isLoggingOut = true;
                this.Close();
                logoutConfirmation.Close();
            }

            else if (result == DialogResult.Cancel || logoutConfirmation.Cancelled)
            {
                logoutConfirmation.Close();
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
