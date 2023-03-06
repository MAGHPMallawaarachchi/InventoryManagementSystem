using ImageResizer.Plugins.Basic;
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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            // Create rounded rectangle shape with 20 pixel radius corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddLine(20, 0, this.Width - 20, 0);
            path.AddArc(this.Width - 20, 0, 20, 20, 270, 90);
            path.AddLine(this.Width, 20, this.Width, this.Height - 20);
            path.AddArc(this.Width - 20, this.Height - 20, 20, 20, 0, 90);
            path.AddLine(this.Width - 20, this.Height, 20, this.Height);
            path.AddArc(0, this.Height - 20, 20, 20, 90, 90);
            path.CloseFigure();

            // Set form region to rounded rectangle shape
            this.Region = new Region(path);

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
