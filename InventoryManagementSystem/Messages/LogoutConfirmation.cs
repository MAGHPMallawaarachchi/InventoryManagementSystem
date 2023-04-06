﻿using System;
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
    public partial class LogoutConfirmation : Form
    {
        public bool Cancelled { get; private set; }

        public LogoutConfirmation()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancelled = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
