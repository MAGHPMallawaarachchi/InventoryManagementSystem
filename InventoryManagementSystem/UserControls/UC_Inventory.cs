using InventoryManagementSystem.UserControls;
using Siticone.Desktop.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using dotenv.net;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ImageResizer.Configuration.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;

namespace InventoryManagementSystem
{
    public partial class UC_Inventory : UserControl
    {
        private readonly MongoConnector _mongoConnector;

        public UC_Inventory()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");

        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            UpdatePanelRegion(panel1);
            UpdatePanelRegion(panel2);

            ItemsLoad();
            OverallInventoryLoad();

            // set the selection mode to full row select
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOverallInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cbBrandLoad();
            cbCategoryLoad();
        }

        public async void ItemsLoad()
        {
            // Disable automatic row height adjustment
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetAllItems();

            // Process the result
            foreach (var document in documents)
            {
                var QuantityInHand = document.quantity - document.quantity_sold;
                var Availability = "In-Stock";

                if (document.quantity < 50 && document.quantity > 0)
                {
                    Availability = "Low-Stock";
                }

                if (document.quantity == 0)
                {
                    Availability = "Out-of-stock";
                }

                dgvItems.Rows.Add(new object[] { 
                    document.part_number!, 
                    document.description!, 
                    document.brand!, 
                    document.quantity!, 
                    QuantityInHand!, 
                    document.quantity_sold!, 
                    document.unit_price!, 
                    Availability 
                });
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvItems.CurrentCell = null;
            dgvOverallInventory.CurrentCell = null;
        }

        public async void OverallInventoryLoad()
        {
            var uniqueCategories = await _mongoConnector.GetUniqueCategories();

            // get the count of the distinct categories
            int uniqueCategoriesCount = uniqueCategories.Count;

            int totalItems = 0;
            int lowInStock = 0;
            int outOfStock = 0;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetAllItems();

            // Process the result
            foreach (var document in documents)
            {
                var QuantityInHand = document.quantity - document.quantity_sold;

                totalItems++;

                if (QuantityInHand == 0)
                {
                    outOfStock++;
                }

                if (QuantityInHand < 50)
                {
                    lowInStock++;
                }
            }

            dgvOverallInventory.Rows.Add(new object[] { uniqueCategoriesCount, totalItems, lowInStock, outOfStock });

            dgvOverallInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;

            // set the current cell to null to prevent the first row from being selected
            dgvItems.CurrentCell = null;
            dgvOverallInventory.CurrentCell = null;

        }

        private async void cbBrandLoad()
        {
            cbBrand.Items.Add("-- Select Brand --");
            cbBrand.SelectedIndex = 0;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;

            var uniqueBrands = await _mongoConnector.GetUniqueBrands();

            foreach (var brand in uniqueBrands)
            {
                cbBrand.Items.Add(brand);
            }
        }

        private async void cbCategoryLoad()
        {
            // Add the placeholder item to the ComboBox
            cbCategory.Items.Add("-- Select Category --");
            cbCategory.SelectedIndex = 0;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cbBrand.SelectedIndex == 0)
            {
                var uniqueCategories = await _mongoConnector.GetUniqueCategories();

                foreach (var category in uniqueCategories)
                {
                    cbCategory.Items.Add(category);
                }
            }
            else
            {
                cbCategory.Items.Clear();

                // Add the placeholder item to the ComboBox
                cbCategory.Items.Add("-- Select Category --");
                cbCategory.SelectedIndex = 0;
                cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

                var uniqueCategoriesByBrand = await _mongoConnector.GetUniqueCategoriesByBrand(cbBrand.Text);
                foreach (var category in uniqueCategoriesByBrand)
                {
                    cbCategory.Items.Add(category);
                }
            }

        }  

        private void UpdatePanelRegion(Panel panel)
        {
            // Create a new GraphicsPath object that defines a rounded rectangle
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the Region property of the panel to the new GraphicsPath object
            panel.Region = new Region(path);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(panel1);
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(panel2);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AddItem addItem = new AddItem())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    if (Screen.PrimaryScreen != null)
                    {
                        formBackground.Location = Screen.PrimaryScreen.WorkingArea.Location;
                        formBackground.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                    }                   
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    addItem.Owner = null;

