namespace InventoryManagementSystem
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
            btnOrders = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnCustomers = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnReports = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnInventory = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDashboard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(btnOrders);
            siticonePanel1.Controls.Add(btnCustomers);
            siticonePanel1.Controls.Add(btnReports);
            siticonePanel1.Controls.Add(btnInventory);
            siticonePanel1.Controls.Add(btnDashboard);
            siticonePanel1.Controls.Add(pictureBox1);
            siticonePanel1.Dock = DockStyle.Left;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(250, 913);
            siticonePanel1.TabIndex = 0;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Transparent;
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
            btnOrders.HoverState.Image = Properties.Resources.ordersBlue;
            btnOrders.Image = Properties.Resources.orders;
            btnOrders.ImageAlign = HorizontalAlignment.Left;
            btnOrders.Location = new Point(25, 396);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 56);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = HorizontalAlignment.Left;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
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
            btnCustomers.Location = new Point(25, 332);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(200, 56);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = HorizontalAlignment.Left;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
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
            btnReports.Location = new Point(25, 268);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 56);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextAlign = HorizontalAlignment.Left;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Transparent;
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
            btnInventory.Location = new Point(24, 204);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 56);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = HorizontalAlignment.Left;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
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
            btnDashboard.Location = new Point(24, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 56);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = HorizontalAlignment.Left;
            btnDashboard.Click += siticoneButton1_Click;
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 100);
            panel1.TabIndex = 1;
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
            Text = "Dashboard";
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}