namespace InventoryManagementSystem
{
    partial class UC_Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            btnReload = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            dgvItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            part_number = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            quantity_in_hand = new DataGridViewTextBoxColumn();
            quantity_sold = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            availability = new DataGridViewTextBoxColumn();
            btnAddItem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnFilters = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            middlePanel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 159);
            panel1.TabIndex = 0;
            panel1.SizeChanged += panel1_SizeChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnReload);
            panel2.Controls.Add(siticoneHtmlLabel1);
            panel2.Controls.Add(dgvItems);
            panel2.Controls.Add(btnAddItem);
            panel2.Controls.Add(btnFilters);
            panel2.Location = new Point(19, 200);
            panel2.Margin = new Padding(30, 29, 30, 29);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 19, 0, 0);
            panel2.Size = new Size(1101, 592);
            panel2.TabIndex = 1;
            panel2.SizeChanged += panel2_SizeChanged;
            panel2.Paint += panel2_Paint;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.FillColor = Color.Transparent;
            btnReload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReload.ForeColor = Color.White;
            btnReload.HoverState.BorderColor = Color.Transparent;
            btnReload.HoverState.FillColor = Color.Transparent;
            btnReload.HoverState.Image = Properties.Resources.reloadBlue;
            btnReload.Image = Properties.Resources.reload;
            btnReload.ImageOffset = new Point(1, 0);
            btnReload.ImageSize = new Size(16, 15);
            btnReload.Location = new Point(811, 24);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.PressedColor = Color.Transparent;
            btnReload.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            btnReload.Size = new Size(34, 40);
            btnReload.TabIndex = 4;
            btnReload.Click += btnReload_Click;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(16, 21);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(54, 30);
            siticoneHtmlLabel1.TabIndex = 3;
            siticoneHtmlLabel1.Text = "Items";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeight = 30;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { part_number, description, brand, quantity, quantity_in_hand, quantity_sold, unit_price, availability });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.GridColor = Color.FromArgb(240, 241, 243);
            dgvItems.Location = new Point(0, 85);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 50;
            dgvItems.RowTemplate.Height = 29;
            dgvItems.Size = new Size(1101, 507);
            dgvItems.TabIndex = 2;
            dgvItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvItems.ThemeStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItems.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.ThemeStyle.HeaderStyle.Height = 30;
            dgvItems.ThemeStyle.ReadOnly = false;
            dgvItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.ThemeStyle.RowsStyle.Height = 29;
            dgvItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // part_number
            // 
            part_number.HeaderText = "Part No";
            part_number.MinimumWidth = 6;
            part_number.Name = "part_number";
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.MinimumWidth = 6;
            brand.Name = "brand";
            // 
            // quantity
            // 
            quantity.HeaderText = "Total Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // quantity_in_hand
            // 
            quantity_in_hand.HeaderText = "Quantity in Hand";
            quantity_in_hand.MinimumWidth = 6;
            quantity_in_hand.Name = "quantity_in_hand";
            // 
            // quantity_sold
            // 
            quantity_sold.HeaderText = "Quantity Sold";
            quantity_sold.MinimumWidth = 6;
            quantity_sold.Name = "quantity_sold";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit Price (Rs)";
            unit_price.MinimumWidth = 6;
            unit_price.Name = "unit_price";
            // 
            // availability
            // 
            availability.HeaderText = "Availability";
            availability.MinimumWidth = 6;
            availability.Name = "availability";
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddItem.BorderRadius = 4;
            btnAddItem.BorderThickness = 2;
            btnAddItem.DisabledState.BorderColor = Color.DarkGray;
            btnAddItem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItem.FillColor = Color.FromArgb(10, 73, 156);
            btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.ImageOffset = new Point(0, 1);
            btnAddItem.ImageSize = new Size(15, 10);
            btnAddItem.Location = new Point(853, 24);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(102, 40);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextOffset = new Point(2, 0);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnFilters
            // 
            btnFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilters.BorderColor = Color.FromArgb(208, 211, 217);
            btnFilters.BorderRadius = 4;
            btnFilters.BorderThickness = 2;
            btnFilters.DisabledState.BorderColor = Color.DarkGray;
            btnFilters.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilters.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilters.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilters.FillColor = Color.White;
            btnFilters.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilters.ForeColor = Color.FromArgb(93, 102, 121);
            btnFilters.Image = Properties.Resources.filters;
            btnFilters.ImageOffset = new Point(0, 1);
            btnFilters.ImageSize = new Size(15, 10);
            btnFilters.Location = new Point(971, 24);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(102, 40);
            btnFilters.TabIndex = 0;
            btnFilters.Text = "Filters";
            btnFilters.TextOffset = new Point(2, 0);
            btnFilters.Click += btnFilters_Click;
            // 
            // middlePanel
            // 
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(19, 19);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(1101, 773);
            middlePanel.TabIndex = 2;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(middlePanel);
            Name = "UC_Inventory";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1142, 813);
            Load += UC_Inventory_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel middlePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFilters;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddItem;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvItems;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private DataGridViewTextBoxColumn part_number;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn quantity_in_hand;
        private DataGridViewTextBoxColumn quantity_sold;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn availability;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnReload;
    }
}
