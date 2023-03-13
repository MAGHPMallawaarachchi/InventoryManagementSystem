namespace InventoryManagementSystem.UserControls
{
    partial class UC_Invoices
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
            middlePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            btnPrintPreview = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Panel3 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            lblTimeData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblDateData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblInvoiceNoData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblTime = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblDate = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblInvoiceNo2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblInvoiceNo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblInvoice = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnClear = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnSaveInvoice = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            Panel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblTotalData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblTotal = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnAddRow = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            dgvItems = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            no = new DataGridViewTextBoxColumn();
            part_no = new DataGridViewComboBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            lblItems = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            Panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            cbCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            lblPhoneNoData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblCityData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblAddressData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblMessrsData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblPhoneNo = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblCity = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblAddress = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblMessrs = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblCustomer = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            middlePanel.SuspendLayout();
            Panel3.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // middlePanel
            // 
            middlePanel.Controls.Add(btnPrintPreview);
            middlePanel.Controls.Add(Panel3);
            middlePanel.Controls.Add(btnClear);
            middlePanel.Controls.Add(btnSaveInvoice);
            middlePanel.Controls.Add(Panel2);
            middlePanel.Controls.Add(Panel1);
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(19, 19);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(1143, 773);
            middlePanel.TabIndex = 0;
            // 
            // btnPrintPreview
            // 
            btnPrintPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrintPreview.BorderColor = Color.FromArgb(10, 73, 156);
            btnPrintPreview.BorderRadius = 4;
            btnPrintPreview.BorderThickness = 2;
            btnPrintPreview.Cursor = Cursors.Hand;
            btnPrintPreview.DisabledState.BorderColor = Color.DarkGray;
            btnPrintPreview.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrintPreview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrintPreview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrintPreview.FillColor = Color.FromArgb(10, 73, 156);
            btnPrintPreview.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintPreview.ForeColor = Color.White;
            btnPrintPreview.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnPrintPreview.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnPrintPreview.ImageOffset = new Point(0, 1);
            btnPrintPreview.ImageSize = new Size(15, 10);
            btnPrintPreview.Location = new Point(22, 715);
            btnPrintPreview.Name = "btnPrintPreview";
            btnPrintPreview.Size = new Size(121, 40);
            btnPrintPreview.TabIndex = 55;
            btnPrintPreview.Text = "Print Preview";
            btnPrintPreview.TextOffset = new Point(2, 0);
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel3.Controls.Add(lblTimeData);
            Panel3.Controls.Add(lblDateData);
            Panel3.Controls.Add(lblInvoiceNoData);
            Panel3.Controls.Add(lblTime);
            Panel3.Controls.Add(lblDate);
            Panel3.Controls.Add(lblInvoiceNo2);
            Panel3.Controls.Add(lblInvoiceNo);
            Panel3.Controls.Add(lblInvoice);
            Panel3.Location = new Point(800, 0);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(327, 232);
            Panel3.TabIndex = 54;
            Panel3.SizeChanged += Panel3_SizeChanged;
            // 
            // lblTimeData
            // 
            lblTimeData.BackColor = Color.Transparent;
            lblTimeData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeData.ForeColor = Color.FromArgb(72, 80, 94);
            lblTimeData.Location = new Point(193, 189);
            lblTimeData.Name = "lblTimeData";
            lblTimeData.Size = new Size(39, 25);
            lblTimeData.TabIndex = 62;
            lblTimeData.Text = "Data";
            // 
            // lblDateData
            // 
            lblDateData.BackColor = Color.Transparent;
            lblDateData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateData.ForeColor = Color.FromArgb(72, 80, 94);
            lblDateData.Location = new Point(193, 148);
            lblDateData.Name = "lblDateData";
            lblDateData.Size = new Size(39, 25);
            lblDateData.TabIndex = 61;
            lblDateData.Text = "Data";
            // 
            // lblInvoiceNoData
            // 
            lblInvoiceNoData.BackColor = Color.Transparent;
            lblInvoiceNoData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoiceNoData.ForeColor = Color.FromArgb(72, 80, 94);
            lblInvoiceNoData.Location = new Point(193, 109);
            lblInvoiceNoData.Name = "lblInvoiceNoData";
            lblInvoiceNoData.Size = new Size(39, 25);
            lblInvoiceNoData.TabIndex = 60;
            lblInvoiceNoData.Text = "Data";
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(93, 102, 121);
            lblTime.Location = new Point(19, 189);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(40, 25);
            lblTime.TabIndex = 59;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(93, 102, 121);
            lblDate.Location = new Point(19, 148);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(39, 25);
            lblDate.TabIndex = 58;
            lblDate.Text = "Date";
            // 
            // lblInvoiceNo2
            // 
            lblInvoiceNo2.BackColor = Color.Transparent;
            lblInvoiceNo2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoiceNo2.ForeColor = Color.FromArgb(93, 102, 121);
            lblInvoiceNo2.Location = new Point(19, 109);
            lblInvoiceNo2.Name = "lblInvoiceNo2";
            lblInvoiceNo2.Size = new Size(85, 25);
            lblInvoiceNo2.TabIndex = 57;
            lblInvoiceNo2.Text = "Invoice No";
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.BackColor = Color.Transparent;
            lblInvoiceNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoiceNo.Location = new Point(19, 51);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(97, 30);
            lblInvoiceNo.TabIndex = 56;
            lblInvoiceNo.Text = "Invoice No";
            // 
            // lblInvoice
            // 
            lblInvoice.BackColor = Color.Transparent;
            lblInvoice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvoice.Location = new Point(19, 17);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(121, 43);
            lblInvoice.TabIndex = 56;
            lblInvoice.Text = "INVOICE";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnClear.Location = new Point(869, 715);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 40);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.TextOffset = new Point(2, 0);
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveInvoice.BorderColor = Color.FromArgb(10, 73, 156);
            btnSaveInvoice.BorderRadius = 4;
            btnSaveInvoice.BorderThickness = 2;
            btnSaveInvoice.Cursor = Cursors.Hand;
            btnSaveInvoice.DisabledState.BorderColor = Color.DarkGray;
            btnSaveInvoice.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveInvoice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveInvoice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveInvoice.FillColor = Color.FromArgb(10, 73, 156);
            btnSaveInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnSaveInvoice.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnSaveInvoice.ImageOffset = new Point(0, 1);
            btnSaveInvoice.ImageSize = new Size(15, 10);
            btnSaveInvoice.Location = new Point(987, 715);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(121, 40);
            btnSaveInvoice.TabIndex = 2;
            btnSaveInvoice.Text = "Save Invoice";
            btnSaveInvoice.TextOffset = new Point(2, 0);
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = Color.White;
            Panel2.BorderColor = Color.White;
            Panel2.BorderRadius = 20;
            Panel2.BorderThickness = 2;
            Panel2.Controls.Add(lblTotalData);
            Panel2.Controls.Add(lblTotal);
            Panel2.Controls.Add(btnAddRow);
            Panel2.Controls.Add(dgvItems);
            Panel2.Controls.Add(lblItems);
            Panel2.Location = new Point(0, 256);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1127, 443);
            Panel2.TabIndex = 1;
            Panel2.SizeChanged += Panel2_SizeChanged;
            // 
            // lblTotalData
            // 
            lblTotalData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalData.BackColor = Color.Transparent;
            lblTotalData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalData.Location = new Point(1004, 400);
            lblTotalData.Name = "lblTotalData";
            lblTotalData.Size = new Size(39, 25);
            lblTotalData.TabIndex = 8;
            lblTotalData.Text = "Data";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(919, 400);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // btnAddRow
            // 
            btnAddRow.Cursor = Cursors.Hand;
            btnAddRow.DisabledState.BorderColor = Color.DarkGray;
            btnAddRow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRow.FillColor = Color.Transparent;
            btnAddRow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRow.ForeColor = Color.White;
            btnAddRow.HoverState.BorderColor = Color.Transparent;
            btnAddRow.HoverState.FillColor = Color.Transparent;
            btnAddRow.HoverState.Image = Properties.Resources.addBlue;
            btnAddRow.Image = Properties.Resources.add;
            btnAddRow.ImageOffset = new Point(1, 0);
            btnAddRow.Location = new Point(75, 22);
            btnAddRow.Margin = new Padding(3, 4, 3, 4);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.PressedColor = Color.Transparent;
            btnAddRow.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            btnAddRow.Size = new Size(34, 30);
            btnAddRow.TabIndex = 6;
            btnAddRow.Click += btnAddRow_Click;
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
            dgvItems.ColumnHeadersHeight = 50;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { no, part_no, brand, description, qty, unit_price, amount });
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
            dgvItems.Location = new Point(6, 55);
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
            dgvItems.Size = new Size(1102, 339);
            dgvItems.TabIndex = 5;
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
            dgvItems.CellValueChanged += dgvItems_CellValueChanged;
            // 
            // no
            // 
            no.HeaderText = "NO";
            no.MinimumWidth = 6;
            no.Name = "no";
            // 
            // part_no
            // 
            part_no.HeaderText = "Part No";
            part_no.MinimumWidth = 6;
            part_no.Name = "part_no";
            part_no.Resizable = DataGridViewTriState.True;
            part_no.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.MinimumWidth = 6;
            brand.Name = "brand";
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            // 
            // qty
            // 
            qty.HeaderText = "Qty";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "U/Price";
            unit_price.MinimumWidth = 6;
            unit_price.Name = "unit_price";
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            // 
            // lblItems
            // 
            lblItems.BackColor = Color.Transparent;
            lblItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItems.Location = new Point(22, 19);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(54, 30);
            lblItems.TabIndex = 4;
            lblItems.Text = "Items";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.BorderColor = Color.White;
            Panel1.BorderRadius = 20;
            Panel1.BorderThickness = 2;
            Panel1.Controls.Add(cbCustomerID);
            Panel1.Controls.Add(lblPhoneNoData);
            Panel1.Controls.Add(lblCityData);
            Panel1.Controls.Add(lblAddressData);
            Panel1.Controls.Add(lblMessrsData);
            Panel1.Controls.Add(lblPhoneNo);
            Panel1.Controls.Add(lblCity);
            Panel1.Controls.Add(lblAddress);
            Panel1.Controls.Add(lblMessrs);
            Panel1.Controls.Add(lblCustomer);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(777, 232);
            Panel1.TabIndex = 0;
            Panel1.SizeChanged += Panel1_SizeChanged;
            // 
            // cbCustomerID
            // 
            cbCustomerID.BackColor = Color.Transparent;
            cbCustomerID.BorderColor = Color.FromArgb(208, 213, 221);
            cbCustomerID.BorderRadius = 8;
            cbCustomerID.Cursor = Cursors.Hand;
            cbCustomerID.DrawMode = DrawMode.OwnerDrawFixed;
            cbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerID.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCustomerID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCustomerID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCustomerID.ForeColor = Color.FromArgb(72, 80, 94);
            cbCustomerID.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbCustomerID.ItemHeight = 30;
            cbCustomerID.Location = new Point(493, 11);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(270, 36);
            cbCustomerID.TabIndex = 55;
            cbCustomerID.SelectedIndexChanged += cbCustomerID_SelectedIndexChanged;
            // 
            // lblPhoneNoData
            // 
            lblPhoneNoData.BackColor = Color.Transparent;
            lblPhoneNoData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNoData.ForeColor = Color.FromArgb(72, 80, 94);
            lblPhoneNoData.Location = new Point(223, 189);
            lblPhoneNoData.Name = "lblPhoneNoData";
            lblPhoneNoData.Size = new Size(39, 25);
            lblPhoneNoData.TabIndex = 13;
            lblPhoneNoData.Text = "Data";
            // 
            // lblCityData
            // 
            lblCityData.BackColor = Color.Transparent;
            lblCityData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCityData.ForeColor = Color.FromArgb(72, 80, 94);
            lblCityData.Location = new Point(223, 148);
            lblCityData.Name = "lblCityData";
            lblCityData.Size = new Size(39, 25);
            lblCityData.TabIndex = 12;
            lblCityData.Text = "Data";
            // 
            // lblAddressData
            // 
            lblAddressData.BackColor = Color.Transparent;
            lblAddressData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressData.ForeColor = Color.FromArgb(72, 80, 94);
            lblAddressData.Location = new Point(223, 107);
            lblAddressData.Name = "lblAddressData";
            lblAddressData.Size = new Size(39, 25);
            lblAddressData.TabIndex = 11;
            lblAddressData.Text = "Data";
            // 
            // lblMessrsData
            // 
            lblMessrsData.BackColor = Color.Transparent;
            lblMessrsData.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessrsData.ForeColor = Color.FromArgb(72, 80, 94);
            lblMessrsData.Location = new Point(223, 67);
            lblMessrsData.Name = "lblMessrsData";
            lblMessrsData.Size = new Size(39, 25);
            lblMessrsData.TabIndex = 10;
            lblMessrsData.Text = "Data";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.BackColor = Color.Transparent;
            lblPhoneNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNo.ForeColor = Color.FromArgb(93, 102, 121);
            lblPhoneNo.Location = new Point(22, 189);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(80, 25);
            lblPhoneNo.TabIndex = 9;
            lblPhoneNo.Text = "Phone No";
            // 
            // lblCity
            // 
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.ForeColor = Color.FromArgb(93, 102, 121);
            lblCity.Location = new Point(22, 148);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(32, 25);
            lblCity.TabIndex = 8;
            lblCity.Text = "City";
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.FromArgb(93, 102, 121);
            lblAddress.Location = new Point(22, 107);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(63, 25);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // lblMessrs
            // 
            lblMessrs.BackColor = Color.Transparent;
            lblMessrs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessrs.ForeColor = Color.FromArgb(93, 102, 121);
            lblMessrs.Location = new Point(22, 67);
            lblMessrs.Name = "lblMessrs";
            lblMessrs.Size = new Size(54, 25);
            lblMessrs.TabIndex = 6;
            lblMessrs.Text = "Messrs";
            // 
            // lblCustomer
            // 
            lblCustomer.BackColor = Color.Transparent;
            lblCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomer.Location = new Point(22, 17);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(91, 30);
            lblCustomer.TabIndex = 5;
            lblCustomer.Text = "Customer";
            // 
            // UC_Invoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(middlePanel);
            Name = "UC_Invoices";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1184, 813);
            Load += UC_Invoices_Load;
            middlePanel.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel middlePanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblItems;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSaveInvoice;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClear;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblPhoneNo;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCity;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMessrs;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel Panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblPhoneNoData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCityData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblAddressData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblMessrsData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInvoice;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTimeData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblDateData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInvoiceNoData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTime;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblDate;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInvoiceNo2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInvoiceNo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPrintPreview;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvItems;
        private DataGridViewTextBoxColumn no;
        private DataGridViewComboBoxColumn part_no;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn amount;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnAddRow;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTotalData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTotal;
    }
}
