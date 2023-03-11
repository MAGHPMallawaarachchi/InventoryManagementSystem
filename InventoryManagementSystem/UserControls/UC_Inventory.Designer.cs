﻿namespace InventoryManagementSystem
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
            btnClear = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cbBrand = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            btnReload = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            lblItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
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
            panel1.Location = new Point(17, 14);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 119);
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
            dgvOverallInventory.Location = new Point(0, 50);
            dgvOverallInventory.Margin = new Padding(3, 2, 3, 2);
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
            dgvOverallInventory.Size = new Size(963, 70);
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
            lblOverallInventory.Location = new Point(14, 11);
            lblOverallInventory.Margin = new Padding(3, 2, 3, 2);
            lblOverallInventory.Name = "lblOverallInventory";
            lblOverallInventory.Size = new Size(128, 23);
            lblOverallInventory.TabIndex = 5;
            lblOverallInventory.Text = "Overall Inventory";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(cbBrand);
            panel2.Controls.Add(btnReload);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(lblItems);
            panel2.Controls.Add(dgvItems);
            panel2.Controls.Add(btnAddItem);
            panel2.Location = new Point(17, 150);
            panel2.Margin = new Padding(26, 22, 26, 22);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 14, 0, 0);
            panel2.Size = new Size(963, 444);
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
            btnClear.Location = new Point(742, 18);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 30);
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
            cbBrand.DrawMode = DrawMode.OwnerDrawFixed;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.ForeColor = Color.FromArgb(72, 80, 94);
            cbBrand.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbBrand.ItemHeight = 30;
            cbBrand.Location = new Point(205, 18);
            cbBrand.Margin = new Padding(3, 2, 3, 2);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(237, 36);
            cbBrand.TabIndex = 51;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // btnReload
            // 
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
            btnReload.Location = new Point(66, 16);
            btnReload.Name = "btnReload";
            btnReload.PressedColor = Color.Transparent;
            btnReload.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            btnReload.Size = new Size(30, 30);
            btnReload.TabIndex = 4;
            btnReload.Click += btnReload_Click;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderColor = Color.FromArgb(208, 213, 221);
            cbCategory.BorderRadius = 8;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(72, 80, 94);
            cbCategory.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbCategory.ItemHeight = 30;
            cbCategory.Location = new Point(460, 18);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(261, 36);
            cbCategory.TabIndex = 50;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblItems
            // 
            lblItems.BackColor = Color.Transparent;
            lblItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItems.Location = new Point(14, 18);
            lblItems.Margin = new Padding(3, 2, 3, 2);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(44, 23);
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
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { part_number, description, brand, quantity, quantity_in_hand, quantity_sold, unit_price, availability });
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
            dgvItems.Location = new Point(0, 64);
            dgvItems.Margin = new Padding(3, 2, 3, 2);
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
            dgvItems.Size = new Size(963, 380);
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
            btnAddItem.Location = new Point(851, 18);
            btnAddItem.Margin = new Padding(3, 2, 3, 2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(89, 30);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextOffset = new Point(2, 0);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // middlePanel
            // 
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(17, 14);
            middlePanel.Margin = new Padding(3, 2, 3, 2);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(963, 580);
            middlePanel.TabIndex = 2;
            middlePanel.Paint += middlePanel_Paint;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(middlePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Inventory";
            Padding = new Padding(17, 14, 19, 16);
            Size = new Size(999, 610);
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
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnReload;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOverallInventory;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvOverallInventory;
        private DataGridViewTextBoxColumn categories;
        private DataGridViewTextBoxColumn total_items;
        private DataGridViewTextBoxColumn low_in_stock;
        private DataGridViewTextBoxColumn out_of_stock;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbBrand;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClear;
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
