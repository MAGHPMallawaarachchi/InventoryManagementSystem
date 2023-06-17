using InventoryManagementSystem.DataModels;
using InventoryManagementSystem.UserControls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Login : Form
    {
        private readonly MongoConnector _mongoConnector;
        ShowMessage showMessage = new ShowMessage();

        public Login()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "1234";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool IsAdmin = false;

            var admin = await _mongoConnector.FindAdmin(username, password);
            
            if(admin != null)
            {
                IsAdmin = true;
            }

            if (IsAdmin)
            {
                // Set the session variables
                Session.Username = txtUsername.Text;
                Session.Name = admin!.name;
                Session.IsAdmin = IsAdmin;

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                showMessage.ShowErrorMessage("Invalid username or password!", this);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }       
    }
}
