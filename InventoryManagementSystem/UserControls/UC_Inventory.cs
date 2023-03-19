using InventoryManagementSystem.UserControls;
using InventoryManagementSystem.DataModels;
using System.Drawing.Drawing2D;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

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
            RefreshInventory();
        }

        public void RefreshInventory()
        {
            UpdatePanelRegion(panel1);
            UpdatePanelRegion(panel2);

            dgvItems.Rows.Clear();
            dgvOverallInventory.Rows.Clear();

            bool clear = true;
            ItemsLoad(clear);
            OverallInventoryLoad();

            // set the selection mode to full row select
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOverallInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public async void ItemsLoad(bool clear)
        {
            dgvItems.Rows.Clear();

            if(clear)
            {
                // Disable automatic row height adjustment
                dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                checkboxColumn.Width = 50;

                //get all the items from the collection items
                var documents = await _mongoConnector.GetAllItems();

                // Process the result
                foreach (var document in documents)
                {
                    var QuantityInHand = document.quantity - document.quantity_sold;
                    var Availability = "In-Stock";

                    if (document.quantity <= 10 && document.quantity > 0)
                    {
                        Availability = "Low-Stock";
                    }

                    if (document.quantity == 0)
                    {
                        Availability = "Out-of-stock";
                    }

                    dgvItems.Rows.Add(new object[] {
                    false,
                    document.part_number!,
                    document.description!,
                    document.brand!,
                    document.quantity!,
                    QuantityInHand!,
                    document.quantity_sold!,
                    document.unit_price!.ToString("N2"),
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

        public async void ItemsLoadWithFilters(string brand, string category)
        {
            dgvItems.Rows.Clear();

            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            checkboxColumn.Width = 50;

            var filter = Builders<Item>.Filter.Empty;

            if (brand != "-- Brand --" && category != "-- Category --")
            {
                filter = Builders<Item>.Filter.Eq(x => x.category, category);
            }
            else if (brand != "-- Brand --")
            {
                filter = Builders<Item>.Filter.Eq(x => x.brand, brand);
            }
            else if (category != "-- Category --")
            {
                filter = Builders<Item>.Filter.Eq(x => x.category, category);
            }

            var documents = await _mongoConnector.GetItemsByFilter(filter);

            foreach (var document in documents)
            {
                var QuantityInHand = document.quantity - document.quantity_sold;
                var Availability = "In-Stock";

                if (document.quantity <= 10 && document.quantity > 0)
                {
                    Availability = "Low-Stock";
                }

                if (document.quantity == 0)
                {
                    Availability = "Out-of-stock";
                }

                dgvItems.Rows.Add(new object[] {
                    false,
                    document.part_number!,
                    document.description!,
                    document.brand!,
                    document.quantity!,
                    QuantityInHand!,
                    document.quantity_sold!,
                    document.unit_price!.ToString("N2"),
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
            AddItem addItem = new AddItem(this);
            addItem.ShowDialog();
        }

        public void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (dgvItems.SelectedRows.Count > 0 && e.ColumnIndex == dgvItems.Columns["part_number"].Index)
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

        private Color defaultForeColor;

        private void dgvItems_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvItems.Rows.Count)
            {
                defaultForeColor = dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(10, 73, 156);
            }

            // Check if the hovered cell is in the part_number column
            if (e.ColumnIndex == dgvItems.Columns["part_number"].Index && e.RowIndex >= 0)
            {
                // Get the cell to be underlined
                DataGridViewCell cell = dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Underline the cell content
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Underline);

                // Change the cursor to a hand when hovering over the cell
                dgvItems.Cursor = Cursors.Hand;
            }
            else
            {
                dgvItems.Cursor = Cursors.Default;
            }
        }

        private void dgvItems_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvItems.Rows.Count)
            {
                dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = defaultForeColor;
            }

            // Check if the mouse left the part_number column
            if (e.ColumnIndex == dgvItems.Columns["part_number"].Index && e.RowIndex >= 0)
            {
                // Get the cell to remove the underline
                DataGridViewCell cell = dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Remove the underline from the cell content
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Regular);
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            Filters filters = new Filters(this);
            filters.ShowDialog();
        }
    }
}
