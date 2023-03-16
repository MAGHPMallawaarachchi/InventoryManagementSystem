namespace InventoryManagementSystem.UserControls
{
    partial class UC_Reports
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            middlePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            Panel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            lblBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Panel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvOverview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            total_profit = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            sales = new DataGridViewTextBoxColumn();
            lblOverview = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            part_number = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            quantity_sold = new DataGridViewTextBoxColumn();
            quantity_in_hand = new DataGridViewTextBoxColumn();
            revenue = new DataGridViewTextBoxColumn();
            profit = new DataGridViewTextBoxColumn();
            middlePanel.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingItems).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingCategories).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            SuspendLayout();
            // 
            // middlePanel
            // 
            middlePanel.Controls.Add(Panel3);
            middlePanel.Controls.Add(Panel2);
            middlePanel.Controls.Add(Panel1);
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(20, 20);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(1027, 766);
            middlePanel.TabIndex = 2;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(dgvBestSellingItems);
            Panel3.Controls.Add(lblBestSellingItems);
            Panel3.Location = new Point(0, 261);
            Panel3.Name = "Panel3";
            Panel3.Padding = new Padding(10, 0, 10, 0);
            Panel3.Size = new Size(1027, 505);
            Panel3.TabIndex = 4;
            Panel3.SizeChanged += Panel3_SizeChanged;
            // 
            // dgvBestSellingItems
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBestSellingItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBestSellingItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBestSellingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBestSellingItems.ColumnHeadersHeight = 22;
            dgvBestSellingItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBestSellingItems.Columns.AddRange(new DataGridViewColumn[] { part_number, brand, category, quantity_sold, quantity_in_hand, revenue, profit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBestSellingItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBestSellingItems.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingItems.Location = new Point(10, 94);
            dgvBestSellingItems.Name = "dgvBestSellingItems";
            dgvBestSellingItems.RowHeadersVisible = false;
            dgvBestSellingItems.RowHeadersWidth = 51;
            dgvBestSellingItems.RowTemplate.Height = 29;
            dgvBestSellingItems.Size = new Size(1007, 411);
            dgvBestSellingItems.TabIndex = 19;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.Height = 22;
            dgvBestSellingItems.ThemeStyle.ReadOnly = false;
            dgvBestSellingItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBestSellingItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBestSellingItems.ThemeStyle.RowsStyle.Height = 29;
            dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblBestSellingItems
            // 
            lblBestSellingItems.BackColor = Color.Transparent;
            lblBestSellingItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestSellingItems.Location = new Point(31, 29);
            lblBestSellingItems.Name = "lblBestSellingItems";
            lblBestSellingItems.Size = new Size(166, 30);
            lblBestSellingItems.TabIndex = 18;
            lblBestSellingItems.Text = "Best Selling Items";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(dgvBestSellingCategories);
            Panel2.Controls.Add(lblBestSellingCategories);
            Panel2.Location = new Point(608, 0);
            Panel2.Name = "Panel2";
            Panel2.Padding = new Padding(10, 0, 10, 0);
            Panel2.Size = new Size(419, 234);
            Panel2.TabIndex = 3;
            Panel2.SizeChanged += Panel2_SizeChanged;
            // 
            // dgvBestSellingCategories
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvBestSellingCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBestSellingCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBestSellingCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBestSellingCategories.ColumnHeadersHeight = 22;
            dgvBestSellingCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBestSellingCategories.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBestSellingCategories.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBestSellingCategories.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingCategories.Location = new Point(10, 86);
            dgvBestSellingCategories.Name = "dgvBestSellingCategories";
            dgvBestSellingCategories.RowHeadersVisible = false;
            dgvBestSellingCategories.RowHeadersWidth = 51;
            dgvBestSellingCategories.RowTemplate.Height = 29;
            dgvBestSellingCategories.Size = new Size(399, 148);
            dgvBestSellingCategories.TabIndex = 19;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.Height = 22;
            dgvBestSellingCategories.ThemeStyle.ReadOnly = false;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.Height = 29;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Category";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Revenue";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Profit";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblBestSellingCategories
            // 
            lblBestSellingCategories.BackColor = Color.Transparent;
            lblBestSellingCategories.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestSellingCategories.Location = new Point(35, 20);
            lblBestSellingCategories.Name = "lblBestSellingCategories";
            lblBestSellingCategories.Size = new Size(211, 30);
            lblBestSellingCategories.TabIndex = 18;
            lblBestSellingCategories.Text = "Best Selling Categories";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(dgvOverview);
            Panel1.Controls.Add(lblOverview);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(10, 0, 10, 0);
            Panel1.Size = new Size(579, 234);
            Panel1.TabIndex = 2;
            Panel1.StyleChanged += Panel1_StyleChanged;
            // 
            // dgvOverview
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvOverview.ColumnHeadersHeight = 22;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOverview.Columns.AddRange(new DataGridViewColumn[] { total_profit, dataGridViewTextBoxColumn4, sales });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvOverview.DefaultCellStyle = dataGridViewCellStyle9;
            dgvOverview.GridColor = Color.FromArgb(231, 229, 255);
            dgvOverview.Location = new Point(10, 86);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvOverview.RowHeadersVisible = false;
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.RowTemplate.Height = 29;
            dgvOverview.Size = new Size(556, 145);
            dgvOverview.TabIndex = 21;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOverview.ThemeStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOverview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOverview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOverview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOverview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOverview.ThemeStyle.HeaderStyle.Height = 22;
            dgvOverview.ThemeStyle.ReadOnly = false;
            dgvOverview.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOverview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOverview.ThemeStyle.RowsStyle.Height = 29;
            dgvOverview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOverview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // total_profit
            // 
            total_profit.HeaderText = "Total Profit";
            total_profit.MinimumWidth = 6;
            total_profit.Name = "total_profit";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Revenue";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // sales
            // 
            sales.HeaderText = "Sales";
            sales.MinimumWidth = 6;
            sales.Name = "sales";
            // 
            // lblOverview
            // 
            lblOverview.BackColor = Color.Transparent;
            lblOverview.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverview.Location = new Point(31, 20);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(87, 30);
            lblOverview.TabIndex = 20;
            lblOverview.Text = "Overview\r\n";
            // 
            // part_number
            // 
            part_number.HeaderText = "Part Number";
            part_number.MinimumWidth = 6;
            part_number.Name = "part_number";
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.MinimumWidth = 6;
            brand.Name = "brand";
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // quantity_sold
            // 
            quantity_sold.HeaderText = "Quantity Sold";
            quantity_sold.MinimumWidth = 6;
            quantity_sold.Name = "quantity_sold";
            // 
            // quantity_in_hand
            // 
            quantity_in_hand.HeaderText = "Quantity in Hand";
            quantity_in_hand.MinimumWidth = 6;
            quantity_in_hand.Name = "quantity_in_hand";
            // 
            // revenue
            // 
            revenue.HeaderText = "Revenue";
            revenue.MinimumWidth = 6;
            revenue.Name = "revenue";
            // 
            // profit
            // 
            profit.HeaderText = "Profit";
            profit.MinimumWidth = 6;
            profit.Name = "profit";
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(middlePanel);
            Name = "UC_Reports";
            Padding = new Padding(20);
            Size = new Size(1067, 806);
            Load += UC_Reports_Load;
            middlePanel.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingItems).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingCategories).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel middlePanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblBestSellingItems;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblBestSellingCategories;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOverview;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvOverview;
        private DataGridViewTextBoxColumn total_profit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn sales;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingCategories;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingItems;
        private DataGridViewTextBoxColumn part_number;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity_sold;
        private DataGridViewTextBoxColumn quantity_in_hand;
        private DataGridViewTextBoxColumn revenue;
        private DataGridViewTextBoxColumn profit;
    }
}
