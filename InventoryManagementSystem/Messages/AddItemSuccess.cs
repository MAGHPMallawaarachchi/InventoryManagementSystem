using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Messages
{
    public partial class AddItemSuccess : Form
    {
        public AddItemSuccess()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
