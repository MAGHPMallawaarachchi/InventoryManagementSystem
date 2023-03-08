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

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        public UC_ItemDetails()
        {
            InitializeComponent();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void siticonePanel1_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(siticonePanel1);
        }

        private void siticonePanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void partNumber_Click(object sender, EventArgs e)
        {
        }

        private void primaryDetails_Click(object sender, EventArgs e)
        {
        }

        private void itemNumber_Click(object sender, EventArgs e)
        {
        }

        private void oemumber_Click(object sender, EventArgs e)
        {
        }

        private void description_Click(object sender, EventArgs e)
        {
        }

        private void category_Click(object sender, EventArgs e)
        {
        }

        private void brand_Click(object sender, EventArgs e)
        {
        }

        private void supplierDetails_Click(object sender, EventArgs e)
        {
        }

        private void supplierName_Click(object sender, EventArgs e)
        {
        }

        private void supplierEmail_Click(object sender, EventArgs e)
        {
        }

        private void priceDetails_Click(object sender, EventArgs e)
        {
        }

        private void buyingPrice_Click(object sender, EventArgs e)
        {
        }

        private void qtySold_Click(object sender, EventArgs e)
        {

        }
    }
}
