using System.Configuration;
using System.Drawing.Drawing2D;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Reports : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        public UC_Reports()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            BestSellingItemsLoad();

            UpdatePanelRegion(Panel2);
            UpdatePanelRegion(Panel1);
            UpdatePanelRegion(Panel3);
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

        /*public async void OverviewLoad()
        {
            // Disable automatic row height adjustment
            dgvOverview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            
            var documents = await _mongoConnector.GetOverview();

            // Process the result
            foreach (var document in documents)
            {

                dgvOverview.Rows.Add(new object[] {
                    document.brand!,
                    "revenue",
                    "profit"
                });
            }

            foreach (DataGridViewRow row in dgvOverview.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvOverview.CurrentCell = null;

        }

        public async void BestSellingCategoriesLoad()
        {
            // Disable automatic row height adjustment
            dgvBestSellingCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetBestSellingCategories();

            // Process the result
            foreach (var document in documents)
            {

                dgvBestSellingCategories.Rows.Add(new object[] {
                    document.brand!,
                    "revenue",
                    "profit"
                });
            }

            foreach (DataGridViewRow row in dgvBestSellingCategories.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvBestSellingCategories.CurrentCell = null;

        }*/

        public async void BestSellingItemsLoad()
        {
            // Disable automatic row height adjustment
            dgvBestSellingItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetBestSellingItems();

            // Process the result
            foreach (var document in documents)
            {

                dgvBestSellingItems.Rows.Add(new object[] {
                    document.part_number!,
                    document.brand!,
                    document.category!,
                    document.quantity_sold!,
                    document.quantity_in_hand!,
                    document.total_revenue!,
                    document.total_profit!
                });
            }

            foreach (DataGridViewRow row in dgvBestSellingItems.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvBestSellingItems.CurrentCell = null;

        }

        private void Panel1_StyleChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel1);
        }

        private void Panel2_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel2);
        }

        private void Panel3_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel3);
        }
    }
}
