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
    public partial class Error : Form
    {

        public Error(string message)
        {
            InitializeComponent();
            lblErrorMessage.Text = message;
            this.TopMost = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
