namespace InventoryManagementSystem
{
    partial class UC_Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblOutOfStock = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblLowQuantityStock = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvInventorySummary = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            quantity_sold = new DataGridViewTextBoxColumn();
            quantity_in_hand = new DataGridViewTextBoxColumn();
            low_in_stock = new DataGridViewTextBoxColumn();
            out_of_stock = new DataGridViewTextBoxColumn();
            lblInventorySummary = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblSalesOverview = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticonePictureBox4 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticonePictureBox3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            lblTopSellingStock = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            lblQuantityInHandData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblOutOfStockData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblLowQuantityStockData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblQuantitySoldData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventorySummary).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.142334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.857666F));
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(19, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.5006523F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.4993477F));
            tableLayoutPanel1.Size = new Size(1096, 767);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblOutOfStock);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(713, 382);
            panel5.Margin = new Padding(10, 10, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 382);
            panel5.TabIndex = 1;
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.BackColor = Color.Transparent;
            lblOutOfStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutOfStock.Location = new Point(17, 11);
            lblOutOfStock.Margin = new Padding(8, 8, 3, 3);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(110, 27);
            lblOutOfStock.TabIndex = 25;
            lblOutOfStock.Text = "Out Of Stock";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblLowQuantityStock);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(713, 3);
            panel4.Margin = new Padding(10, 3, 3, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 359);
            panel4.TabIndex = 0;
            // 
            // lblLowQuantityStock
            // 
            lblLowQuantityStock.BackColor = Color.Transparent;
            lblLowQuantityStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblLowQuantityStock.Location = new Point(17, 11);
            lblLowQuantityStock.Margin = new Padding(8, 8, 3, 3);
            lblLowQuantityStock.Name = "lblLowQuantityStock";
            lblLowQuantityStock.Size = new Size(165, 27);
            lblLowQuantityStock.TabIndex = 24;
            lblLowQuantityStock.Text = "Low Quantity Stock";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.63801F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3619919F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(697, 366);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvInventorySummary);
            panel1.Controls.Add(lblInventorySummary);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 170);
            panel1.TabIndex = 0;
            // 
            // dgvInventorySummary
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvInventorySummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventorySummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInventorySummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInventorySummary.ColumnHeadersHeight = 22;
            dgvInventorySummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventorySummary.ColumnHeadersVisible = false;
            dgvInventorySummary.Columns.AddRange(new DataGridViewColumn[] { quantity_sold, quantity_in_hand, low_in_stock, out_of_stock });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInventorySummary.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInventorySummary.GridColor = Color.FromArgb(240, 241, 243);
            dgvInventorySummary.Location = new Point(0, 41);
            dgvInventorySummary.Name = "dgvInventorySummary";
            dgvInventorySummary.RowHeadersVisible = false;
            dgvInventorySummary.RowHeadersWidth = 51;
            dgvInventorySummary.RowTemplate.Height = 29;
            dgvInventorySummary.Size = new Size(681, 129);
            dgvInventorySummary.TabIndex = 22;
            dgvInventorySummary.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventorySummary.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInventorySummary.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInventorySummary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInventorySummary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInventorySummary.ThemeStyle.BackColor = Color.White;
            dgvInventorySummary.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvInventorySummary.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventorySummary.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventorySummary.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInventorySummary.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventorySummary.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventorySummary.ThemeStyle.HeaderStyle.Height = 22;
            dgvInventorySummary.ThemeStyle.ReadOnly = false;
            dgvInventorySummary.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventorySummary.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventorySummary.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInventorySummary.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventorySummary.ThemeStyle.RowsStyle.Height = 29;
            dgvInventorySummary.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventorySummary.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // quantity_sold
            // 
            quantity_sold.HeaderText = "Quantity Sold";
            quantity_sold.MinimumWidth = 6;
            quantity_sold.Name = "quantity_sold";
            // 
            // quantity_in_hand
            // 
            quantity_in_hand.HeaderText = "Quantity In Hand";
            quantity_in_hand.MinimumWidth = 6;
            quantity_in_hand.Name = "quantity_in_hand";
            // 
            // low_in_stock
            // 
            low_in_stock.HeaderText = "Low In Stock";
            low_in_stock.MinimumWidth = 6;
            low_in_stock.Name = "low_in_stock";
            // 
            // out_of_stock
            // 
            out_of_stock.HeaderText = "Out Of Stock";
            out_of_stock.MinimumWidth = 6;
            out_of_stock.Name = "out_of_stock";
            // 
            // lblInventorySummary
            // 
            lblInventorySummary.BackColor = Color.Transparent;
            lblInventorySummary.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventorySummary.Location = new Point(12, 8);
            lblInventorySummary.Margin = new Padding(8, 8, 3, 3);
            lblInventorySummary.Name = "lblInventorySummary";
            lblInventorySummary.Size = new Size(166, 27);
            lblInventorySummary.TabIndex = 21;
            lblInventorySummary.Text = "Inventory Summary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblSalesOverview);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 193);
            panel2.Margin = new Padding(3, 10, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 163);
            panel2.TabIndex = 1;
            // 
            // lblSalesOverview
            // 
            lblSalesOverview.BackColor = Color.Transparent;
            lblSalesOverview.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalesOverview.Location = new Point(12, 8);
            lblSalesOverview.Margin = new Padding(8, 8, 3, 3);
            lblSalesOverview.Name = "lblSalesOverview";
            lblSalesOverview.Size = new Size(128, 27);
            lblSalesOverview.TabIndex = 22;
            lblSalesOverview.Text = "Sales Overview";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(siticonePictureBox4);
            panel3.Controls.Add(siticonePictureBox3);
            panel3.Controls.Add(siticonePictureBox1);
            panel3.Controls.Add(lblTopSellingStock);
            panel3.Controls.Add(siticonePictureBox2);
            panel3.Controls.Add(lblQuantityInHandData);
            panel3.Controls.Add(lblOutOfStockData);
            panel3.Controls.Add(lblLowQuantityStockData);
            panel3.Controls.Add(lblQuantitySoldData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 382);
            panel3.Margin = new Padding(3, 10, 10, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 382);
            panel3.TabIndex = 3;
            // 
            // siticonePictureBox4
            // 
            siticonePictureBox4.Image = Properties.Resources.OutOfStock;
            siticonePictureBox4.ImageRotate = 0F;
            siticonePictureBox4.Location = new Point(552, 121);
            siticonePictureBox4.Name = "siticonePictureBox4";
            siticonePictureBox4.Size = new Size(154, 37);
            siticonePictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox4.TabIndex = 3;
            siticonePictureBox4.TabStop = false;
            // 
            // siticonePictureBox3
            // 
            siticonePictureBox3.Image = Properties.Resources.LowInStock;
            siticonePictureBox3.ImageRotate = 0F;
            siticonePictureBox3.Location = new Point(378, 121);
            siticonePictureBox3.Name = "siticonePictureBox3";
            siticonePictureBox3.Size = new Size(168, 37);
            siticonePictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox3.TabIndex = 2;
            siticonePictureBox3.TabStop = false;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.Image = Properties.Resources.QuantitySold;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(40, 100);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(168, 37);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.TabStop = false;
            // 
            // lblTopSellingStock
            // 
            lblTopSellingStock.BackColor = Color.Transparent;
            lblTopSellingStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopSellingStock.Location = new Point(15, 11);
            lblTopSellingStock.Margin = new Padding(8, 8, 3, 3);
            lblTopSellingStock.Name = "lblTopSellingStock";
            lblTopSellingStock.Size = new Size(147, 27);
            lblTopSellingStock.TabIndex = 23;
            lblTopSellingStock.Text = "Top Selling Stock";
            // 
            // siticonePictureBox2
            // 
            siticonePictureBox2.Image = Properties.Resources.QuantityInHand;
            siticonePictureBox2.ImageRotate = 0F;
            siticonePictureBox2.Location = new Point(214, 112);
            siticonePictureBox2.Name = "siticonePictureBox2";
            siticonePictureBox2.Size = new Size(170, 37);
            siticonePictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox2.TabIndex = 1;
            siticonePictureBox2.TabStop = false;
            // 
            // lblQuantityInHandData
            // 
            lblQuantityInHandData.BackColor = Color.Transparent;
            lblQuantityInHandData.Location = new Point(202, 188);
            lblQuantityInHandData.Name = "lblQuantityInHandData";
            lblQuantityInHandData.Size = new Size(33, 22);
            lblQuantityInHandData.TabIndex = 5;
            lblQuantityInHandData.Text = "data";
            lblQuantityInHandData.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblOutOfStockData
            // 
            lblOutOfStockData.BackColor = Color.Transparent;
            lblOutOfStockData.Location = new Point(552, 188);
            lblOutOfStockData.Name = "lblOutOfStockData";
            lblOutOfStockData.Size = new Size(33, 22);
            lblOutOfStockData.TabIndex = 7;
            lblOutOfStockData.Text = "data";
            lblOutOfStockData.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblLowQuantityStockData
            // 
            lblLowQuantityStockData.BackColor = Color.Transparent;
            lblLowQuantityStockData.Location = new Point(378, 188);
            lblLowQuantityStockData.Name = "lblLowQuantityStockData";
            lblLowQuantityStockData.Size = new Size(33, 22);
            lblLowQuantityStockData.TabIndex = 6;
            lblLowQuantityStockData.Text = "data";
            lblLowQuantityStockData.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblQuantitySoldData
            // 
            lblQuantitySoldData.BackColor = Color.Transparent;
            lblQuantitySoldData.Location = new Point(71, 199);
            lblQuantitySoldData.Name = "lblQuantitySoldData";
            lblQuantitySoldData.Size = new Size(33, 22);
            lblQuantitySoldData.TabIndex = 4;
            lblQuantitySoldData.Text = "data";
            lblQuantitySoldData.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Dashboard";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1137, 807);
            Load += UC_Dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventorySummary).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panel5;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOutOfStock;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblLowQuantityStock;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInventorySummary;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblSalesOverview;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTopSellingStock;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblQuantitySoldData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblQuantityInHandData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblLowQuantityStockData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblOutOfStockData;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvInventorySummary;
        private DataGridViewTextBoxColumn quantity_sold;
        private DataGridViewTextBoxColumn quantity_in_hand;
        private DataGridViewTextBoxColumn low_in_stock;
        private DataGridViewTextBoxColumn out_of_stock;
    }
}
