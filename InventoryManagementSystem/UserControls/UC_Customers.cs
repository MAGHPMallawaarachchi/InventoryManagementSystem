using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Customers : UserControl
    {
        private readonly MongoConnector _mongoConnector;

        public UC_Customers()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private async void CustomersLoad()
        {
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var documents = await _mongoConnector.GetAllCustomers();

            dgvCustomers.Rows.Clear(); // Clear existing data in the grid view

            foreach (var document in documents)
            {
                dgvCustomers.Rows.Add(new object[] {
                    document.customer_id!,
                    document.name!,
                    document.address!,
                    document.city!,
                    document.phone_no!,
                });
            }

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.Height = 50;
            }

            dgvCustomers.CurrentCell = null;
        }

        public void RefreshCustomers()
        {
            CustomersLoad();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.ShowDialog();
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            CustomersLoad();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

