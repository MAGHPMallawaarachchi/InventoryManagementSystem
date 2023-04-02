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
        private ContextMenuStrip? _contextMenuStrip;

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
                    invoice.status!
                });

                status_check.Width = 30;
                status.Width = 200;
                status_check.Width = 200;
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

        private void dgvInvoices_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the clicked column is the status_check column
            if (dgvInvoices.Columns[e.ColumnIndex].Name == "status_check" && e.RowIndex >= 0)
            {
                // If the context menu strip already exists, hide it
                if (_contextMenuStrip != null)
                {
                    _contextMenuStrip.Close();
                    _contextMenuStrip = null; // Set the reference to null when closed
                    return;
                }

                // Create a new context menu strip and add three items
                _contextMenuStrip = new ContextMenuStrip();
                _contextMenuStrip.Items.Add("Complete", null, ToolStripMenuItem_Click!);
                _contextMenuStrip.Items.Add("Pending", null, ToolStripMenuItem_Click!);
                /*_contextMenuStrip.Items.Add("Cancel", null, ToolStripMenuItem_Click!);*/

                // Set the Visible property to true
                _contextMenuStrip.Visible = true;

                // Set the location of the context menu strip
                Rectangle rect = dgvInvoices.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point location = new Point(rect.Left, rect.Bottom);
                _contextMenuStrip.Show(dgvInvoices, location);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the clicked ToolStripMenuItem control
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            // Get the index of the selected row
            int rowIndex = dgvInvoices.CurrentCell.RowIndex;

            // Get the value of the status column for the selected row
            DataGridViewCell statusCell = dgvInvoices.Rows[rowIndex].Cells["status"];

            // Get the value of the "invoice_no" column for the selected row
            string? invoiceNo = dgvInvoices.Rows[rowIndex].Cells["invoice_no"].Value.ToString();

            // Update the value of the status column based on the clicked item
            if (item.Text == "Complete")
            {
                statusCell.Value = "Completed";
                statusCell.Style.ForeColor = ColorTranslator.FromHtml("#10A760");
                _mongoConnector.UpdateStatus(invoiceNo!, "Completed");
            }
            else if (item.Text == "Pending")
            {
                statusCell.Value = "Pending";
                statusCell.Style.ForeColor = ColorTranslator.FromHtml("#E19133");
                _mongoConnector.UpdateStatus(invoiceNo!, "Pending");
            }
            /*else if (item.Text == "Cancel")
            {
                statusCell.Value = "Cancelled";
                statusCell.Style.ForeColor = ColorTranslator.FromHtml("#DA3E33");
                _mongoConnector.UpdateStatus(invoiceNo!, "Cancelled");
            }*/

            // Dispose the context menu strip
            _contextMenuStrip!.Dispose();
            _contextMenuStrip = null;
        }

        private void dgvInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvInvoices.Columns["status"].Index && e.Value != null)
            {
                string? status = e.Value.ToString();
                if (status == "Pending")
                {
                    e.CellStyle!.ForeColor = ColorTranslator.FromHtml("#E19133");
                }
                else if (status == "Completed")
                {
                    e.CellStyle!.ForeColor = ColorTranslator.FromHtml("#10A760");
                }
                /*else if (status == "Cancelled")
                {
                    e.CellStyle!.ForeColor = ColorTranslator.FromHtml("#DA3E33");
                }*/
            }
        }
    }
}
