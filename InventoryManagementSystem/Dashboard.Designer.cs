﻿namespace InventoryManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            btnLogout = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnNewInvoice = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnOrders = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnCustomers = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnReports = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnInventory = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDashboard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblUser = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneCirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(btnLogout);
            siticonePanel1.Controls.Add(btnNewInvoice);
            siticonePanel1.Controls.Add(btnOrders);
            siticonePanel1.Controls.Add(btnCustomers);
            siticonePanel1.Controls.Add(btnReports);
            siticonePanel1.Controls.Add(btnInventory);
            siticonePanel1.Controls.Add(btnDashboard);
            siticonePanel1.Controls.Add(pictureBox1);
            siticonePanel1.Dock = DockStyle.Left;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Margin = new Padding(3, 3, 10, 3);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(280, 913);
            siticonePanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnLogout.CheckedState.FillColor = Color.Transparent;
            btnLogout.CheckedState.ForeColor = Color.FromArgb(10, 73, 156);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Transparent;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(93, 102, 121);
            btnLogout.HoverState.BorderColor = Color.Transparent;
            btnLogout.HoverState.CustomBorderColor = Color.Transparent;
            btnLogout.HoverState.FillColor = Color.Transparent;
            btnLogout.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnLogout.HoverState.Image = Properties.Resources.logoutBlue;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = HorizontalAlignment.Left;
            btnLogout.ImageOffset = new Point(30, 0);
            btnLogout.Location = new Point(2, 836);
            btnLogout.Name = "btnLogout";
            btnLogout.PressedDepth = 0;
            btnLogout.Size = new Size(277, 56);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = HorizontalAlignment.Left;
            btnLogout.TextOffset = new Point(35, 0);
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.BackColor = Color.Transparent;
            btnNewInvoice.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnNewInvoice.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnNewInvoice.CheckedState.FillColor = Color.Transparent;
            btnNewInvoice.Cursor = Cursors.Hand;
            btnNewInvoice.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnNewInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnNewInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNewInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNewInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNewInvoice.FillColor = Color.Transparent;
            btnNewInvoice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewInvoice.ForeColor = Color.FromArgb(93, 102, 121);
            btnNewInvoice.HoverState.BorderColor = Color.Transparent;
            btnNewInvoice.HoverState.CustomBorderColor = Color.Transparent;
            btnNewInvoice.HoverState.FillColor = Color.Transparent;
            btnNewInvoice.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnNewInvoice.HoverState.Image = Properties.Resources.newInvoiceBlue;
            btnNewInvoice.Image = Properties.Resources.newInvoice;
            btnNewInvoice.ImageAlign = HorizontalAlignment.Left;
            btnNewInvoice.ImageOffset = new Point(30, 0);
            btnNewInvoice.ImageSize = new Size(20, 22);
            btnNewInvoice.Location = new Point(0, 462);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.PressedDepth = 0;
            btnNewInvoice.Size = new Size(277, 56);
            btnNewInvoice.TabIndex = 6;
            btnNewInvoice.Text = "New Invoice";
            btnNewInvoice.TextAlign = HorizontalAlignment.Left;
            btnNewInvoice.TextOffset = new Point(35, 0);
            btnNewInvoice.Click += btnNewInvoice_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Transparent;
            btnOrders.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnOrders.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnOrders.CheckedState.FillColor = Color.Transparent;
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnOrders.DisabledState.BorderColor = Color.DarkGray;
            btnOrders.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOrders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOrders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOrders.FillColor = Color.Transparent;
            btnOrders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrders.ForeColor = Color.FromArgb(93, 102, 121);
            btnOrders.HoverState.BorderColor = Color.Transparent;
            btnOrders.HoverState.CustomBorderColor = Color.Transparent;
            btnOrders.HoverState.FillColor = Color.Transparent;
            btnOrders.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnOrders.HoverState.Image = Properties.Resources.invoicesBlue;
            btnOrders.Image = Properties.Resources.invoices;
            btnOrders.ImageAlign = HorizontalAlignment.Left;
            btnOrders.ImageOffset = new Point(30, 0);
            btnOrders.ImageSize = new Size(17, 20);
            btnOrders.Location = new Point(0, 396);
            btnOrders.Name = "btnOrders";
            btnOrders.PressedDepth = 0;
            btnOrders.Size = new Size(277, 56);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Invoices";
            btnOrders.TextAlign = HorizontalAlignment.Left;
            btnOrders.TextOffset = new Point(35, 0);
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomers.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnCustomers.CheckedState.FillColor = Color.Transparent;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnCustomers.DisabledState.BorderColor = Color.DarkGray;
            btnCustomers.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomers.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomers.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomers.FillColor = Color.Transparent;
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.FromArgb(93, 102, 121);
            btnCustomers.HoverState.BorderColor = Color.Transparent;
            btnCustomers.HoverState.CustomBorderColor = Color.Transparent;
            btnCustomers.HoverState.FillColor = Color.Transparent;
            btnCustomers.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnCustomers.HoverState.Image = Properties.Resources.customersBlue;
            btnCustomers.Image = Properties.Resources.customers;
            btnCustomers.ImageAlign = HorizontalAlignment.Left;
            btnCustomers.ImageOffset = new Point(30, 0);
            btnCustomers.Location = new Point(0, 332);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.PressedDepth = 0;
            btnCustomers.Size = new Size(277, 56);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = HorizontalAlignment.Left;
            btnCustomers.TextOffset = new Point(35, 0);
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnReports.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnReports.CheckedState.FillColor = Color.Transparent;
            btnReports.Cursor = Cursors.Hand;
            btnReports.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnReports.DisabledState.BorderColor = Color.DarkGray;
            btnReports.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReports.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReports.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReports.FillColor = Color.Transparent;
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = Color.FromArgb(93, 102, 121);
            btnReports.HoverState.BorderColor = Color.Transparent;
            btnReports.HoverState.CustomBorderColor = Color.Transparent;
            btnReports.HoverState.FillColor = Color.Transparent;
            btnReports.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnReports.HoverState.Image = Properties.Resources.reportsBlue;
            btnReports.Image = Properties.Resources.reports;
            btnReports.ImageAlign = HorizontalAlignment.Left;
            btnReports.ImageOffset = new Point(30, 0);
            btnReports.Location = new Point(0, 268);
            btnReports.Name = "btnReports";
            btnReports.PressedDepth = 0;
            btnReports.Size = new Size(277, 56);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextAlign = HorizontalAlignment.Left;
            btnReports.TextOffset = new Point(35, 0);
            btnReports.Click += btnReports_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Transparent;
            btnInventory.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnInventory.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnInventory.CheckedState.FillColor = Color.Transparent;
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnInventory.DisabledState.BorderColor = Color.DarkGray;
            btnInventory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInventory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInventory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInventory.FillColor = Color.Transparent;
            btnInventory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.ForeColor = Color.FromArgb(93, 102, 121);
            btnInventory.HoverState.BorderColor = Color.Transparent;
            btnInventory.HoverState.CustomBorderColor = Color.Transparent;
            btnInventory.HoverState.FillColor = Color.Transparent;
            btnInventory.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnInventory.HoverState.Image = Properties.Resources.inventoryBlue;
            btnInventory.Image = Properties.Resources.inventory;
            btnInventory.ImageAlign = HorizontalAlignment.Left;
            btnInventory.ImageOffset = new Point(30, 0);
            btnInventory.Location = new Point(0, 204);
            btnInventory.Name = "btnInventory";
            btnInventory.PressedDepth = 0;
            btnInventory.Size = new Size(277, 56);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = HorizontalAlignment.Left;
            btnInventory.TextOffset = new Point(35, 0);
            btnInventory.CheckedChanged += btnInventory_Click;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            btnDashboard.Checked = true;
            btnDashboard.CheckedState.CustomBorderColor = Color.FromArgb(10, 73, 156);
            btnDashboard.CheckedState.FillColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.CustomBorderColor = Color.Transparent;
            btnDashboard.CustomBorderThickness = new Padding(5, 0, 0, 0);
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(93, 102, 121);
            btnDashboard.HoverState.BorderColor = Color.Transparent;
            btnDashboard.HoverState.CustomBorderColor = Color.Transparent;
            btnDashboard.HoverState.FillColor = Color.Transparent;
            btnDashboard.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnDashboard.HoverState.Image = Properties.Resources.dashboardBlue;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = HorizontalAlignment.Left;
            btnDashboard.ImageOffset = new Point(30, 0);
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.PressedDepth = 0;
            btnDashboard.Size = new Size(277, 56);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = HorizontalAlignment.Left;
            btnDashboard.TextOffset = new Point(35, 0);
            btnDashboard.CheckedChanged += btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2022_09_19_at_14_47_15_removebg_preview;
            pictureBox1.Location = new Point(36, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(siticoneCirclePictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(280, 0);
            panel1.Margin = new Padding(10, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 100);
            panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(56, 62, 73);
            lblUser.Location = new Point(21, 32);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(157, 33);
            lblUser.TabIndex = 1;
            lblUser.Text = "Welcome user!";
            // 
            // siticoneCirclePictureBox1
            // 
            siticoneCirclePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            siticoneCirclePictureBox1.Image = Properties.Resources.admin;
            siticoneCirclePictureBox1.ImageRotate = 0F;
            siticoneCirclePictureBox1.Location = new Point(1065, 21);
            siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            siticoneCirclePictureBox1.Size = new Size(54, 54);
            siticoneCirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            siticoneCirclePictureBox1.TabIndex = 0;
            siticoneCirclePictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            ClientSize = new Size(1422, 913);
            Controls.Add(panel1);
            Controls.Add(siticonePanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneCirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnOrders;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCustomers;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnReports;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnInventory;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDashboard;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNewInvoice;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblUser;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogout;
    }
}