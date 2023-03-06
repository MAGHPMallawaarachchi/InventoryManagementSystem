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

namespace InventoryManagementSystem
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            UpdatePanelRegion(panel1);
            UpdatePanelRegion(panel2);
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


        private void UC_Inventory_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
