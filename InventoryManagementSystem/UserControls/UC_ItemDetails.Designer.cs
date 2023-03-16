using Siticone.Desktop.UI.WinForms;

namespace InventoryManagementSystem.UserControls
{
    partial class UC_ItemDetails
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
            siticonePanel1 = new SiticonePanel();
            txtVehicleBrand = new SiticoneTextBox();
            lblVehicleBrandData = new SiticoneHtmlLabel();
            lblVehicleBrand = new SiticoneHtmlLabel();
            btnCancel = new SiticoneButton();
            btnUpdate = new SiticoneButton();
            txtQuantitySold = new SiticoneTextBox();
            txtQuantityInHand = new SiticoneTextBox();
            txtTotalQuantity = new SiticoneTextBox();
            txtUnitPrice = new SiticoneTextBox();
            txtBuyingPrice = new SiticoneTextBox();
            txtSupplier = new SiticoneTextBox();
            txtBrand = new SiticoneTextBox();
            txtCategory = new SiticoneTextBox();
            txtDescription = new SiticoneTextBox();
            txtOEMNumber = new SiticoneTextBox();
            txtPartNumber = new SiticoneTextBox();
            qtySoldData = new SiticoneHtmlLabel();
            qtyInHndData = new SiticoneHtmlLabel();
            totalQtyData = new SiticoneHtmlLabel();
            unitPriceData = new SiticoneHtmlLabel();
            buyingPriceData = new SiticoneHtmlLabel();
            supplierNameData = new SiticoneHtmlLabel();
            brandData = new SiticoneHtmlLabel();
            categoryData = new SiticoneHtmlLabel();
            descriptionData = new SiticoneHtmlLabel();
            oemNumberData = new SiticoneHtmlLabel();
            partNumberData = new SiticoneHtmlLabel();
            qtySold = new SiticoneHtmlLabel();
            qtyInHnd = new SiticoneHtmlLabel();
            totalQty = new SiticoneHtmlLabel();
            stockDetails = new SiticoneHtmlLabel();
            unitPrice = new SiticoneHtmlLabel();
            buyingPrice = new SiticoneHtmlLabel();
            priceDetails = new SiticoneHtmlLabel();
            supplierName = new SiticoneHtmlLabel();
            supplierDetails = new SiticoneHtmlLabel();
            brand = new SiticoneHtmlLabel();
            category = new SiticoneHtmlLabel();
            description = new SiticoneHtmlLabel();
            oemumber = new SiticoneHtmlLabel();
            itemNumber = new SiticoneHtmlLabel();
            primaryDetails = new SiticoneHtmlLabel();
            partNumber = new SiticoneHtmlLabel();
            btnEdit = new SiticoneButton();
            btnBack = new SiticoneButton();
            siticonePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(txtVehicleBrand);
            siticonePanel1.Controls.Add(lblVehicleBrandData);
            siticonePanel1.Controls.Add(lblVehicleBrand);
            siticonePanel1.Controls.Add(btnCancel);
            siticonePanel1.Controls.Add(btnUpdate);
            siticonePanel1.Controls.Add(txtQuantitySold);
            siticonePanel1.Controls.Add(txtQuantityInHand);
            siticonePanel1.Controls.Add(txtTotalQuantity);
            siticonePanel1.Controls.Add(txtUnitPrice);
            siticonePanel1.Controls.Add(txtBuyingPrice);
            siticonePanel1.Controls.Add(txtSupplier);
            siticonePanel1.Controls.Add(txtBrand);
            siticonePanel1.Controls.Add(txtCategory);
            siticonePanel1.Controls.Add(txtDescription);
            siticonePanel1.Controls.Add(txtOEMNumber);
            siticonePanel1.Controls.Add(txtPartNumber);
            siticonePanel1.Controls.Add(qtySoldData);
            siticonePanel1.Controls.Add(qtyInHndData);
            siticonePanel1.Controls.Add(totalQtyData);
            siticonePanel1.Controls.Add(unitPriceData);
            siticonePanel1.Controls.Add(buyingPriceData);
            siticonePanel1.Controls.Add(supplierNameData);
            siticonePanel1.Controls.Add(brandData);
            siticonePanel1.Controls.Add(categoryData);
            siticonePanel1.Controls.Add(descriptionData);
            siticonePanel1.Controls.Add(oemNumberData);
            siticonePanel1.Controls.Add(partNumberData);
            siticonePanel1.Controls.Add(qtySold);
            siticonePanel1.Controls.Add(qtyInHnd);
            siticonePanel1.Controls.Add(totalQty);
            siticonePanel1.Controls.Add(stockDetails);
            siticonePanel1.Controls.Add(unitPrice);
            siticonePanel1.Controls.Add(buyingPrice);
            siticonePanel1.Controls.Add(priceDetails);
            siticonePanel1.Controls.Add(supplierName);
            siticonePanel1.Controls.Add(supplierDetails);
            siticonePanel1.Controls.Add(brand);
            siticonePanel1.Controls.Add(category);
            siticonePanel1.Controls.Add(description);
            siticonePanel1.Controls.Add(oemumber);
            siticonePanel1.Controls.Add(itemNumber);
            siticonePanel1.Controls.Add(primaryDetails);
            siticonePanel1.Controls.Add(partNumber);
            siticonePanel1.Controls.Add(btnEdit);
            siticonePanel1.Controls.Add(btnBack);
            siticonePanel1.Dock = DockStyle.Fill;
            siticonePanel1.Location = new Point(19, 19);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1101, 773);
            siticonePanel1.TabIndex = 0;
            siticonePanel1.SizeChanged += siticonePanel1_SizeChanged;
            // 
            // txtVehicleBrand
            // 
            txtVehicleBrand.DefaultText = "";
            txtVehicleBrand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtVehicleBrand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtVehicleBrand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtVehicleBrand.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtVehicleBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtVehicleBrand.Location = new Point(293, 376);
            txtVehicleBrand.Margin = new Padding(3, 5, 3, 5);
            txtVehicleBrand.Name = "txtVehicleBrand";
            txtVehicleBrand.PasswordChar = '\0';
            txtVehicleBrand.PlaceholderText = "";
            txtVehicleBrand.SelectedText = "";
            txtVehicleBrand.Size = new Size(215, 33);
            txtVehicleBrand.TabIndex = 49;
            txtVehicleBrand.Visible = false;
            // 
            // lblVehicleBrandData
            // 
            lblVehicleBrandData.BackColor = Color.Transparent;
            lblVehicleBrandData.ForeColor = Color.FromArgb(133, 141, 157);
            lblVehicleBrandData.Location = new Point(310, 378);
            lblVehicleBrandData.Name = "lblVehicleBrandData";
            lblVehicleBrandData.Size = new Size(35, 22);
            lblVehicleBrandData.TabIndex = 48;
            lblVehicleBrandData.Text = "Data";
            // 
            // lblVehicleBrand
            // 
            lblVehicleBrand.BackColor = Color.Transparent;
            lblVehicleBrand.ForeColor = Color.FromArgb(133, 141, 157);
            lblVehicleBrand.Location = new Point(43, 378);
            lblVehicleBrand.Name = "lblVehicleBrand";
            lblVehicleBrand.Size = new Size(94, 22);
            lblVehicleBrand.TabIndex = 47;
            lblVehicleBrand.Text = "Vehicle Brand";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BorderColor = Color.FromArgb(208, 211, 217);
            btnCancel.BorderRadius = 4;
            btnCancel.BorderThickness = 2;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(93, 102, 121);
            btnCancel.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnCancel.HoverState.FillColor = Color.Transparent;
            btnCancel.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnCancel.ImageOffset = new Point(0, 1);
            btnCancel.ImageSize = new Size(15, 10);
            btnCancel.Location = new Point(838, 703);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 40);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Cancel";
            btnCancel.TextOffset = new Point(2, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BorderColor = Color.FromArgb(10, 73, 156);
            btnUpdate.BorderRadius = 4;
            btnUpdate.BorderThickness = 2;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.FromArgb(10, 73, 156);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnUpdate.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnUpdate.ImageOffset = new Point(0, 1);
            btnUpdate.ImageSize = new Size(15, 10);
            btnUpdate.Location = new Point(951, 703);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 40);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.TextOffset = new Point(2, 0);
            btnUpdate.Visible = false;
            btnUpdate.Click += updateBtn_Click;
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.Anchor = AnchorStyles.None;
            txtQuantitySold.DefaultText = "";
            txtQuantitySold.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuantitySold.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuantitySold.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuantitySold.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuantitySold.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantitySold.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantitySold.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantitySold.Location = new Point(838, 251);
            txtQuantitySold.Margin = new Padding(3, 5, 3, 5);
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.PasswordChar = '\0';
            txtQuantitySold.PlaceholderText = "";
            txtQuantitySold.SelectedText = "";
            txtQuantitySold.Size = new Size(215, 33);
            txtQuantitySold.TabIndex = 44;
            txtQuantitySold.Visible = false;
            // 
            // txtQuantityInHand
            // 
            txtQuantityInHand.Anchor = AnchorStyles.None;
            txtQuantityInHand.DefaultText = "";
            txtQuantityInHand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuantityInHand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuantityInHand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuantityInHand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuantityInHand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantityInHand.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantityInHand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuantityInHand.Location = new Point(838, 207);
            txtQuantityInHand.Margin = new Padding(3, 5, 3, 5);
            txtQuantityInHand.Name = "txtQuantityInHand";
            txtQuantityInHand.PasswordChar = '\0';
            txtQuantityInHand.PlaceholderText = "";
            txtQuantityInHand.SelectedText = "";
            txtQuantityInHand.Size = new Size(215, 33);
            txtQuantityInHand.TabIndex = 43;
            txtQuantityInHand.Visible = false;
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Anchor = AnchorStyles.None;
            txtTotalQuantity.DefaultText = "";
            txtTotalQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTotalQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTotalQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTotalQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTotalQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalQuantity.Location = new Point(838, 163);
            txtTotalQuantity.Margin = new Padding(3, 5, 3, 5);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.PasswordChar = '\0';
            txtTotalQuantity.PlaceholderText = "";
            txtTotalQuantity.SelectedText = "";
            txtTotalQuantity.Size = new Size(215, 33);
            txtTotalQuantity.TabIndex = 42;
            txtTotalQuantity.Visible = false;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.DefaultText = "";
            txtUnitPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUnitPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUnitPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUnitPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUnitPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUnitPrice.Location = new Point(293, 649);
            txtUnitPrice.Margin = new Padding(3, 5, 3, 5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PasswordChar = '\0';
            txtUnitPrice.PlaceholderText = "";
            txtUnitPrice.SelectedText = "";
            txtUnitPrice.Size = new Size(215, 33);
            txtUnitPrice.TabIndex = 41;
            txtUnitPrice.Visible = false;
            // 
            // txtBuyingPrice
            // 
            txtBuyingPrice.DefaultText = "";
            txtBuyingPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuyingPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuyingPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuyingPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuyingPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuyingPrice.Location = new Point(293, 604);
            txtBuyingPrice.Margin = new Padding(3, 5, 3, 5);
            txtBuyingPrice.Name = "txtBuyingPrice";
            txtBuyingPrice.PasswordChar = '\0';
            txtBuyingPrice.PlaceholderText = "";
            txtBuyingPrice.SelectedText = "";
            txtBuyingPrice.Size = new Size(215, 33);
            txtBuyingPrice.TabIndex = 40;
            txtBuyingPrice.Visible = false;
            // 
            // txtSupplier
            // 
            txtSupplier.DefaultText = "";
            txtSupplier.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSupplier.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSupplier.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSupplier.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSupplier.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplier.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSupplier.Location = new Point(293, 501);
            txtSupplier.Margin = new Padding(3, 5, 3, 5);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.PasswordChar = '\0';
            txtSupplier.PlaceholderText = "";
            txtSupplier.SelectedText = "";
            txtSupplier.Size = new Size(215, 33);
            txtSupplier.TabIndex = 38;
            txtSupplier.Visible = false;
            // 
            // txtBrand
            // 
            txtBrand.DefaultText = "";
            txtBrand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBrand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBrand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBrand.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBrand.Location = new Point(293, 337);
            txtBrand.Margin = new Padding(3, 5, 3, 5);
            txtBrand.Name = "txtBrand";
            txtBrand.PasswordChar = '\0';
            txtBrand.PlaceholderText = "";
            txtBrand.SelectedText = "";
            txtBrand.Size = new Size(215, 33);
            txtBrand.TabIndex = 37;
            txtBrand.Visible = false;
            // 
            // txtCategory
            // 
            txtCategory.DefaultText = "";
            txtCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Location = new Point(293, 296);
            txtCategory.Margin = new Padding(3, 5, 3, 5);
            txtCategory.Name = "txtCategory";
            txtCategory.PasswordChar = '\0';
            txtCategory.PlaceholderText = "";
            txtCategory.SelectedText = "";
            txtCategory.Size = new Size(215, 33);
            txtCategory.TabIndex = 36;
            txtCategory.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(293, 256);
            txtDescription.Margin = new Padding(3, 5, 3, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderText = "";
            txtDescription.SelectedText = "";
            txtDescription.Size = new Size(215, 33);
            txtDescription.TabIndex = 35;
            txtDescription.Visible = false;
            // 
            // txtOEMNumber
            // 
            txtOEMNumber.DefaultText = "";
            txtOEMNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOEMNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOEMNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOEMNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOEMNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOEMNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOEMNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOEMNumber.Location = new Point(293, 215);
            txtOEMNumber.Margin = new Padding(3, 5, 3, 5);
            txtOEMNumber.Name = "txtOEMNumber";
            txtOEMNumber.PasswordChar = '\0';
            txtOEMNumber.PlaceholderText = "";
            txtOEMNumber.SelectedText = "";
            txtOEMNumber.Size = new Size(215, 33);
            txtOEMNumber.TabIndex = 34;
            txtOEMNumber.Visible = false;
            // 
            // txtPartNumber
            // 
            txtPartNumber.DefaultText = "";
            txtPartNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPartNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPartNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPartNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPartNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPartNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPartNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPartNumber.Location = new Point(293, 172);
            txtPartNumber.Margin = new Padding(3, 5, 3, 5);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.PasswordChar = '\0';
            txtPartNumber.PlaceholderText = "";
            txtPartNumber.SelectedText = "";
            txtPartNumber.Size = new Size(215, 33);
            txtPartNumber.TabIndex = 33;
            txtPartNumber.Visible = false;
            // 
            // qtySoldData
            // 
            qtySoldData.Anchor = AnchorStyles.None;
            qtySoldData.BackColor = Color.Transparent;
            qtySoldData.ForeColor = Color.FromArgb(133, 141, 157);
            qtySoldData.Location = new Point(838, 256);
            qtySoldData.Name = "qtySoldData";
            qtySoldData.Size = new Size(35, 22);
            qtySoldData.TabIndex = 32;
            qtySoldData.Text = "Data";
            // 
            // qtyInHndData
            // 
            qtyInHndData.Anchor = AnchorStyles.None;
            qtyInHndData.BackColor = Color.Transparent;
            qtyInHndData.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHndData.Location = new Point(838, 217);
            qtyInHndData.Name = "qtyInHndData";
            qtyInHndData.Size = new Size(35, 22);
            qtyInHndData.TabIndex = 31;
            qtyInHndData.Text = "Data";
            // 
            // totalQtyData
            // 
            totalQtyData.Anchor = AnchorStyles.None;
            totalQtyData.BackColor = Color.Transparent;
            totalQtyData.ForeColor = Color.FromArgb(133, 141, 157);
            totalQtyData.Location = new Point(838, 176);
            totalQtyData.Name = "totalQtyData";
            totalQtyData.Size = new Size(35, 22);
            totalQtyData.TabIndex = 30;
            totalQtyData.Text = "Data";
            // 
            // unitPriceData
            // 
            unitPriceData.BackColor = Color.Transparent;
            unitPriceData.ForeColor = Color.FromArgb(133, 141, 157);
            unitPriceData.Location = new Point(310, 661);
            unitPriceData.Name = "unitPriceData";
            unitPriceData.Size = new Size(35, 22);
            unitPriceData.TabIndex = 29;
            unitPriceData.Text = "Data";
            // 
            // buyingPriceData
            // 
            buyingPriceData.BackColor = Color.Transparent;
            buyingPriceData.ForeColor = Color.FromArgb(133, 141, 157);
            buyingPriceData.Location = new Point(310, 619);
            buyingPriceData.Name = "buyingPriceData";
            buyingPriceData.Size = new Size(35, 22);
            buyingPriceData.TabIndex = 28;
            buyingPriceData.Text = "Data";
            // 
            // supplierNameData
            // 
            supplierNameData.BackColor = Color.Transparent;
            supplierNameData.ForeColor = Color.FromArgb(133, 141, 157);
            supplierNameData.Location = new Point(310, 506);
            supplierNameData.Name = "supplierNameData";
            supplierNameData.Size = new Size(35, 22);
            supplierNameData.TabIndex = 26;
            supplierNameData.Text = "Data";
            // 
            // brandData
            // 
            brandData.BackColor = Color.Transparent;
            brandData.ForeColor = Color.FromArgb(133, 141, 157);
            brandData.Location = new Point(310, 337);
            brandData.Name = "brandData";
            brandData.Size = new Size(35, 22);
            brandData.TabIndex = 25;
            brandData.Text = "Data";
            // 
            // categoryData
            // 
            categoryData.BackColor = Color.Transparent;
            categoryData.ForeColor = Color.FromArgb(133, 141, 157);
            categoryData.Location = new Point(310, 296);
            categoryData.Name = "categoryData";
            categoryData.Size = new Size(35, 22);
            categoryData.TabIndex = 24;
            categoryData.Text = "Data";
            // 
            // descriptionData
            // 
            descriptionData.BackColor = Color.Transparent;
            descriptionData.ForeColor = Color.FromArgb(133, 141, 157);
            descriptionData.Location = new Point(310, 256);
            descriptionData.Name = "descriptionData";
            descriptionData.Size = new Size(35, 22);
            descriptionData.TabIndex = 23;
            descriptionData.Text = "Data";
            // 
            // oemNumberData
            // 
            oemNumberData.BackColor = Color.Transparent;
            oemNumberData.ForeColor = Color.FromArgb(133, 141, 157);
            oemNumberData.Location = new Point(310, 217);
            oemNumberData.Name = "oemNumberData";
            oemNumberData.Size = new Size(35, 22);
            oemNumberData.TabIndex = 22;
            oemNumberData.Text = "Data";
            // 
            // partNumberData
            // 
            partNumberData.BackColor = Color.Transparent;
            partNumberData.ForeColor = Color.FromArgb(133, 141, 157);
            partNumberData.Location = new Point(310, 176);
            partNumberData.Name = "partNumberData";
            partNumberData.Size = new Size(35, 22);
            partNumberData.TabIndex = 21;
            partNumberData.Text = "Data";
            // 
            // qtySold
            // 
            qtySold.Anchor = AnchorStyles.None;
            qtySold.BackColor = Color.Transparent;
            qtySold.ForeColor = Color.FromArgb(133, 141, 157);
            qtySold.Location = new Point(622, 260);
            qtySold.Name = "qtySold";
            qtySold.Size = new Size(93, 22);
            qtySold.TabIndex = 20;
            qtySold.Text = "Quantity Sold";
            // 
            // qtyInHnd
            // 
            qtyInHnd.Anchor = AnchorStyles.None;
            qtyInHnd.BackColor = Color.Transparent;
            qtyInHnd.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHnd.Location = new Point(622, 217);
            qtyInHnd.Name = "qtyInHnd";
            qtyInHnd.Size = new Size(112, 22);
            qtyInHnd.TabIndex = 19;
            qtyInHnd.Text = "Quantity in hand";
            // 
            // totalQty
            // 
            totalQty.Anchor = AnchorStyles.None;
            totalQty.BackColor = Color.Transparent;
            totalQty.ForeColor = Color.FromArgb(133, 141, 157);
            totalQty.Location = new Point(622, 176);
            totalQty.Name = "totalQty";
            totalQty.Size = new Size(97, 22);
            totalQty.TabIndex = 18;
            totalQty.Text = "Total Quantity";
            // 
            // stockDetails
            // 
            stockDetails.Anchor = AnchorStyles.None;
            stockDetails.BackColor = Color.Transparent;
            stockDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stockDetails.ForeColor = Color.FromArgb(72, 80, 94);
            stockDetails.Location = new Point(622, 131);
            stockDetails.Name = "stockDetails";
            stockDetails.Size = new Size(93, 22);
            stockDetails.TabIndex = 17;
            stockDetails.Text = "Stock Details";
            // 
            // unitPrice
            // 
            unitPrice.BackColor = Color.Transparent;
            unitPrice.ForeColor = Color.FromArgb(133, 141, 157);
            unitPrice.Location = new Point(40, 661);
            unitPrice.Name = "unitPrice";
            unitPrice.Size = new Size(66, 22);
            unitPrice.TabIndex = 16;
            unitPrice.Text = "Unit Price";
            // 
            // buyingPrice
            // 
            buyingPrice.BackColor = Color.Transparent;
            buyingPrice.ForeColor = Color.FromArgb(133, 141, 157);
            buyingPrice.Location = new Point(40, 619);
            buyingPrice.Name = "buyingPrice";
            buyingPrice.Size = new Size(84, 22);
            buyingPrice.TabIndex = 15;
            buyingPrice.Text = "Buying Price";
            // 
            // priceDetails
            // 
            priceDetails.BackColor = Color.Transparent;
            priceDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            priceDetails.ForeColor = Color.FromArgb(72, 80, 94);
            priceDetails.Location = new Point(40, 576);
            priceDetails.Name = "priceDetails";
            priceDetails.Size = new Size(89, 22);
            priceDetails.TabIndex = 14;
            priceDetails.Text = "Price Details";
            // 
            // supplierName
            // 
            supplierName.BackColor = Color.Transparent;
            supplierName.ForeColor = Color.FromArgb(133, 141, 157);
            supplierName.Location = new Point(40, 506);
            supplierName.Name = "supplierName";
            supplierName.Size = new Size(102, 22);
            supplierName.TabIndex = 12;
            supplierName.Text = "Supplier Name";
            // 
            // supplierDetails
            // 
            supplierDetails.BackColor = Color.Transparent;
            supplierDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            supplierDetails.ForeColor = Color.FromArgb(72, 80, 94);
            supplierDetails.Location = new Point(40, 461);
            supplierDetails.Name = "supplierDetails";
            supplierDetails.Size = new Size(112, 22);
            supplierDetails.TabIndex = 11;
            supplierDetails.Text = "Supplier Details";
            // 
            // brand
            // 
            brand.BackColor = Color.Transparent;
            brand.ForeColor = Color.FromArgb(133, 141, 157);
            brand.Location = new Point(43, 337);
            brand.Name = "brand";
            brand.Size = new Size(42, 22);
            brand.TabIndex = 10;
            brand.Text = "Brand";
            // 
            // category
            // 
            category.BackColor = Color.Transparent;
            category.ForeColor = Color.FromArgb(133, 141, 157);
            category.Location = new Point(43, 296);
            category.Name = "category";
            category.Size = new Size(63, 22);
            category.TabIndex = 9;
            category.Text = "Category";
            // 
            // description
            // 
            description.BackColor = Color.Transparent;
            description.ForeColor = Color.FromArgb(133, 141, 157);
            description.Location = new Point(43, 256);
            description.Name = "description";
            description.Size = new Size(79, 22);
            description.TabIndex = 8;
            description.Text = "Description";
            // 
            // oemumber
            // 
            oemumber.BackColor = Color.Transparent;
            oemumber.ForeColor = Color.FromArgb(133, 141, 157);
            oemumber.Location = new Point(43, 217);
            oemumber.Name = "oemumber";
            oemumber.Size = new Size(93, 22);
            oemumber.TabIndex = 7;
            oemumber.Text = "OEM Number";
            // 
            // itemNumber
            // 
            itemNumber.BackColor = Color.Transparent;
            itemNumber.ForeColor = Color.FromArgb(133, 141, 157);
            itemNumber.Location = new Point(43, 176);
            itemNumber.Name = "itemNumber";
            itemNumber.Size = new Size(87, 22);
            itemNumber.TabIndex = 6;
            itemNumber.Text = "Part Number";
            // 
            // primaryDetails
            // 
            primaryDetails.BackColor = Color.Transparent;
            primaryDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            primaryDetails.ForeColor = Color.FromArgb(72, 80, 94);
            primaryDetails.Location = new Point(43, 131);
            primaryDetails.Name = "primaryDetails";
            primaryDetails.Size = new Size(110, 22);
            primaryDetails.TabIndex = 5;
            primaryDetails.Text = "Primary Details";
            // 
            // partNumber
            // 
            partNumber.BackColor = Color.Transparent;
            partNumber.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            partNumber.ForeColor = Color.FromArgb(41, 41, 41);
            partNumber.Location = new Point(43, 27);
            partNumber.Name = "partNumber";
            partNumber.Size = new Size(121, 32);
            partNumber.TabIndex = 4;
            partNumber.Text = "PartNumber";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BorderColor = Color.FromArgb(208, 211, 217);
            btnEdit.BorderRadius = 4;
            btnEdit.BorderThickness = 2;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(93, 102, 121);
            btnEdit.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnEdit.HoverState.FillColor = Color.Transparent;
            btnEdit.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnEdit.HoverState.Image = Properties.Resources.editBlue;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageSize = new Size(15, 15);
            btnEdit.Location = new Point(838, 27);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(103, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.TextOffset = new Point(2, 0);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BorderColor = Color.FromArgb(208, 211, 217);
            btnBack.BorderRadius = 4;
            btnBack.BorderThickness = 2;
            btnBack.Cursor = Cursors.Hand;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(93, 102, 121);
            btnBack.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnBack.HoverState.FillColor = Color.Transparent;
            btnBack.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnBack.ImageOffset = new Point(0, 1);
            btnBack.ImageSize = new Size(15, 10);
            btnBack.Location = new Point(951, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.TextOffset = new Point(2, 0);
            btnBack.Click += btnBack_Click;
            // 
            // UC_ItemDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticonePanel1);
            Name = "UC_ItemDetails";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1142, 813);
            Load += UC_ItemDetails_Load;
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBack;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEdit;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel unitPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel buyingPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel priceDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel brand;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel category;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel description;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel oemumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel itemNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel primaryDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel partNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtySold;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtyInHnd;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalQty;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel stockDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtySoldData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtyInHndData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel totalQtyData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel unitPriceData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel buyingPriceData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierNameData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel brandData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel categoryData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel descriptionData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel oemNumberData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel partNumberData;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPartNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBuyingPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSupplier;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtBrand;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDescription;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtOEMNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUpdate;
        private SiticoneTextBox txtQuantitySold;
        private SiticoneTextBox txtQuantityInHand;
        private SiticoneTextBox txtTotalQuantity;
        private SiticoneTextBox txtUnitPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCancel;
        private SiticoneTextBox txtVehicleBrand;
        private SiticoneHtmlLabel lblVehicleBrandData;
        private SiticoneHtmlLabel lblVehicleBrand;
    }
}
