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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvOverallInventory = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            categories = new DataGridViewTextBoxColumn();
            total_items = new DataGridViewTextBoxColumn();
            low_in_stock = new DataGridViewTextBoxColumn();
            out_of_stock = new DataGridViewTextBoxColumn();
            lblOverallInventory = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel2 = new Panel();
            btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnFilters = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            lblItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            dgvItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            checkboxColumn = new DataGridViewCheckBoxColumn();
            part_number = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            quantity_in_hand = new DataGridViewTextBoxColumn();
            quantity_sold = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            availability = new DataGridViewTextBoxColumn();
            btnAddItem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            middlePanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverallInventory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvOverallInventory);
            panel1.Controls.Add(lblOverallInventory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 159);
            panel1.TabIndex = 0;
            panel1.SizeChanged += panel1_SizeChanged;
            // 
            // dgvOverallInventory
            // 
            dgvOverallInventory.AllowUserToAddRows = false;
            dgvOverallInventory.AllowUserToDeleteRows = false;
            dgvOverallInventory.AllowUserToResizeColumns = false;
            dgvOverallInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOverallInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOverallInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOverallInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOverallInventory.ColumnHeadersHeight = 30;
            dgvOverallInventory.Columns.AddRange(new DataGridViewColumn[] { categories, total_items, low_in_stock, out_of_stock });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOverallInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOverallInventory.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverallInventory.ImeMode = ImeMode.NoControl;
            dgvOverallInventory.Location = new Point(0, 67);
            dgvOverallInventory.Name = "dgvOverallInventory";
            dgvOverallInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvOverallInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvOverallInventory.RowHeadersVisible = false;
            dgvOverallInventory.RowHeadersWidth = 50;
            dgvOverallInventory.RowTemplate.Height = 29;
            dgvOverallInventory.Size = new Size(1101, 93);
            dgvOverallInventory.TabIndex = 5;
            dgvOverallInventory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOverallInventory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOverallInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOverallInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOverallInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOverallInventory.ThemeStyle.BackColor = Color.White;
            dgvOverallInventory.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverallInventory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOverallInventory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOverallInventory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverallInventory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOverallInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOverallInventory.ThemeStyle.HeaderStyle.Height = 30;
            dgvOverallInventory.ThemeStyle.ReadOnly = false;
            dgvOverallInventory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOverallInventory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOverallInventory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverallInventory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOverallInventory.ThemeStyle.RowsStyle.Height = 29;
            dgvOverallInventory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOverallInventory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvOverallInventory.CellPainting += dgvOverallInventory_CellPainting;
            // 
            // categories
            // 
            categories.HeaderText = "Categories";
            categories.MinimumWidth = 6;
            categories.Name = "categories";
            // 
            // total_items
            // 
            total_items.HeaderText = "Total Items";
            total_items.MinimumWidth = 6;
            total_items.Name = "total_items";
            // 
            // low_in_stock
            // 
            low_in_stock.HeaderText = "Low in Stock";
            low_in_stock.MinimumWidth = 6;
            low_in_stock.Name = "low_in_stock";
            // 
            // out_of_stock
            // 
            out_of_stock.HeaderText = "Out of Stock";
            out_of_stock.MinimumWidth = 6;
            out_of_stock.Name = "out_of_stock";
            // 
            // lblOverallInventory
            // 
            lblOverallInventory.BackColor = Color.Transparent;
            lblOverallInventory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverallInventory.Location = new Point(16, 15);
            lblOverallInventory.Name = "lblOverallInventory";
            lblOverallInventory.Size = new Size(159, 30);
            lblOverallInventory.TabIndex = 5;
            lblOverallInventory.Text = "Overall Inventory";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnFilters);
            panel2.Controls.Add(lblItems);
            panel2.Controls.Add(dgvItems);
            panel2.Controls.Add(btnAddItem);
            panel2.Location = new Point(19, 200);
            panel2.Margin = new Padding(30, 29, 30, 29);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 19, 0, 0);
            panel2.Size = new Size(1101, 592);
            panel2.TabIndex = 1;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BorderColor = Color.FromArgb(243, 105, 96);
            btnDelete.BorderRadius = 4;
            btnDelete.BorderThickness = 2;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(243, 105, 96);
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.BorderColor = Color.FromArgb(243, 105, 96);
            btnDelete.HoverState.FillColor = Color.FromArgb(243, 105, 96);
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageOffset = new Point(0, 1);
            btnDelete.ImageSize = new Size(16, 18);
            btnDelete.Location = new Point(737, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 40);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.TextOffset = new Point(2, 0);
            btnDelete.Click += btnDelete_Click;
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
            btnFilters.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnFilters.HoverState.FillColor = Color.Transparent;
            btnFilters.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnFilters.Image = Properties.Resources.filters;
            btnFilters.ImageOffset = new Point(0, 1);
            btnFilters.ImageSize = new Size(15, 10);
            btnFilters.Location = new Point(856, 22);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(102, 40);
            btnFilters.TabIndex = 53;
            btnFilters.Text = "Filters";
            btnFilters.TextOffset = new Point(2, 0);
            btnFilters.Click += btnFilters_Click;
            // 
            // lblItems
            // 
            lblItems.BackColor = Color.Transparent;
            lblItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItems.Location = new Point(16, 24);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(54, 30);
            lblItems.TabIndex = 3;
            lblItems.Text = "Items";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvItems.ColumnHeadersHeight = 50;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { checkboxColumn, part_number, description, brand, quantity, quantity_in_hand, quantity_sold, unit_price, availability });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle8.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle8;
            dgvItems.GridColor = Color.FromArgb(240, 241, 243);
            dgvItems.Location = new Point(0, 85);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dgvItems.ThemeStyle.HeaderStyle.Height = 50;
            dgvItems.ThemeStyle.ReadOnly = false;
            dgvItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.ThemeStyle.RowsStyle.Height = 29;
            dgvItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.CellClick += dgvItems_CellClick;
            dgvItems.CellFormatting += dgvItems_CellFormatting;
            dgvItems.CellMouseEnter += dgvItems_CellMouseEnter;
            dgvItems.CellMouseLeave += dgvItems_CellMouseLeave;
            dgvItems.CellPainting += dgvItems_CellPainting;
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            // 
            // checkboxColumn
            // 
            checkboxColumn.HeaderText = "";
            checkboxColumn.MinimumWidth = 6;
            checkboxColumn.Name = "checkboxColumn";
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
            description.MinimumWidth = 30;
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
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            quantity_in_hand.DefaultCellStyle = dataGridViewCellStyle7;
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
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.DisabledState.BorderColor = Color.DarkGray;
            btnAddItem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItem.FillColor = Color.FromArgb(10, 73, 156);
            btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddItem.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnAddItem.ImageOffset = new Point(0, 1);
            btnAddItem.ImageSize = new Size(15, 10);
            btnAddItem.Location = new Point(973, 22);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(102, 40);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextOffset = new Point(2, 0);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // middlePanel
            // 
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(19, 19);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(1101, 773);
            middlePanel.TabIndex = 2;
            middlePanel.Paint += middlePanel_Paint;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverallInventory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel middlePanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddItem;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvItems;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblItems;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOverallInventory;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvOverallInventory;
        private DataGridViewTextBoxColumn categories;
        private DataGridViewTextBoxColumn total_items;
        private DataGridViewTextBoxColumn low_in_stock;
        private DataGridViewTextBoxColumn out_of_stock;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFilters;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private DataGridViewCheckBoxColumn checkboxColumn;
        private DataGridViewTextBoxColumn part_number;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn quantity_in_hand;
        private DataGridViewTextBoxColumn quantity_sold;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn availability;
    }
}
