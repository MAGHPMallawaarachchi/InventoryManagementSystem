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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            CustomersLoad();
        }

        private async void CustomersLoad()
        {
            // Disable automatic row height adjustment
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetAllCustomers();

            // Process the result
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

            // set the current cell to null to prevent the first row from being selected
            dgvCustomers.CurrentCell = null;
        }
    }
}
