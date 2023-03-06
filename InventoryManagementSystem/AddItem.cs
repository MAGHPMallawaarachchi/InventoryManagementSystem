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

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
