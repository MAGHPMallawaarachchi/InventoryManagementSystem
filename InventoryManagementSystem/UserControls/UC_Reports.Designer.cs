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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            Panel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            lblBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Panel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            category = new DataGridViewTextBoxColumn();
            cat_quantity_sold = new DataGridViewTextBoxColumn();
            cat_revenue = new DataGridViewTextBoxColumn();
            cat_profit = new DataGridViewTextBoxColumn();
            lblBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            cbFilters = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            dgvOverview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            total_profit = new DataGridViewTextBoxColumn();
            revenue = new DataGridViewTextBoxColumn();
            sales = new DataGridViewTextBoxColumn();
            lblOverview = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnDownload = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tableLayoutPanel1.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingItems).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingCategories).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4513626F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5486374F));
            tableLayoutPanel1.Controls.Add(Panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(19, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.16188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.83812F));
            tableLayoutPanel1.Size = new Size(1599, 848);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(dgvBestSellingItems);
            Panel3.Controls.Add(lblBestSellingItems);
            Panel3.Location = new Point(3, 316);
            Panel3.Margin = new Padding(3, 10, 3, 3);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1593, 529);
            Panel3.TabIndex = 5;
            // 
            // dgvBestSellingItems
            // 
            dgvBestSellingItems.AllowUserToAddRows = false;
            dgvBestSellingItems.AllowUserToDeleteRows = false;
            dgvBestSellingItems.AllowUserToResizeColumns = false;
            dgvBestSellingItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = Color.White;
            dgvBestSellingItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dgvBestSellingItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle18.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvBestSellingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgvBestSellingItems.ColumnHeadersHeight = 50;
            dgvBestSellingItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle19.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle19.SelectionBackColor = Color.White;
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            dgvBestSellingItems.DefaultCellStyle = dataGridViewCellStyle19;
            dgvBestSellingItems.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingItems.Location = new Point(0, 67);
            dgvBestSellingItems.Name = "dgvBestSellingItems";
            dgvBestSellingItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle20.SelectionBackColor = Color.White;
            dataGridViewCellStyle20.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dgvBestSellingItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dgvBestSellingItems.RowHeadersVisible = false;
            dgvBestSellingItems.RowHeadersWidth = 50;
            dgvBestSellingItems.RowTemplate.Height = 29;
            dgvBestSellingItems.Size = new Size(1593, 462);
            dgvBestSellingItems.TabIndex = 21;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBestSellingItems.ThemeStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBestSellingItems.ThemeStyle.HeaderStyle.Height = 50;
            dgvBestSellingItems.ThemeStyle.ReadOnly = false;
            dgvBestSellingItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBestSellingItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBestSellingItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBestSellingItems.ThemeStyle.RowsStyle.Height = 29;
            dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Part Number";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Brand";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Quantity Sold";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Quantity In Hand";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Revenue";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Profit";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // lblBestSellingItems
            // 
            lblBestSellingItems.BackColor = Color.Transparent;
            lblBestSellingItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestSellingItems.Location = new Point(14, 18);
            lblBestSellingItems.Name = "lblBestSellingItems";
            lblBestSellingItems.Size = new Size(166, 30);
            lblBestSellingItems.TabIndex = 18;
            lblBestSellingItems.Text = "Best Selling Items";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(Panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1593, 300);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(dgvBestSellingCategories);
            Panel2.Controls.Add(lblBestSellingCategories);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(806, 3);
            Panel2.Margin = new Padding(10, 3, 3, 10);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(784, 287);
            Panel2.TabIndex = 4;
            // 
            // dgvBestSellingCategories
            // 
            dgvBestSellingCategories.AllowUserToAddRows = false;
            dgvBestSellingCategories.AllowUserToDeleteRows = false;
            dgvBestSellingCategories.AllowUserToResizeColumns = false;
            dgvBestSellingCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = Color.White;
            dgvBestSellingCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.White;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle22.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle22.SelectionBackColor = Color.White;
            dataGridViewCellStyle22.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvBestSellingCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvBestSellingCategories.ColumnHeadersHeight = 50;
            dgvBestSellingCategories.Columns.AddRange(new DataGridViewColumn[] { category, cat_quantity_sold, cat_revenue, cat_profit });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.White;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle23.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle23.SelectionBackColor = Color.White;
            dataGridViewCellStyle23.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dgvBestSellingCategories.DefaultCellStyle = dataGridViewCellStyle23;
            dgvBestSellingCategories.Dock = DockStyle.Bottom;
            dgvBestSellingCategories.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingCategories.Location = new Point(0, 71);
            dgvBestSellingCategories.Name = "dgvBestSellingCategories";
            dgvBestSellingCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.White;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle24.SelectionBackColor = Color.White;
            dataGridViewCellStyle24.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgvBestSellingCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dgvBestSellingCategories.RowHeadersVisible = false;
            dgvBestSellingCategories.RowHeadersWidth = 50;
            dgvBestSellingCategories.RowTemplate.Height = 29;
            dgvBestSellingCategories.Size = new Size(784, 216);
            dgvBestSellingCategories.TabIndex = 19;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBestSellingCategories.ThemeStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBestSellingCategories.ThemeStyle.HeaderStyle.Height = 50;
            dgvBestSellingCategories.ThemeStyle.ReadOnly = false;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.Height = 29;
            dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // cat_quantity_sold
            // 
            cat_quantity_sold.HeaderText = "Quantity Sold";
            cat_quantity_sold.MinimumWidth = 6;
            cat_quantity_sold.Name = "cat_quantity_sold";
            // 
            // cat_revenue
            // 
            cat_revenue.HeaderText = "Revenue";
            cat_revenue.MinimumWidth = 6;
            cat_revenue.Name = "cat_revenue";
            // 
            // cat_profit
            // 
            cat_profit.HeaderText = "Profit";
            cat_profit.MinimumWidth = 6;
            cat_profit.Name = "cat_profit";
            // 
            // lblBestSellingCategories
            // 
            lblBestSellingCategories.BackColor = Color.Transparent;
            lblBestSellingCategories.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBestSellingCategories.Location = new Point(13, 13);
            lblBestSellingCategories.Name = "lblBestSellingCategories";
            lblBestSellingCategories.Size = new Size(211, 30);
            lblBestSellingCategories.TabIndex = 18;
            lblBestSellingCategories.Text = "Best Selling Categories";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(btnDownload);
            Panel1.Controls.Add(cbFilters);
            Panel1.Controls.Add(dgvOverview);
            Panel1.Controls.Add(lblOverview);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(3, 3);
            Panel1.Margin = new Padding(3, 3, 10, 10);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(783, 287);
            Panel1.TabIndex = 3;
            // 
            // cbFilters
            // 
            cbFilters.BackColor = Color.Transparent;
            cbFilters.BorderColor = Color.FromArgb(208, 213, 221);
            cbFilters.BorderRadius = 8;
            cbFilters.Cursor = Cursors.Hand;
            cbFilters.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilters.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilters.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbFilters.ForeColor = Color.FromArgb(72, 80, 94);
            cbFilters.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbFilters.ItemHeight = 30;
            cbFilters.Location = new Point(500, 14);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(270, 36);
            cbFilters.TabIndex = 56;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // dgvOverview
            // 
            dgvOverview.AllowUserToAddRows = false;
            dgvOverview.AllowUserToDeleteRows = false;
            dgvOverview.AllowUserToResizeColumns = false;
            dgvOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle14.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvOverview.ColumnHeadersHeight = 50;
            dgvOverview.Columns.AddRange(new DataGridViewColumn[] { total_profit, revenue, sales });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle15.SelectionBackColor = Color.White;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvOverview.DefaultCellStyle = dataGridViewCellStyle15;
            dgvOverview.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverview.ImeMode = ImeMode.NoControl;
            dgvOverview.Location = new Point(0, 71);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvOverview.RowHeadersVisible = false;
            dgvOverview.RowHeadersWidth = 50;
            dgvOverview.RowTemplate.Height = 29;
            dgvOverview.Size = new Size(783, 146);
            dgvOverview.TabIndex = 21;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOverview.ThemeStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOverview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOverview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOverview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOverview.ThemeStyle.HeaderStyle.Height = 50;
            dgvOverview.ThemeStyle.ReadOnly = false;
            dgvOverview.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOverview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOverview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvOverview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOverview.ThemeStyle.RowsStyle.Height = 29;
            dgvOverview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOverview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvOverview.CellPainting += dgvOverview_CellPainting;
            // 
            // total_profit
            // 
            total_profit.HeaderText = "Total Profit";
            total_profit.MinimumWidth = 6;
            total_profit.Name = "total_profit";
            // 
            // revenue
            // 
            revenue.HeaderText = "Revenue";
            revenue.MinimumWidth = 6;
            revenue.Name = "revenue";
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
            lblOverview.Location = new Point(14, 13);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(87, 30);
            lblOverview.TabIndex = 20;
            lblOverview.Text = "Overview\r\n";
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDownload.BorderColor = Color.FromArgb(208, 211, 217);
            btnDownload.BorderRadius = 4;
            btnDownload.BorderThickness = 2;
            btnDownload.DisabledState.BorderColor = Color.DarkGray;
            btnDownload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDownload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDownload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDownload.FillColor = Color.White;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.FromArgb(93, 102, 121);
            btnDownload.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnDownload.HoverState.FillColor = Color.Transparent;
            btnDownload.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnDownload.HoverState.Image = Properties.Resources.downloadBlue;
            btnDownload.Image = Properties.Resources.download;
            btnDownload.ImageSize = new Size(14, 17);
            btnDownload.Location = new Point(316, 232);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(147, 40);
            btnDownload.TabIndex = 57;
            btnDownload.Text = "Download";
            btnDownload.TextOffset = new Point(2, 0);
            btnDownload.Click += btnDownload_Click;
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Reports";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1640, 888);
            Load += UC_Reports_Load;
            tableLayoutPanel1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingItems).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingCategories).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOverview;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingCategories;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblBestSellingCategories;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblBestSellingItems;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvOverview;
        private DataGridViewTextBoxColumn total_profit;
        private DataGridViewTextBoxColumn revenue;
        private DataGridViewTextBoxColumn sales;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbFilters;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn cat_quantity_sold;
        private DataGridViewTextBoxColumn cat_revenue;
        private DataGridViewTextBoxColumn cat_profit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDownload;
    }
}
