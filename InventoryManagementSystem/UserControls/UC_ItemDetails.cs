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

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        public UC_ItemDetails()
        {
            InitializeComponent();
        }
        
        public void UpdateContent(string part_number)
        {
            partNumber.Text = part_number.ToString();
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

        private void btnBack_Click(object sender, EventArgs e)
        {

            UC_Inventory uc = new UC_Inventory();

            Dashboard? dashboard = this.FindForm() as Dashboard;

            if (dashboard != null)
            {
                dashboard.addUserControl(uc);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        
        }
        
        private void UC_ItemDetails_Load(object sender, EventArgs e)
        {

        }
        
    }
}

