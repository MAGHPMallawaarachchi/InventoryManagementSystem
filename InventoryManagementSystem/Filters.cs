using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class Filters : Form
    {
        private readonly MongoConnector _mongoConnector;
        private readonly UC_Inventory _ucInventory;

        public Filters(UC_Inventory ucInventory)
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");

            _ucInventory = ucInventory;
        }

        private void Filters_Load(object sender, EventArgs e)
        {
            cbBrandLoad();
            cbCategoryLoad();
        }

        private async void cbBrandLoad()
        {
            cbBrand.Items.Add("-- Brand --");
            cbBrand.SelectedIndex = 0;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;

            var filter = Builders<BsonDocument>.Filter.Empty;
            var uniqueBrands = await _mongoConnector.GetUniqueField("brand", filter);

            foreach (var brand in uniqueBrands)
            {
                cbBrand.Items.Add(brand);
            }
        }

        private async void cbCategoryLoad()
        {
            // Add the placeholder item to the ComboBox
            cbCategory.Items.Clear();
            cbCategory.Items.Add("-- Category --");
            cbCategory.SelectedIndex = 0;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cbBrand.Text == "-- Brand --")
            {
                var filter = Builders<BsonDocument>.Filter.Empty;
                var uniqueCategories = await _mongoConnector.GetUniqueField("category", filter);

                foreach (var category in uniqueCategories)
                {
                    cbCategory.Items.Add(category);
                }
            }
            else
            {
                var filter = Builders<BsonDocument>.Filter.Eq("brand", cbBrand.Text);
                var uniqueCategoriesByBrand = await _mongoConnector.GetUniqueField("category", filter);

                foreach (var category in uniqueCategoriesByBrand)
                {
                    cbCategory.Items.Add(category);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbBrand.SelectedIndex = 0;

            cbCategory.Items.Clear();
            cbCategoryLoad();

            bool clear = true;

            _ucInventory.ItemsLoad(clear);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFilters_Click(object sender, EventArgs e)
        {
            string brand = cbBrand.Text;
            string category = cbCategory.Text;

            _ucInventory.ItemsLoadWithFilters(brand, category);
        }

        private void cbBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex != 0)
            {
                cbCategoryLoad();
            }
        }

    }
}
