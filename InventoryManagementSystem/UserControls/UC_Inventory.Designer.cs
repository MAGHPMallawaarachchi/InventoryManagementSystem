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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvOverallInventory = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            categories = new DataGridViewTextBoxColumn();
            total_items = new DataGridViewTextBoxColumn();
            low_in_stock = new DataGridViewTextBoxColumn();
            out_of_stock = new DataGridViewTextBoxColumn();
            lblOverallInventory = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel2 = new Panel();
            btnClear = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cbBrand = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
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
            dataGridViewCellStyle10.BackColor = Color.White;
            dgvOverallInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvOverallInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle11.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvOverallInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvOverallInventory.ColumnHeadersHeight = 30;
            dgvOverallInventory.Columns.AddRange(new DataGridViewColumn[] { categories, total_items, low_in_stock, out_of_stock });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle12.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvOverallInventory.DefaultCellStyle = dataGridViewCellStyle12;
            dgvOverallInventory.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverallInventory.ImeMode = ImeMode.NoControl;
            dgvOverallInventory.Location = new Point(0, 67);
            dgvOverallInventory.Name = "dgvOverallInventory";
            dgvOverallInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvOverallInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(cbBrand);
            panel2.Controls.Add(cbCategory);
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
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BorderColor = Color.FromArgb(208, 211, 217);
            btnClear.BorderRadius = 4;
            btnClear.BorderThickness = 2;
            btnClear.Cursor = Cursors.Hand;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(93, 102, 121);
            btnClear.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnClear.HoverState.FillColor = Color.Transparent;
            btnClear.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnClear.ImageOffset = new Point(0, 1);
            btnClear.ImageSize = new Size(15, 10);
            btnClear.Location = new Point(848, 24);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 40);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.TextOffset = new Point(2, 0);
            btnClear.Click += btnClear_Click;
            // 
            // cbBrand
            // 
            cbBrand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBrand.BackColor = Color.Transparent;
            cbBrand.BorderColor = Color.FromArgb(208, 213, 221);
            cbBrand.BorderRadius = 8;
            cbBrand.Cursor = Cursors.Hand;
            cbBrand.DrawMode = DrawMode.OwnerDrawFixed;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.ForeColor = Color.FromArgb(72, 80, 94);
            cbBrand.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbBrand.ItemHeight = 30;
            cbBrand.Location = new Point(234, 24);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(270, 36);
            cbBrand.TabIndex = 51;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderColor = Color.FromArgb(208, 213, 221);
            cbCategory.BorderRadius = 8;
            cbCategory.Cursor = Cursors.Hand;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(72, 80, 94);
            cbCategory.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbCategory.ItemHeight = 30;
            cbCategory.Location = new Point(526, 24);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(298, 36);
            cbCategory.TabIndex = 50;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
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
            dataGridViewCellStyle14.BackColor = Color.White;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle15.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = Color.White;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvItems.ColumnHeadersHeight = 50;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { checkboxColumn, part_number, description, brand, quantity, quantity_in_hand, quantity_sold, unit_price, availability });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle17.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = Color.White;
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle17;
            dgvItems.GridColor = Color.FromArgb(240, 241, 243);
            dgvItems.Location = new Point(0, 85);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            dgvItems.CellMouseEnter += dgvItems_CellMouseEnter;
            dgvItems.CellMouseLeave += dgvItems_CellMouseLeave;
            // 
            // checkboxColumn
            // 
            checkboxColumn.HeaderText = "";
            checkboxColumn.MinimumWidth = 6;
            checkboxColumn.Name = "checkboxColumn";
            checkboxColumn.Resizable = DataGridViewTriState.True;
            checkboxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
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
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            quantity_in_hand.DefaultCellStyle = dataGridViewCellStyle16;
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
            btnAddItem.Location = new Point(973, 24);
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
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbBrand;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClear;
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
