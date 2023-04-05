namespace InventoryManagementSystem
{
    partial class AddItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            btnAddItem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDiscard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtSupplier = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtVehicleBrand = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label8 = new Label();
            label9 = new Label();
            txtCategory = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label5 = new Label();
            txtDescription = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label4 = new Label();
            txtOEMNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtPartNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantity = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            txtUnitPrice = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            txtBuyingPrice = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            txtBrand = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label11 = new Label();
            lblPartNumberError = new Label();
            lblOEMNumberError = new Label();
            lblDescriptionError = new Label();
            lblCategoryError = new Label();
            lblBrandError = new Label();
            lblVehicleBrandError = new Label();
            lblSupplierError = new Label();
            lblBuyingPriceError = new Label();
            lblUnitPriceError = new Label();
            lblQuantityError = new Label();
            lblSuccess = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBuyingPrice).BeginInit();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnAddItem.Image = Properties.Resources.addWhite;
            btnAddItem.ImageOffset = new Point(0, 1);
            btnAddItem.ImageSize = new Size(15, 15);
            btnAddItem.Location = new Point(353, 824);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(120, 40);
            btnAddItem.TabIndex = 41;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextOffset = new Point(2, 0);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiscard.BorderColor = Color.FromArgb(208, 211, 217);
            btnDiscard.BorderRadius = 4;
            btnDiscard.BorderThickness = 2;
            btnDiscard.Cursor = Cursors.Hand;
            btnDiscard.DisabledState.BorderColor = Color.DarkGray;
            btnDiscard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDiscard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDiscard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDiscard.FillColor = Color.White;
            btnDiscard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiscard.ForeColor = Color.FromArgb(93, 102, 121);
            btnDiscard.ImageOffset = new Point(0, 1);
            btnDiscard.ImageSize = new Size(15, 10);
            btnDiscard.Location = new Point(201, 824);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(120, 40);
            btnDiscard.TabIndex = 40;
            btnDiscard.Text = "Discard";
            btnDiscard.TextOffset = new Point(2, 0);
            btnDiscard.Click += btnDiscard_Click;
            // 
            // txtSupplier
            // 
            txtSupplier.BorderColor = Color.FromArgb(208, 213, 221);
            txtSupplier.BorderRadius = 8;
            txtSupplier.DefaultText = "";
            txtSupplier.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSupplier.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSupplier.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSupplier.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSupplier.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtSupplier.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplier.ForeColor = Color.FromArgb(72, 80, 94);
            txtSupplier.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSupplier.Location = new Point(200, 500);
            txtSupplier.Margin = new Padding(3, 5, 3, 5);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.PasswordChar = '\0';
            txtSupplier.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtSupplier.PlaceholderText = "Supplier";
            txtSupplier.SelectedText = "";
            txtSupplier.Size = new Size(275, 40);
            txtSupplier.TabIndex = 39;
            txtSupplier.TextOffset = new Point(10, 0);
            txtSupplier.TextChanged += txtSupplier_TextChanged;
            txtSupplier.KeyDown += txtSupplier_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(72, 80, 94);
            label10.Location = new Point(34, 507);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 38;
            label10.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(72, 80, 94);
            label6.Location = new Point(34, 717);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 36;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(72, 80, 94);
            label7.Location = new Point(34, 647);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 34;
            label7.Text = "Unit Price";
            // 
            // txtVehicleBrand
            // 
            txtVehicleBrand.BorderColor = Color.FromArgb(208, 213, 221);
            txtVehicleBrand.BorderRadius = 8;
            txtVehicleBrand.DefaultText = "";
            txtVehicleBrand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtVehicleBrand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtVehicleBrand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleBrand.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtVehicleBrand.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtVehicleBrand.ForeColor = Color.FromArgb(72, 80, 94);
            txtVehicleBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtVehicleBrand.Location = new Point(201, 430);
            txtVehicleBrand.Margin = new Padding(3, 5, 3, 5);
            txtVehicleBrand.Name = "txtVehicleBrand";
            txtVehicleBrand.PasswordChar = '\0';
            txtVehicleBrand.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtVehicleBrand.PlaceholderText = "Vehicle Brand";
            txtVehicleBrand.SelectedText = "";
            txtVehicleBrand.Size = new Size(275, 40);
            txtVehicleBrand.TabIndex = 32;
            txtVehicleBrand.TextOffset = new Point(10, 0);
            txtVehicleBrand.TextChanged += txtVehicleBrand_TextChanged;
            txtVehicleBrand.KeyDown += txtVehicleBrand_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(72, 80, 94);
            label8.Location = new Point(32, 577);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 31;
            label8.Text = "Buying Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(72, 80, 94);
            label9.Location = new Point(32, 437);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 30;
            label9.Text = "Vehicle Brand";
            // 
            // txtCategory
            // 
            txtCategory.BorderColor = Color.FromArgb(208, 213, 221);
            txtCategory.BorderRadius = 8;
            txtCategory.DefaultText = "";
            txtCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtCategory.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.ForeColor = Color.FromArgb(72, 80, 94);
            txtCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Location = new Point(201, 290);
            txtCategory.Margin = new Padding(3, 5, 3, 5);
            txtCategory.Name = "txtCategory";
            txtCategory.PasswordChar = '\0';
            txtCategory.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtCategory.PlaceholderText = "Category";
            txtCategory.SelectedText = "";
            txtCategory.Size = new Size(275, 40);
            txtCategory.TabIndex = 29;
            txtCategory.TextOffset = new Point(10, 0);
            txtCategory.TextChanged += txtCategory_TextChanged;
            txtCategory.KeyDown += txtCategory_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(72, 80, 94);
            label5.Location = new Point(34, 297);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 28;
            label5.Text = "Category";
            // 
            // txtDescription
            // 
            txtDescription.BorderColor = Color.FromArgb(208, 213, 221);
            txtDescription.BorderRadius = 8;
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtDescription.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.FromArgb(72, 80, 94);
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(201, 220);
            txtDescription.Margin = new Padding(3, 5, 3, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtDescription.PlaceholderText = "Description";
            txtDescription.SelectedText = "";
            txtDescription.Size = new Size(275, 40);
            txtDescription.TabIndex = 27;
            txtDescription.TextOffset = new Point(10, 0);
            txtDescription.TextChanged += txtDescription_TextChanged;
            txtDescription.KeyDown += txtDescription_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(72, 80, 94);
            label4.Location = new Point(34, 227);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 26;
            label4.Text = "Description";
            // 
            // txtOEMNumber
            // 
            txtOEMNumber.BorderColor = Color.FromArgb(208, 213, 221);
            txtOEMNumber.BorderRadius = 8;
            txtOEMNumber.DefaultText = "";
            txtOEMNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOEMNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOEMNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOEMNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOEMNumber.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtOEMNumber.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtOEMNumber.ForeColor = Color.FromArgb(72, 80, 94);
            txtOEMNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOEMNumber.Location = new Point(201, 150);
            txtOEMNumber.Margin = new Padding(3, 5, 3, 5);
            txtOEMNumber.Name = "txtOEMNumber";
            txtOEMNumber.PasswordChar = '\0';
            txtOEMNumber.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtOEMNumber.PlaceholderText = "OEM Number";
            txtOEMNumber.SelectedText = "";
            txtOEMNumber.Size = new Size(275, 40);
            txtOEMNumber.TabIndex = 25;
            txtOEMNumber.TextOffset = new Point(10, 0);
            txtOEMNumber.TextChanged += txtOEMNumber_TextChanged;
            txtOEMNumber.KeyDown += txtOEMNumber_KeyDown;
            // 
            // txtPartNumber
            // 
            txtPartNumber.BorderColor = Color.FromArgb(208, 213, 221);
            txtPartNumber.BorderRadius = 8;
            txtPartNumber.DefaultText = "";
            txtPartNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPartNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPartNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPartNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPartNumber.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtPartNumber.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPartNumber.ForeColor = Color.FromArgb(72, 80, 94);
            txtPartNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPartNumber.Location = new Point(200, 80);
            txtPartNumber.Margin = new Padding(3, 5, 3, 5);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.PasswordChar = '\0';
            txtPartNumber.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtPartNumber.PlaceholderText = "Part Number";
            txtPartNumber.SelectedText = "";
            txtPartNumber.Size = new Size(275, 40);
            txtPartNumber.TabIndex = 24;
            txtPartNumber.TextOffset = new Point(10, 0);
            txtPartNumber.TextChanged += txtPartNumber_TextChanged;
            txtPartNumber.KeyDown += txtPartNumber_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(72, 80, 94);
            label3.Location = new Point(34, 157);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 23;
            label3.Text = "OEM Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(72, 80, 94);
            label2.Location = new Point(34, 87);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 22;
            label2.Text = "Part Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(56, 62, 73);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(112, 31);
            label1.TabIndex = 21;
            label1.Text = "New Item";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.Transparent;
            txtQuantity.BorderColor = Color.FromArgb(208, 213, 221);
            txtQuantity.BorderRadius = 8;
            txtQuantity.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtQuantity.FocusedState.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtQuantity.FocusedState.UpDownButtonForeColor = Color.White;
            txtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.ForeColor = Color.FromArgb(72, 80, 94);
            txtQuantity.Location = new Point(201, 710);
            txtQuantity.Margin = new Padding(3, 5, 3, 5);
            txtQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(275, 40);
            txtQuantity.TabIndex = 42;
            txtQuantity.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtQuantity.UpDownButtonForeColor = Color.White;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.Transparent;
            txtUnitPrice.BorderColor = Color.FromArgb(208, 213, 221);
            txtUnitPrice.BorderRadius = 8;
            txtUnitPrice.DecimalPlaces = 2;
            txtUnitPrice.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtUnitPrice.FocusedState.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtUnitPrice.FocusedState.UpDownButtonForeColor = Color.White;
            txtUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.ForeColor = Color.FromArgb(72, 80, 94);
            txtUnitPrice.Location = new Point(201, 640);
            txtUnitPrice.Margin = new Padding(3, 5, 3, 5);
            txtUnitPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 131072 });
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(275, 40);
            txtUnitPrice.TabIndex = 43;
            txtUnitPrice.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtUnitPrice.UpDownButtonForeColor = Color.White;
            txtUnitPrice.ValueChanged += txtUnitPrice_ValueChanged;
            txtUnitPrice.KeyDown += txtUnitPrice_KeyDown;
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.BackColor = Color.Transparent;
            txtBuyingPrice.BorderColor = Color.FromArgb(208, 213, 221);
            txtBuyingPrice.BorderRadius = 8;
            txtBuyingPrice.DecimalPlaces = 2;
            txtBuyingPrice.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtBuyingPrice.FocusedState.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtBuyingPrice.FocusedState.UpDownButtonForeColor = Color.White;
            txtBuyingPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuyingPrice.ForeColor = Color.FromArgb(72, 80, 94);
            txtBuyingPrice.Location = new Point(201, 570);
            txtBuyingPrice.Margin = new Padding(3, 5, 3, 5);
            txtBuyingPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 131072 });
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.Size = new Size(275, 40);
            txtBuyingPrice.TabIndex = 44;
            txtBuyingPrice.UpDownButtonFillColor = Color.FromArgb(10, 73, 156);
            txtBuyingPrice.UpDownButtonForeColor = Color.White;
            txtBuyingPrice.ValueChanged += txtBuyingPrice_ValueChanged;
            txtBuyingPrice.KeyDown += txtBuyingPrice_KeyDown;
            // 
            // txtBrand
            // 
            txtBrand.BorderColor = Color.FromArgb(208, 213, 221);
            txtBrand.BorderRadius = 8;
            txtBrand.DefaultText = "";
            txtBrand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBrand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBrand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBrand.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtBrand.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.ForeColor = Color.FromArgb(72, 80, 94);
            txtBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBrand.Location = new Point(201, 360);
            txtBrand.Margin = new Padding(3, 5, 3, 5);
            txtBrand.Name = "txtBrand";
            txtBrand.PasswordChar = '\0';
            txtBrand.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtBrand.PlaceholderText = "Brand";
            txtBrand.SelectedText = "";
            txtBrand.Size = new Size(275, 40);
            txtBrand.TabIndex = 46;
            txtBrand.TextOffset = new Point(10, 0);
            txtBrand.TextChanged += txtBrand_TextChanged;
            txtBrand.KeyDown += txtBrand_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(72, 80, 94);
            label11.Location = new Point(34, 367);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 45;
            label11.Text = "Brand";
            // 
            // lblPartNumberError
            // 
            lblPartNumberError.AutoSize = true;
            lblPartNumberError.ForeColor = Color.FromArgb(218, 62, 51);
            lblPartNumberError.Location = new Point(201, 125);
            lblPartNumberError.Name = "lblPartNumberError";
            lblPartNumberError.Size = new Size(41, 20);
            lblPartNumberError.TabIndex = 47;
            lblPartNumberError.Text = "Error";
            // 
            // lblOEMNumberError
            // 
            lblOEMNumberError.AutoSize = true;
            lblOEMNumberError.ForeColor = Color.FromArgb(218, 62, 51);
            lblOEMNumberError.Location = new Point(201, 195);
            lblOEMNumberError.Name = "lblOEMNumberError";
            lblOEMNumberError.Size = new Size(41, 20);
            lblOEMNumberError.TabIndex = 48;
            lblOEMNumberError.Text = "Error";
            // 
            // lblDescriptionError
            // 
            lblDescriptionError.AutoSize = true;
            lblDescriptionError.ForeColor = Color.FromArgb(218, 62, 51);
            lblDescriptionError.Location = new Point(201, 265);
            lblDescriptionError.Name = "lblDescriptionError";
            lblDescriptionError.Size = new Size(41, 20);
            lblDescriptionError.TabIndex = 49;
            lblDescriptionError.Text = "Error";
            // 
            // lblCategoryError
            // 
            lblCategoryError.AutoSize = true;
            lblCategoryError.ForeColor = Color.FromArgb(218, 62, 51);
            lblCategoryError.Location = new Point(201, 335);
            lblCategoryError.Name = "lblCategoryError";
            lblCategoryError.Size = new Size(41, 20);
            lblCategoryError.TabIndex = 50;
            lblCategoryError.Text = "Error";
            // 
            // lblBrandError
            // 
            lblBrandError.AutoSize = true;
            lblBrandError.ForeColor = Color.FromArgb(218, 62, 51);
            lblBrandError.Location = new Point(201, 405);
            lblBrandError.Name = "lblBrandError";
            lblBrandError.Size = new Size(41, 20);
            lblBrandError.TabIndex = 51;
            lblBrandError.Text = "Error";
            // 
            // lblVehicleBrandError
            // 
            lblVehicleBrandError.AutoSize = true;
            lblVehicleBrandError.ForeColor = Color.FromArgb(218, 62, 51);
            lblVehicleBrandError.Location = new Point(201, 475);
            lblVehicleBrandError.Name = "lblVehicleBrandError";
            lblVehicleBrandError.Size = new Size(41, 20);
            lblVehicleBrandError.TabIndex = 52;
            lblVehicleBrandError.Text = "Error";
            // 
            // lblSupplierError
            // 
            lblSupplierError.AutoSize = true;
            lblSupplierError.ForeColor = Color.FromArgb(218, 62, 51);
            lblSupplierError.Location = new Point(201, 545);
            lblSupplierError.Name = "lblSupplierError";
            lblSupplierError.Size = new Size(41, 20);
            lblSupplierError.TabIndex = 53;
            lblSupplierError.Text = "Error";
            // 
            // lblBuyingPriceError
            // 
            lblBuyingPriceError.AutoSize = true;
            lblBuyingPriceError.ForeColor = Color.FromArgb(218, 62, 51);
            lblBuyingPriceError.Location = new Point(201, 615);
            lblBuyingPriceError.Name = "lblBuyingPriceError";
            lblBuyingPriceError.Size = new Size(41, 20);
            lblBuyingPriceError.TabIndex = 54;
            lblBuyingPriceError.Text = "Error";
            // 
            // lblUnitPriceError
            // 
            lblUnitPriceError.AutoSize = true;
            lblUnitPriceError.ForeColor = Color.FromArgb(218, 62, 51);
            lblUnitPriceError.Location = new Point(201, 685);
            lblUnitPriceError.Name = "lblUnitPriceError";
            lblUnitPriceError.Size = new Size(41, 20);
            lblUnitPriceError.TabIndex = 55;
            lblUnitPriceError.Text = "Error";
            // 
            // lblQuantityError
            // 
            lblQuantityError.AutoSize = true;
            lblQuantityError.ForeColor = Color.FromArgb(218, 62, 51);
            lblQuantityError.Location = new Point(201, 755);
            lblQuantityError.Name = "lblQuantityError";
            lblQuantityError.Size = new Size(41, 20);
            lblQuantityError.TabIndex = 56;
            lblQuantityError.Text = "Error";
            // 
            // lblSuccess
            // 
            lblSuccess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuccess.AutoSize = true;
            lblSuccess.BackColor = Color.FromArgb(235, 255, 237);
            lblSuccess.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuccess.ForeColor = Color.FromArgb(16, 167, 96);
            lblSuccess.Location = new Point(141, 765);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Padding = new Padding(12, 8, 12, 8);
            lblSuccess.Size = new Size(219, 39);
            lblSuccess.TabIndex = 57;
            lblSuccess.Text = "Item added successfully!";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 896);
            ControlBox = false;
            Controls.Add(lblSuccess);
            Controls.Add(lblQuantityError);
            Controls.Add(lblUnitPriceError);
            Controls.Add(lblBuyingPriceError);
            Controls.Add(lblSupplierError);
            Controls.Add(lblVehicleBrandError);
            Controls.Add(lblBrandError);
            Controls.Add(lblCategoryError);
            Controls.Add(lblDescriptionError);
            Controls.Add(lblOEMNumberError);
            Controls.Add(lblPartNumberError);
            Controls.Add(txtBrand);
            Controls.Add(label11);
            Controls.Add(txtBuyingPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddItem);
            Controls.Add(btnDiscard);
            Controls.Add(txtSupplier);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtVehicleBrand);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtCategory);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtOEMNumber);
            Controls.Add(txtPartNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItem";
            Padding = new Padding(29);
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += AddItem_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBuyingPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDiscard;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSupplier;
        private Label label10;
        private Label label6;
        private Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtVehicleBrand;
        private Label label8;
        private Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCategory;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDescription;
        private Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtOEMNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPartNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtQuantity;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtUnitPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown txtBuyingPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBrand;
        private Label label11;
        private Label lblPartNumberError;
        private Label lblOEMNumberError;
        private Label lblDescriptionError;
        private Label lblCategoryError;
        private Label lblBrandError;
        private Label lblVehicleBrandError;
        private Label lblSupplierError;
        private Label lblBuyingPriceError;
        private Label lblUnitPriceError;
        private Label lblQuantityError;
        private Label lblSuccess;
    }
}