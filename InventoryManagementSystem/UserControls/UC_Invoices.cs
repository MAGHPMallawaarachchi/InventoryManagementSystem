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
    public partial class UC_Invoices : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        UIHelper uIHelper = new UIHelper();
        public UC_Invoices()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Invoices_Load(object sender, EventArgs e)
        {
            InvoicesLoad();
            uIHelper.UpdatePanelRegion(panel1);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            uIHelper.UpdatePanelRegion(panel1);
        }

        private async void InvoicesLoad()
        {
            dgvInvoices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var invoices = await _mongoConnector.GetAllInvoices();

            dgvInvoices.Rows.Clear();

            foreach (var invoice in invoices)
            {
                var customer = await _mongoConnector.GetByCustomerID(invoice.customer_id!);

                dgvInvoices.Rows.Add(new object[] {
                    "KAP-"+invoice.sequence!,
                    customer.name!,
                    invoice.date!,
                    invoice.total_revenue!.ToString("N2"),
                    "Pending"
                });

                status_check.Width = 30;
                status.Width = 200;
                invoice_no.Width = 200;


                foreach (DataGridViewRow row in dgvInvoices.Rows)
                {
                    row.Height = 50;
                }

                dgvInvoices.CurrentCell = null;
            }
        }

        private Color defaultForeColor;

        private void dgvInvoices_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoices.Rows.Count)
            {
                defaultForeColor = dgvInvoices.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                dgvInvoices.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(10, 73, 156);
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.threeDotsBlue;

                // Change the cursor to a hand when hovering over the cell
                dgvInvoices.Cursor = Cursors.Hand;
            }
            else
            {
                dgvInvoices.Cursor = Cursors.Default;
            }
        }

        private void dgvInvoices_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoices.Rows.Count)
            {
                dgvInvoices.Rows[e.RowIndex].DefaultCellStyle.ForeColor = defaultForeColor;
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.threeDots;
            }
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
