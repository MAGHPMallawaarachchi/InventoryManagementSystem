using System.Configuration;

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
                    document.quantity_in_hand!,
                    "revenue",
                    "profit"
                });
            }

            foreach (DataGridViewRow row in dgvBestSellingItems.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvBestSellingItems.CurrentCell = null;
            
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            BestSellingItemsLoad();
        }
    }
}
