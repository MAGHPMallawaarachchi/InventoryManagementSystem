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
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            qtyInHand = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buyingPrice = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            priceDetails = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            supplierEmail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            supplierName = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            supplierDetails = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            brand = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            category = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            description = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            oemumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            itemNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            primaryDetails = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            partNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnEdit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            stockDetails = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            totalQty = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            qtyInHnd = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            qtySold = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            partNumberData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            oemNumberData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            descriptionData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            categoryData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            brandData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            supplierNameData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            supplierEmailData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buyingPriceData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            qtyInHandData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            totalQtyData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            qtyInHndData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            qtySoldData = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(qtySoldData);
            siticonePanel1.Controls.Add(qtyInHndData);
            siticonePanel1.Controls.Add(totalQtyData);
            siticonePanel1.Controls.Add(qtyInHandData);
            siticonePanel1.Controls.Add(buyingPriceData);
            siticonePanel1.Controls.Add(supplierEmailData);
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
            siticonePanel1.Controls.Add(qtyInHand);
            siticonePanel1.Controls.Add(buyingPrice);
            siticonePanel1.Controls.Add(priceDetails);
            siticonePanel1.Controls.Add(supplierEmail);
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
            siticonePanel1.Location = new Point(17, 14);
            siticonePanel1.Margin = new Padding(3, 2, 3, 2);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(963, 580);
            siticonePanel1.TabIndex = 0;
            siticonePanel1.SizeChanged += siticonePanel1_SizeChanged;
            siticonePanel1.Paint += siticonePanel1_Paint_1;
            // 
            // qtyInHand
            // 
            qtyInHand.BackColor = Color.Transparent;
            qtyInHand.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHand.Location = new Point(28, 521);
            qtyInHand.Margin = new Padding(3, 2, 3, 2);
            qtyInHand.Name = "qtyInHand";
            qtyInHand.Size = new Size(92, 17);
            qtyInHand.TabIndex = 16;
            qtyInHand.Text = "Quantity in hand";
            qtyInHand.Click += siticoneHtmlLabel1_Click;
            // 
            // buyingPrice
            // 
            buyingPrice.BackColor = Color.Transparent;
            buyingPrice.ForeColor = Color.FromArgb(133, 141, 157);
            buyingPrice.Location = new Point(28, 478);
            buyingPrice.Margin = new Padding(3, 2, 3, 2);
            buyingPrice.Name = "buyingPrice";
            buyingPrice.Size = new Size(69, 17);
            buyingPrice.TabIndex = 15;
            buyingPrice.Text = "Buying Price";
            buyingPrice.Click += buyingPrice_Click;
            // 
            // priceDetails
            // 
            priceDetails.BackColor = Color.Transparent;
            priceDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            priceDetails.ForeColor = Color.FromArgb(72, 80, 94);
            priceDetails.Location = new Point(28, 442);
            priceDetails.Margin = new Padding(3, 2, 3, 2);
            priceDetails.Name = "priceDetails";
            priceDetails.Size = new Size(72, 17);
            priceDetails.TabIndex = 14;
            priceDetails.Text = "Price Details";
            priceDetails.Click += priceDetails_Click;
            // 
            // supplierEmail
            // 
            supplierEmail.BackColor = Color.Transparent;
            supplierEmail.ForeColor = Color.FromArgb(133, 141, 157);
            supplierEmail.Location = new Point(28, 385);
            supplierEmail.Margin = new Padding(3, 2, 3, 2);
            supplierEmail.Name = "supplierEmail";
            supplierEmail.Size = new Size(78, 17);
            supplierEmail.TabIndex = 13;
            supplierEmail.Text = "Supplier Email";
            supplierEmail.Click += supplierEmail_Click;
            // 
            // supplierName
            // 
            supplierName.BackColor = Color.Transparent;
            supplierName.ForeColor = Color.FromArgb(133, 141, 157);
            supplierName.Location = new Point(28, 355);
            supplierName.Margin = new Padding(3, 2, 3, 2);
            supplierName.Name = "supplierName";
            supplierName.Size = new Size(81, 17);
            supplierName.TabIndex = 12;
            supplierName.Text = "Supplier Name";
            supplierName.Click += supplierName_Click;
            // 
            // supplierDetails
            // 
            supplierDetails.BackColor = Color.Transparent;
            supplierDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            supplierDetails.ForeColor = Color.FromArgb(72, 80, 94);
            supplierDetails.Location = new Point(28, 320);
            supplierDetails.Margin = new Padding(3, 2, 3, 2);
            supplierDetails.Name = "supplierDetails";
            supplierDetails.Size = new Size(90, 17);
            supplierDetails.TabIndex = 11;
            supplierDetails.Text = "Supplier Details";
            supplierDetails.Click += supplierDetails_Click;
            // 
            // brand
            // 
            brand.BackColor = Color.Transparent;
            brand.ForeColor = Color.FromArgb(133, 141, 157);
            brand.Location = new Point(31, 264);
            brand.Margin = new Padding(3, 2, 3, 2);
            brand.Name = "brand";
            brand.Size = new Size(34, 17);
            brand.TabIndex = 10;
            brand.Text = "Brand";
            brand.Click += brand_Click;
            // 
            // category
            // 
            category.BackColor = Color.Transparent;
            category.ForeColor = Color.FromArgb(133, 141, 157);
            category.Location = new Point(31, 231);
            category.Margin = new Padding(3, 2, 3, 2);
            category.Name = "category";
            category.Size = new Size(51, 17);
            category.TabIndex = 9;
            category.Text = "Category";
            category.Click += category_Click;
            // 
            // description
            // 
            description.BackColor = Color.Transparent;
            description.ForeColor = Color.FromArgb(133, 141, 157);
            description.Location = new Point(31, 196);
            description.Margin = new Padding(3, 2, 3, 2);
            description.Name = "description";
            description.Size = new Size(63, 17);
            description.TabIndex = 8;
            description.Text = "Description";
            description.Click += description_Click;
            // 
            // oemumber
            // 
            oemumber.BackColor = Color.Transparent;
            oemumber.ForeColor = Color.FromArgb(133, 141, 157);
            oemumber.Location = new Point(31, 160);
            oemumber.Margin = new Padding(3, 2, 3, 2);
            oemumber.Name = "oemumber";
            oemumber.Size = new Size(76, 17);
            oemumber.TabIndex = 7;
            oemumber.Text = "OEM Number";
            oemumber.Click += oemumber_Click;
            // 
            // itemNumber
            // 
            itemNumber.BackColor = Color.Transparent;
            itemNumber.ForeColor = Color.FromArgb(133, 141, 157);
            itemNumber.Location = new Point(31, 129);
            itemNumber.Margin = new Padding(3, 2, 3, 2);
            itemNumber.Name = "itemNumber";
            itemNumber.Size = new Size(71, 17);
            itemNumber.TabIndex = 6;
            itemNumber.Text = "Part Number";
            itemNumber.Click += itemNumber_Click;
            // 
            // primaryDetails
            // 
            primaryDetails.BackColor = Color.Transparent;
            primaryDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            primaryDetails.ForeColor = Color.FromArgb(72, 80, 94);
            primaryDetails.Location = new Point(28, 95);
            primaryDetails.Margin = new Padding(3, 2, 3, 2);
            primaryDetails.Name = "primaryDetails";
            primaryDetails.Size = new Size(87, 17);
            primaryDetails.TabIndex = 5;
            primaryDetails.Text = "Primary Details";
            primaryDetails.Click += primaryDetails_Click;
            // 
            // partNumber
            // 
            partNumber.BackColor = Color.Transparent;
            partNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            partNumber.ForeColor = Color.FromArgb(56, 62, 73);
            partNumber.Location = new Point(28, 11);
            partNumber.Margin = new Padding(3, 2, 3, 2);
            partNumber.Name = "partNumber";
            partNumber.Size = new Size(97, 25);
            partNumber.TabIndex = 4;
            partNumber.Text = "PartNumber";
            partNumber.Click += partNumber_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BorderColor = Color.FromArgb(208, 211, 217);
            btnEdit.BorderRadius = 4;
            btnEdit.BorderThickness = 2;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(93, 102, 121);
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageOffset = new Point(0, 1);
            btnEdit.ImageSize = new Size(15, 15);
            btnEdit.Location = new Point(756, 11);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
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
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(93, 102, 121);
            btnBack.ImageOffset = new Point(0, 1);
            btnBack.ImageSize = new Size(15, 10);
            btnBack.Location = new Point(861, 11);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.TextOffset = new Point(2, 0);
            btnBack.Click += btnBack_Click;
            // 
            // stockDetails
            // 
            stockDetails.BackColor = Color.Transparent;
            stockDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stockDetails.ForeColor = Color.FromArgb(72, 80, 94);
            stockDetails.Location = new Point(547, 95);
            stockDetails.Margin = new Padding(3, 2, 3, 2);
            stockDetails.Name = "stockDetails";
            stockDetails.Size = new Size(76, 17);
            stockDetails.TabIndex = 17;
            stockDetails.Text = "Stock Details";
            // 
            // totalQty
            // 
            totalQty.BackColor = Color.Transparent;
            totalQty.ForeColor = Color.FromArgb(133, 141, 157);
            totalQty.Location = new Point(547, 129);
            totalQty.Margin = new Padding(3, 2, 3, 2);
            totalQty.Name = "totalQty";
            totalQty.Size = new Size(78, 17);
            totalQty.TabIndex = 18;
            totalQty.Text = "Total Quantity";
            // 
            // qtyInHnd
            // 
            qtyInHnd.BackColor = Color.Transparent;
            qtyInHnd.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHnd.Location = new Point(547, 160);
            qtyInHnd.Margin = new Padding(3, 2, 3, 2);
            qtyInHnd.Name = "qtyInHnd";
            qtyInHnd.Size = new Size(92, 17);
            qtyInHnd.TabIndex = 19;
            qtyInHnd.Text = "Quantity in hand";
            // 
            // qtySold
            // 
            qtySold.BackColor = Color.Transparent;
            qtySold.ForeColor = Color.FromArgb(133, 141, 157);
            qtySold.Location = new Point(550, 196);
            qtySold.Margin = new Padding(3, 2, 3, 2);
            qtySold.Name = "qtySold";
            qtySold.Size = new Size(75, 17);
            qtySold.TabIndex = 20;
            qtySold.Text = "Quantity Sold";
            qtySold.Click += qtySold_Click;
            // 
            // partNumberData
            // 
            partNumberData.BackColor = Color.Transparent;
            partNumberData.ForeColor = Color.FromArgb(133, 141, 157);
            partNumberData.Location = new Point(264, 129);
            partNumberData.Margin = new Padding(3, 2, 3, 2);
            partNumberData.Name = "partNumberData";
            partNumberData.Size = new Size(27, 17);
            partNumberData.TabIndex = 21;
            partNumberData.Text = "Data";
            // 
            // oemNumberData
            // 
            oemNumberData.BackColor = Color.Transparent;
            oemNumberData.ForeColor = Color.FromArgb(133, 141, 157);
            oemNumberData.Location = new Point(264, 160);
            oemNumberData.Margin = new Padding(3, 2, 3, 2);
            oemNumberData.Name = "oemNumberData";
            oemNumberData.Size = new Size(27, 17);
            oemNumberData.TabIndex = 22;
            oemNumberData.Text = "Data";
            // 
            // descriptionData
            // 
            descriptionData.BackColor = Color.Transparent;
            descriptionData.ForeColor = Color.FromArgb(133, 141, 157);
            descriptionData.Location = new Point(264, 196);
            descriptionData.Margin = new Padding(3, 2, 3, 2);
            descriptionData.Name = "descriptionData";
            descriptionData.Size = new Size(27, 17);
            descriptionData.TabIndex = 23;
            descriptionData.Text = "Data";
            // 
            // categoryData
            // 
            categoryData.BackColor = Color.Transparent;
            categoryData.ForeColor = Color.FromArgb(133, 141, 157);
            categoryData.Location = new Point(264, 231);
            categoryData.Margin = new Padding(3, 2, 3, 2);
            categoryData.Name = "categoryData";
            categoryData.Size = new Size(27, 17);
            categoryData.TabIndex = 24;
            categoryData.Text = "Data";
            // 
            // brandData
            // 
            brandData.BackColor = Color.Transparent;
            brandData.ForeColor = Color.FromArgb(133, 141, 157);
            brandData.Location = new Point(264, 264);
            brandData.Margin = new Padding(3, 2, 3, 2);
            brandData.Name = "brandData";
            brandData.Size = new Size(27, 17);
            brandData.TabIndex = 25;
            brandData.Text = "Data";
            // 
            // supplierNameData
            // 
            supplierNameData.BackColor = Color.Transparent;
            supplierNameData.ForeColor = Color.FromArgb(133, 141, 157);
            supplierNameData.Location = new Point(264, 355);
            supplierNameData.Margin = new Padding(3, 2, 3, 2);
            supplierNameData.Name = "supplierNameData";
            supplierNameData.Size = new Size(27, 17);
            supplierNameData.TabIndex = 26;
            supplierNameData.Text = "Data";
            // 
            // supplierEmailData
            // 
            supplierEmailData.BackColor = Color.Transparent;
            supplierEmailData.ForeColor = Color.FromArgb(133, 141, 157);
            supplierEmailData.Location = new Point(264, 385);
            supplierEmailData.Margin = new Padding(3, 2, 3, 2);
            supplierEmailData.Name = "supplierEmailData";
            supplierEmailData.Size = new Size(27, 17);
            supplierEmailData.TabIndex = 27;
            supplierEmailData.Text = "Data";
            // 
            // buyingPriceData
            // 
            buyingPriceData.BackColor = Color.Transparent;
            buyingPriceData.ForeColor = Color.FromArgb(133, 141, 157);
            buyingPriceData.Location = new Point(264, 478);
            buyingPriceData.Margin = new Padding(3, 2, 3, 2);
            buyingPriceData.Name = "buyingPriceData";
            buyingPriceData.Size = new Size(27, 17);
            buyingPriceData.TabIndex = 28;
            buyingPriceData.Text = "Data";
            // 
            // qtyInHandData
            // 
            qtyInHandData.BackColor = Color.Transparent;
            qtyInHandData.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHandData.Location = new Point(264, 521);
            qtyInHandData.Margin = new Padding(3, 2, 3, 2);
            qtyInHandData.Name = "qtyInHandData";
            qtyInHandData.Size = new Size(27, 17);
            qtyInHandData.TabIndex = 29;
            qtyInHandData.Text = "Data";
            // 
            // totalQtyData
            // 
            totalQtyData.BackColor = Color.Transparent;
            totalQtyData.ForeColor = Color.FromArgb(133, 141, 157);
            totalQtyData.Location = new Point(736, 129);
            totalQtyData.Margin = new Padding(3, 2, 3, 2);
            totalQtyData.Name = "totalQtyData";
            totalQtyData.Size = new Size(27, 17);
            totalQtyData.TabIndex = 30;
            totalQtyData.Text = "Data";
            // 
            // qtyInHndData
            // 
            qtyInHndData.BackColor = Color.Transparent;
            qtyInHndData.ForeColor = Color.FromArgb(133, 141, 157);
            qtyInHndData.Location = new Point(736, 160);
            qtyInHndData.Margin = new Padding(3, 2, 3, 2);
            qtyInHndData.Name = "qtyInHndData";
            qtyInHndData.Size = new Size(27, 17);
            qtyInHndData.TabIndex = 31;
            qtyInHndData.Text = "Data";
            // 
            // qtySoldData
            // 
            qtySoldData.BackColor = Color.Transparent;
            qtySoldData.ForeColor = Color.FromArgb(133, 141, 157);
            qtySoldData.Location = new Point(736, 196);
            qtySoldData.Margin = new Padding(3, 2, 3, 2);
            qtySoldData.Name = "qtySoldData";
            qtySoldData.Size = new Size(27, 17);
            qtySoldData.TabIndex = 32;
            qtySoldData.Text = "Data";
            // 
            // UC_ItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticonePanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_ItemDetails";
            Padding = new Padding(17, 14, 19, 16);
            Size = new Size(999, 610);
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBack;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEdit;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtyInHand;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel buyingPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel priceDetails;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierEmail;
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
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel qtyInHandData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel buyingPriceData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierEmailData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel supplierNameData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel brandData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel categoryData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel descriptionData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel oemNumberData;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel partNumberData;
    }
}
