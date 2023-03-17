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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            middlePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
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
            Panel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            lblBestSellingCategories = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvOverview = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            total_profit = new DataGridViewTextBoxColumn();
            revenue = new DataGridViewTextBoxColumn();
            sales = new DataGridViewTextBoxColumn();
            lblOverview = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
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
            middlePanel.Location = new Point(19, 19);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(1028, 766);
            middlePanel.TabIndex = 2;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(dgvBestSellingItems);
            Panel3.Controls.Add(lblBestSellingItems);
            Panel3.Location = new Point(0, 295);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1028, 471);
            Panel3.TabIndex = 4;
            Panel3.SizeChanged += Panel3_SizeChanged;
            // 
            // dgvBestSellingItems
            // 
            dgvBestSellingItems.AllowUserToAddRows = false;
            dgvBestSellingItems.AllowUserToDeleteRows = false;
            dgvBestSellingItems.AllowUserToResizeColumns = false;
            dgvBestSellingItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBestSellingItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBestSellingItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBestSellingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBestSellingItems.ColumnHeadersHeight = 50;
            dgvBestSellingItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBestSellingItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBestSellingItems.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingItems.Location = new Point(0, 66);
            dgvBestSellingItems.Name = "dgvBestSellingItems";
            dgvBestSellingItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBestSellingItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBestSellingItems.RowHeadersVisible = false;
            dgvBestSellingItems.RowHeadersWidth = 50;
            dgvBestSellingItems.RowTemplate.Height = 29;
            dgvBestSellingItems.Size = new Size(1028, 405);
            dgvBestSellingItems.TabIndex = 20;
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
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(dgvBestSellingCategories);
            Panel2.Controls.Add(lblBestSellingCategories);
            Panel2.Location = new Point(608, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(420, 272);
            Panel2.TabIndex = 3;
            Panel2.SizeChanged += Panel2_SizeChanged;
            // 
            // dgvBestSellingCategories
            // 
            dgvBestSellingCategories.AllowUserToAddRows = false;
            dgvBestSellingCategories.AllowUserToDeleteRows = false;
            dgvBestSellingCategories.AllowUserToResizeColumns = false;
            dgvBestSellingCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvBestSellingCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBestSellingCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBestSellingCategories.ColumnHeadersHeight = 50;
            dgvBestSellingCategories.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle7.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvBestSellingCategories.DefaultCellStyle = dataGridViewCellStyle7;
            dgvBestSellingCategories.Dock = DockStyle.Bottom;
            dgvBestSellingCategories.GridColor = Color.FromArgb(240, 241, 243);
            dgvBestSellingCategories.Location = new Point(0, 56);
            dgvBestSellingCategories.Name = "dgvBestSellingCategories";
            dgvBestSellingCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvBestSellingCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvBestSellingCategories.RowHeadersVisible = false;
            dgvBestSellingCategories.RowHeadersWidth = 50;
            dgvBestSellingCategories.RowTemplate.Height = 29;
            dgvBestSellingCategories.Size = new Size(420, 216);
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
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Category";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Quantity Sold";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Revenue";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Profit";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
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
            Panel1.Controls.Add(dgvOverview);
            Panel1.Controls.Add(lblOverview);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(579, 272);
            Panel1.TabIndex = 2;
            Panel1.StyleChanged += Panel1_StyleChanged;
            // 
            // dgvOverview
            // 
            dgvOverview.AllowUserToAddRows = false;
            dgvOverview.AllowUserToDeleteRows = false;
            dgvOverview.AllowUserToResizeColumns = false;
            dgvOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle10.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvOverview.ColumnHeadersHeight = 50;
            dgvOverview.Columns.AddRange(new DataGridViewColumn[] { total_profit, revenue, sales });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvOverview.DefaultCellStyle = dataGridViewCellStyle11;
            dgvOverview.Dock = DockStyle.Bottom;
            dgvOverview.GridColor = Color.FromArgb(240, 241, 243);
            dgvOverview.ImeMode = ImeMode.NoControl;
            dgvOverview.Location = new Point(0, 56);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvOverview.RowHeadersVisible = false;
            dgvOverview.RowHeadersWidth = 50;
            dgvOverview.RowTemplate.Height = 29;
            dgvOverview.Size = new Size(579, 216);
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
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(middlePanel);
            Name = "UC_Reports";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1069, 806);
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
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvBestSellingCategories;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvOverview;
        private DataGridViewTextBoxColumn total_profit;
        private DataGridViewTextBoxColumn revenue;
        private DataGridViewTextBoxColumn sales;
    }
}
