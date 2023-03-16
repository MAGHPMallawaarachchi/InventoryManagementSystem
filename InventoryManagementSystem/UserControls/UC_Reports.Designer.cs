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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgvBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.part_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_in_hand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBestSellingItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgvBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.Panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dgvOverview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.total_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOverview = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellingItems)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellingCategories)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.siticonePanel2);
            this.siticonePanel3.Controls.Add(this.siticonePanel1);
            this.siticonePanel3.Controls.Add(this.Panel1);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(20, 20);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(1027, 766);
            this.siticonePanel3.TabIndex = 2;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel2.BackColor = System.Drawing.Color.White;
            this.siticonePanel2.Controls.Add(this.dgvBestSellingItems);
            this.siticonePanel2.Controls.Add(this.lblBestSellingItems);
            this.siticonePanel2.Location = new System.Drawing.Point(0, 261);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1027, 505);
            this.siticonePanel2.TabIndex = 4;
            // 
            // dgvBestSellingItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBestSellingItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBestSellingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBestSellingItems.ColumnHeadersHeight = 22;
            this.dgvBestSellingItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBestSellingItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.part_number,
            this.brand,
            this.category,
            this.quantity_in_hand,
            this.revenue,
            this.profit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBestSellingItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBestSellingItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingItems.Location = new System.Drawing.Point(0, 94);
            this.dgvBestSellingItems.Name = "dgvBestSellingItems";
            this.dgvBestSellingItems.RowHeadersVisible = false;
            this.dgvBestSellingItems.RowHeadersWidth = 51;
            this.dgvBestSellingItems.RowTemplate.Height = 29;
            this.dgvBestSellingItems.Size = new System.Drawing.Size(1027, 411);
            this.dgvBestSellingItems.TabIndex = 19;
            this.dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBestSellingItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBestSellingItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBestSellingItems.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvBestSellingItems.ThemeStyle.ReadOnly = false;
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.Height = 29;
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // part_number
            // 
            this.part_number.HeaderText = "Part Number";
            this.part_number.MinimumWidth = 6;
            this.part_number.Name = "part_number";
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            // 
            // quantity_in_hand
            // 
            this.quantity_in_hand.HeaderText = "Quantity in Hand";
            this.quantity_in_hand.MinimumWidth = 6;
            this.quantity_in_hand.Name = "quantity_in_hand";
            // 
            // revenue
            // 
            this.revenue.HeaderText = "Revenue";
            this.revenue.MinimumWidth = 6;
            this.revenue.Name = "revenue";
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.MinimumWidth = 6;
            this.profit.Name = "profit";
            // 
            // lblBestSellingItems
            // 
            this.lblBestSellingItems.BackColor = System.Drawing.Color.Transparent;
            this.lblBestSellingItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestSellingItems.Location = new System.Drawing.Point(21, 29);
            this.lblBestSellingItems.Name = "lblBestSellingItems";
            this.lblBestSellingItems.Size = new System.Drawing.Size(166, 30);
            this.lblBestSellingItems.TabIndex = 18;
            this.lblBestSellingItems.Text = "Best Selling Items";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.dgvBestSellingCategories);
            this.siticonePanel1.Controls.Add(this.lblBestSellingCategories);
            this.siticonePanel1.Location = new System.Drawing.Point(608, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(419, 234);
            this.siticonePanel1.TabIndex = 3;
            // 
            // dgvBestSellingCategories
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBestSellingCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBestSellingCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBestSellingCategories.ColumnHeadersHeight = 22;
            this.dgvBestSellingCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBestSellingCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBestSellingCategories.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBestSellingCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingCategories.Location = new System.Drawing.Point(0, 86);
            this.dgvBestSellingCategories.Name = "dgvBestSellingCategories";
            this.dgvBestSellingCategories.RowHeadersVisible = false;
            this.dgvBestSellingCategories.RowHeadersWidth = 51;
            this.dgvBestSellingCategories.RowTemplate.Height = 29;
            this.dgvBestSellingCategories.Size = new System.Drawing.Size(419, 148);
            this.dgvBestSellingCategories.TabIndex = 19;
            this.dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBestSellingCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBestSellingCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBestSellingCategories.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvBestSellingCategories.ThemeStyle.ReadOnly = false;
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.Height = 29;
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBestSellingCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Revenue";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Profit";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblBestSellingCategories
            // 
            this.lblBestSellingCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblBestSellingCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestSellingCategories.Location = new System.Drawing.Point(25, 20);
            this.lblBestSellingCategories.Name = "lblBestSellingCategories";
            this.lblBestSellingCategories.Size = new System.Drawing.Size(211, 30);
            this.lblBestSellingCategories.TabIndex = 18;
            this.lblBestSellingCategories.Text = "Best Selling Categories";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.dgvOverview);
            this.Panel1.Controls.Add(this.lblOverview);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(579, 234);
            this.Panel1.TabIndex = 2;
            // 
            // dgvOverview
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOverview.ColumnHeadersHeight = 22;
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total_profit,
            this.dataGridViewTextBoxColumn4,
            this.sales});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOverview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOverview.Location = new System.Drawing.Point(0, 86);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.RowHeadersWidth = 51;
            this.dgvOverview.RowTemplate.Height = 29;
            this.dgvOverview.Size = new System.Drawing.Size(576, 145);
            this.dgvOverview.TabIndex = 21;
            this.dgvOverview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOverview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOverview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOverview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOverview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOverview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOverview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOverview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOverview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOverview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOverview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOverview.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvOverview.ThemeStyle.ReadOnly = false;
            this.dgvOverview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOverview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOverview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOverview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOverview.ThemeStyle.RowsStyle.Height = 29;
            this.dgvOverview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOverview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // total_profit
            // 
            this.total_profit.HeaderText = "Total Profit";
            this.total_profit.MinimumWidth = 6;
            this.total_profit.Name = "total_profit";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Revenue";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // sales
            // 
            this.sales.HeaderText = "Sales";
            this.sales.MinimumWidth = 6;
            this.sales.Name = "sales";
            // 
            // lblOverview
            // 
            this.lblOverview.BackColor = System.Drawing.Color.Transparent;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverview.Location = new System.Drawing.Point(21, 20);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(87, 30);
            this.lblOverview.TabIndex = 20;
            this.lblOverview.Text = "Overview\r\n";
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.siticonePanel3);
            this.Name = "UC_Reports";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1067, 806);
            this.Load += new System.EventHandler(this.UC_Reports_Load);
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellingItems)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellingCategories)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
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
        private DataGridViewTextBoxColumn quantity_in_hand;
        private DataGridViewTextBoxColumn revenue;
        private DataGridViewTextBoxColumn profit;
    }
}
