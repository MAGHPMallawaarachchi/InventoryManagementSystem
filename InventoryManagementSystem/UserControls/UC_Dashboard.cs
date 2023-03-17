using System.Configuration;
using System.Resources;
using System.Windows.Forms;
using InventoryManagementSystem.UserControls;

namespace InventoryManagementSystem
{
    public partial class UC_Dashboard : UserControl
    {
        UIHelper UIHelper = new UIHelper();
        private readonly MongoConnector _mongoConnector;
        ResourceManager resourceManager = Properties.Resources.ResourceManager;

        public UC_Dashboard()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(panel1);
            UIHelper.UpdatePanelRegion(panel2);
            UIHelper.UpdatePanelRegion(panel3);
            UIHelper.UpdatePanelRegion(panel4);
            UIHelper.UpdatePanelRegion(panel5);

            InventorySummaryLoad();
        }

        private async void InventorySummaryLoad()
        {
            var items = await _mongoConnector.GetAllItems();

            int QuantitySold = 0;
            int QuantityInHand = 0;
            int LowQuantityStock = 0;
            int OutOfStock = 0;

            foreach (var item in items)
            {
                QuantitySold += (int)item.quantity_sold!;
                QuantityInHand += (int)item.quantity_in_hand!;

                if (item.quantity_in_hand < 50 && item.quantity_in_hand != 0)
                {
                    LowQuantityStock++;
                }

                if (item.quantity_in_hand == 0)
                {
                    OutOfStock++;
                }
            }

        }

    }
}
