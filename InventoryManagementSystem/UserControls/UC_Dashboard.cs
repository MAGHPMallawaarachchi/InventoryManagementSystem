using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class UC_Dashboard : UserControl
    {
        UIHelper UIHelper = new UIHelper();
        private readonly MongoConnector _mongoConnector;

        public UC_Dashboard()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            TopSellingStockLoad();
            RefreshData();
        }

        private void HideLabels()
        {
            lblLSPartNumber1.Visible = false;
            lblLSPartNumber2.Visible = false;
            lblLSPartNumber3.Visible = false;
            lblLSPartNumber4.Visible = false;

            lblOSPartNumber1.Visible = false;
            lblOSPartNumber2.Visible = false;
            lblOSPartNumber3.Visible = false;
            lblOSPartNumber4.Visible = false;

            lblLSRemainingQuantity1.Visible = false;
            lblLSRemainingQuantity2.Visible = false;
            lblLSRemainingQuantity3.Visible = false;
            lblLSRemainingQuantity4.Visible = false;

            lblOSRemainingQuantity1.Visible = false;
            lblOSRemainingQuantity2.Visible = false;
            lblOSRemainingQuantity3.Visible = false;
            lblOSRemainingQuantity4.Visible = false;

            Low1.Visible = false;
            Low2.Visible = false;
            Low3.Visible = false;
            Low4.Visible = false;

            out_of_stock1.Visible = false;
            out_of_stock2.Visible = false;
            out_of_stock3.Visible = false;
            out_of_stock4.Visible = false;
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

                if (item.quantity_in_hand <= 20 && item.quantity_in_hand != 0)
                {
                    LowQuantityStock++;
                }

                if (item.quantity_in_hand == 0)
                {
                    OutOfStock++;
                }
            }

            lblQuantitySoldData.Text = QuantitySold.ToString();
            lblQuantityInHandData.Text = QuantityInHand.ToString();
            lblLowInStockData.Text = LowQuantityStock.ToString();
            lblOutOfStockData.Text = OutOfStock.ToString();

            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));

        }

        private async void SalesOverviewLoad()
        {
            var invoices = await _mongoConnector.GetAllInvoices();

            decimal TotalProfit = 0m;
            decimal TotalRevenue = 0m;
            decimal TotalCost = 0m;
            int salesCount = 0;

            foreach (var invoice in invoices)
            {
                TotalProfit += invoice.total_profit;
                TotalRevenue += invoice.total_revenue;
                TotalCost += invoice.total_cost;
                salesCount++;
            }

            lblSalesData.Text = salesCount.ToString();
            lblRevenueData.Text = "Rs." + TotalRevenue.ToString("N2");
            lblProfitData.Text = "Rs." + TotalProfit.ToString("N2");
            lblCostData.Text = "Rs." + TotalCost.ToString("N2");
        }

        private async void TopSellingStockLoad()
        {
            dgvTopSellingStock.Rows.Clear();

            dgvTopSellingStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var documents = await _mongoConnector.GetBestSellingItems();

            int rowCount = 0;

            foreach (var document in documents)
            {
                if (rowCount >= 6)
                    break;

                dgvTopSellingStock.Rows.Add(new object[] {
                    document.part_number!,
                    document.brand!,
                    document.quantity_sold!,
                    document.quantity_in_hand!,
                    document.unit_price.ToString("N2")
                });

                rowCount++;
            }

            foreach (DataGridViewRow row in dgvTopSellingStock.Rows)
            {
                row.Height = 50;
            }

            dgvTopSellingStock.CurrentCell = null;
        }

        private async void LowInStockLoad()
        {
            var items = await _mongoConnector.GetLowQuantityItems();

            if (items.Count > 0)
            {
                Low1.Visible = true;
                lblLSPartNumber1.Visible = true;
                lblLSRemainingQuantity1.Visible = true;
                lblLSPartNumber1.Text = items[0].part_number;
                lblLSRemainingQuantity1.Text = "Remaining Quantity : " + items[0].quantity_in_hand.ToString();
            }
            if (items.Count > 1)
            {
                Low2.Visible = true;
                lblLSPartNumber2.Visible = true;
                lblLSRemainingQuantity2.Visible = true;
                lblLSPartNumber2.Text = items[1].part_number;
                lblLSRemainingQuantity2.Text = "Remaining Quantity : " + items[1].quantity_in_hand.ToString();
            }
            if (items.Count > 2)
            {
                Low3.Visible = true;
                lblLSPartNumber3.Visible = true;
                lblLSRemainingQuantity3.Visible = true;
                lblLSPartNumber3.Text = items[2].part_number;
                lblLSRemainingQuantity3.Text = "Remaining Quantity : " + items[2].quantity_in_hand.ToString();
            }
            if (items.Count > 3)
            {
                Low4.Visible = true;
                lblLSPartNumber4.Visible = true;
                lblLSRemainingQuantity4.Visible = true;
                lblLSPartNumber4.Text = items[3].part_number;
                lblLSRemainingQuantity4.Text = "Remaining Quantity : " + items[3].quantity_in_hand.ToString();
            }

        }

        private async void OutOfStockLoad()
        {
            var items = await _mongoConnector.GetOutOfStockItems();

            if (items.Count > 0)
            {
                out_of_stock1.Visible = true;
                lblOSPartNumber1.Visible = true;
                lblOSRemainingQuantity1.Visible = true;
                lblOSPartNumber1.Text = items[0].part_number;
            }
            if (items.Count > 1)
            {
                out_of_stock2.Visible = true;
                lblOSPartNumber2.Visible = true;
                lblOSRemainingQuantity2.Visible = true;
                lblOSPartNumber2.Text = items[1].part_number;
            }
            if (items.Count > 2)
            {
                out_of_stock3.Visible = true;
                lblOSPartNumber3.Visible = true;
                lblOSRemainingQuantity3.Visible = true;
                lblOSPartNumber3.Text = items[2].part_number;
            }
            if (items.Count > 3)
            {
                out_of_stock4.Visible = true;
                lblOSPartNumber4.Visible = true;
                lblOSRemainingQuantity4.Visible = true;
                lblOSPartNumber4.Text = items[3].part_number;
            }

        }

        public void RefreshData()
        {
            HideLabels();

            UIHelper.UpdatePanelRegion(panel1);
            UIHelper.UpdatePanelRegion(panel2);
            UIHelper.UpdatePanelRegion(panel3);
            UIHelper.UpdatePanelRegion(panel4);
            UIHelper.UpdatePanelRegion(panel5);

            InventorySummaryLoad();
            SalesOverviewLoad();
            LowInStockLoad();
            OutOfStockLoad();
        }
    }
}
