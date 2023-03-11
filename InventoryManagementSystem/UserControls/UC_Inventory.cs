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

namespace InventoryManagementSystem
{
    public partial class UC_Inventory : UserControl
    {

        public UC_Inventory()
        {
            InitializeComponent();

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

            // set the current cell to null to prevent the first row from being selected
            dgvItems.CurrentCell = null;
            dgvOverallInventory.CurrentCell = null;
        }

        public void ItemsLoad()
        {
            // Disable automatic row height adjustment
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Create a MongoDB client and connect to the database
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);
            var database = mongoClient.GetDatabase("InventoryManagementSystem");

            // Get a reference to the collection you want to query
            var collection = database.GetCollection<BsonDocument>("items");

            // Execute the query and store the result in a variable
            var result = collection.Find(new BsonDocument()).ToList();

            // Process the result
            foreach (var document in result)
            {
                // Do something with each document
                var part_number = document["part_number"].AsString;
                var description = document["description"].AsString;
                var brand = document["brand"].AsString;
                var quantity = document["quantity"].AsInt32;
                var quantity_sold = document["quantity_sold"].AsInt32;
                var quantity_in_hand = quantity - quantity_sold;
                var unit_price = document["unit_price"].AsDecimal128;

                var availability = "In-Stock";

                if (quantity < 50 && quantity > 0)
                {
                    availability = "Low-Stock";
                }

                if (quantity == 0)
                {
                    availability = "Out-of-stock";
                }

                dgvItems.Rows.Add(new object[] { part_number, description, brand, quantity, quantity_in_hand, quantity_sold, unit_price, availability });
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Height = 50;
            }
        }

        public void OverallInventoryLoad()
        {
            // Create a MongoDB client and connect to the database
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);
            var database = mongoClient.GetDatabase("InventoryManagementSystem");

            // Get a reference to the collection you want to query
            var collection = database.GetCollection<BsonDocument>("items");

            // use the Aggregate method to get the number of unique items in the category field
            var distinctCategories = collection.Aggregate()
                .Group(new BsonDocument { { "_id", "$category" } })
                .ToList();

            // get the count of the distinct categories
            int uniqueCategoriesCount = distinctCategories.Count;

            // Execute the query and store the result in a variable
            var result = collection.Find(new BsonDocument()).ToList();

            int totalItems = 0;
            int lowInStock = 0;
            int outOfStock = 0;

            // Process the result
            foreach (var document in result)
            {
                var quantity = document["quantity"].AsInt32;
                var quantity_sold = document["quantity_sold"].AsInt32;
                var quantity_in_hand = quantity - quantity_sold;

                totalItems++;

                if (quantity_in_hand == 0)
                {
                    outOfStock++;
                }

                if (quantity_in_hand < 50)
                {
                    lowInStock++;
                }
            }

            dgvOverallInventory.Rows.Add(new object[] { uniqueCategoriesCount, totalItems, lowInStock, outOfStock });

            dgvOverallInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;

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

        private void btnFilters_Click(object sender, EventArgs e)
        {

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
                    formBackground.Location = Screen.PrimaryScreen.WorkingArea.Location;
                    formBackground.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
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

    }
}