                    addItem.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            ItemsLoad();
        }

        public void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (dgvItems.SelectedRows.Count > 0)
            {
                // Get the selected part number from the first cell of the selected row
                string partNumber = dgvItems.SelectedRows[0].Cells["part_number"].Value?.ToString() ?? "N/A";

                UC_ItemDetails uc = new UC_ItemDetails();

                // Update the user control based on the value of the clicked cell
                uc.UpdateContent(partNumber);

                Dashboard? dashboard = this.FindForm() as Dashboard;

                if (dashboard != null)
                {
                    dashboard.addUserControl(uc);
                }
            }
        }

        private void middlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvOverallInventory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if the current cell is a column header cell.
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {

                // Set the forecolor of the current header cell.
                e.CellStyle.ForeColor = GetHeaderForeColor(e.ColumnIndex);

                // Paint the background of the current header cell.
                e.PaintBackground(e.CellBounds, false);

                // Paint the content of the current header cell.
                e.PaintContent(e.CellBounds);

                // Prevent the default painting of the header cell.
                e.Handled = true;
            }
        }

        private Color GetHeaderForeColor(int columnIndex)
        {
            // Define the RGB values for each column header forecolor.
            int[][] rgbValues = { new[] { 10, 73, 156 }, new[] { 132, 94, 188 }, new[] { 225, 145, 51 }, new[] { 243, 105, 96 } };

            // Create a new color using the RGB values for the current column header forecolor.
            return Color.FromArgb(rgbValues[columnIndex % rgbValues.Length][0],
                                  rgbValues[columnIndex % rgbValues.Length][1],
                                  rgbValues[columnIndex % rgbValues.Length][2]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;

            cbBrand.SelectedIndex = 0;

            if (cbCategory.SelectedIndex == 0 && cbBrand.SelectedIndex == 0)
            {
                dgvItems.Rows.Clear();
                ItemsLoad();
            }
        }

        private async void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex != 0)
            {
                dgvItems.Rows.Clear();
                string selectedBrand = cbBrand.Text;

                cbCategoryLoad();

                // Disable automatic row height adjustment
                dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                var documents = await _mongoConnector.GetItemsByBrand(selectedBrand);

                // Process the result
                foreach (var document in documents)
                {
                    var QuantityInHand = document.quantity - document.quantity_sold;
                    var Availability = "In-Stock";

                    if (document.quantity < 50 && document.quantity > 0)
                    {
                        Availability = "Low-Stock";
                    }

                    if (document.quantity == 0)
                    {
                        Availability = "Out-of-stock";
                    }

                    dgvItems.Rows.Add(new object[] {
                        document.part_number!,
                        document.description!,
                        document.brand!,
                        document.quantity!,
                        QuantityInHand!,
                        document.quantity_sold!,
                        document.unit_price!,
                        Availability
                    });
                }

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    row.Height = 50;
                }

                // set the current cell to null to prevent the first row from being selected
                dgvItems.CurrentCell = null;
                dgvOverallInventory.CurrentCell = null;
            }

        }

        private async void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex != 0)
            {
                dgvItems.Rows.Clear();
                string selectedCategory = cbCategory.Text;

                // Disable automatic row height adjustment
                dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                var documents = await _mongoConnector.GetItemsByCategory(selectedCategory);

                // Process the result
                foreach (var document in documents)
                {
                    var QuantityInHand = document.quantity - document.quantity_sold;
                    var Availability = "In-Stock";

                    if (document.quantity < 50 && document.quantity > 0)
                    {
                        Availability = "Low-Stock";
                    }

                    if (document.quantity == 0)
                    {
                        Availability = "Out-of-stock";
                    }

                    dgvItems.Rows.Add(new object[] {
                        document.part_number!,
                        document.description!,
                        document.brand!,
                        document.quantity!,
                        QuantityInHand!,
                        document.quantity_sold!,
                        document.unit_price!,
                        Availability
                    });
                }

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    row.Height = 50;
                }

                // set the current cell to null to prevent the first row from being selected
                dgvItems.CurrentCell = null;
                dgvOverallInventory.CurrentCell = null;
            }
        }

        private Color defaultForeColor;

        private void dgvItems_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvItems.Rows.Count)
            {
                defaultForeColor = dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(10, 73, 156);
            }
        }

        private void dgvItems_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvItems.Rows.Count)
            {
                dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = defaultForeColor;
            }
        }
    }
}
