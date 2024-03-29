﻿namespace InventoryManagementSystem
{
    partial class AddCustomer
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
            label1 = new Label();
            label2 = new Label();
            txtCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtContactNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label3 = new Label();
            txtCity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label4 = new Label();
            txtAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label5 = new Label();
            txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label6 = new Label();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDiscard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label7 = new Label();
            lblContactNumberError = new Label();
            lblCityError = new Label();
            lblAddressError = new Label();
            lblNameError = new Label();
            lblCustomerIDError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(56, 62, 73);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 22;
            label1.Text = "New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(72, 80, 94);
            label2.Location = new Point(34, 87);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 23;
            label2.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BorderColor = Color.FromArgb(208, 213, 221);
            txtCustomerID.BorderRadius = 8;
            txtCustomerID.DefaultText = "";
            txtCustomerID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCustomerID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCustomerID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCustomerID.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtCustomerID.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.ForeColor = Color.FromArgb(72, 80, 94);
            txtCustomerID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCustomerID.Location = new Point(200, 80);
            txtCustomerID.Margin = new Padding(3, 5, 3, 5);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.PasswordChar = '\0';
            txtCustomerID.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtCustomerID.PlaceholderText = "Customer ID";
            txtCustomerID.SelectedText = "";
            txtCustomerID.Size = new Size(275, 40);
            txtCustomerID.TabIndex = 25;
            txtCustomerID.TextOffset = new Point(10, 0);
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderColor = Color.FromArgb(208, 213, 221);
            txtContactNumber.BorderRadius = 8;
            txtContactNumber.DefaultText = "";
            txtContactNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContactNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContactNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContactNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContactNumber.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtContactNumber.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumber.ForeColor = Color.FromArgb(72, 80, 94);
            txtContactNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContactNumber.Location = new Point(201, 360);
            txtContactNumber.Margin = new Padding(3, 5, 3, 5);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PasswordChar = '\0';
            txtContactNumber.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtContactNumber.PlaceholderText = "Contact Number";
            txtContactNumber.SelectedText = "";
            txtContactNumber.Size = new Size(275, 40);
            txtContactNumber.TabIndex = 27;
            txtContactNumber.TextOffset = new Point(10, 0);
            txtContactNumber.TextChanged += txtContactNumber_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(72, 80, 94);
            label3.Location = new Point(34, 367);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 26;
            label3.Text = "Contact Number";
            // 
            // txtCity
            // 
            txtCity.BorderColor = Color.FromArgb(208, 213, 221);
            txtCity.BorderRadius = 8;
            txtCity.DefaultText = "";
            txtCity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCity.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtCity.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.ForeColor = Color.FromArgb(72, 80, 94);
            txtCity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCity.Location = new Point(201, 290);
            txtCity.Margin = new Padding(3, 5, 3, 5);
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtCity.PlaceholderText = "City";
            txtCity.SelectedText = "";
            txtCity.Size = new Size(275, 40);
            txtCity.TabIndex = 29;
            txtCity.TextOffset = new Point(10, 0);
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 44;
            // 
            // txtAddress
            // 
            txtAddress.BorderColor = Color.FromArgb(208, 213, 221);
            txtAddress.BorderRadius = 8;
            txtAddress.DefaultText = "";
            txtAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAddress.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtAddress.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.FromArgb(72, 80, 94);
            txtAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAddress.Location = new Point(201, 220);
            txtAddress.Margin = new Padding(3, 5, 3, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtAddress.PlaceholderText = "Address";
            txtAddress.SelectedText = "";
            txtAddress.Size = new Size(275, 40);
            txtAddress.TabIndex = 31;
            txtAddress.TextOffset = new Point(10, 0);
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(72, 80, 94);
            label5.Location = new Point(34, 227);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 30;
            label5.Text = "Address";
            // 
            // txtName
            // 
            txtName.BorderColor = Color.FromArgb(208, 213, 221);
            txtName.BorderRadius = 8;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtName.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(72, 80, 94);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(201, 150);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.FromArgb(133, 141, 157);
            txtName.PlaceholderText = "Name";
            txtName.SelectedText = "";
            txtName.Size = new Size(275, 40);
            txtName.TabIndex = 33;
            txtName.TextOffset = new Point(10, 0);
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(72, 80, 94);
            label6.Location = new Point(34, 157);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 32;
            label6.Text = "Name";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCustomer.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.BorderRadius = 4;
            btnAddCustomer.BorderThickness = 2;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.DisabledState.BorderColor = Color.DarkGray;
            btnAddCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddCustomer.FillColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Image = Properties.Resources.addWhite;
            btnAddCustomer.ImageOffset = new Point(0, 1);
            btnAddCustomer.ImageSize = new Size(15, 15);
            btnAddCustomer.Location = new Point(329, 450);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(147, 40);
            btnAddCustomer.TabIndex = 43;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextOffset = new Point(2, 0);
            btnAddCustomer.Click += btnAddCustomer_Click;
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
            btnDiscard.Location = new Point(185, 450);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(120, 40);
            btnDiscard.TabIndex = 42;
            btnDiscard.Text = "Discard";
            btnDiscard.TextOffset = new Point(2, 0);
            btnDiscard.Click += btnDiscard_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(72, 80, 94);
            label7.Location = new Point(34, 297);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 45;
            label7.Text = "City";
            // 
            // lblContactNumberError
            // 
            lblContactNumberError.AutoSize = true;
            lblContactNumberError.ForeColor = Color.FromArgb(218, 62, 51);
            lblContactNumberError.Location = new Point(201, 405);
            lblContactNumberError.Name = "lblContactNumberError";
            lblContactNumberError.Size = new Size(41, 20);
            lblContactNumberError.TabIndex = 56;
            lblContactNumberError.Text = "Error";
            // 
            // lblCityError
            // 
            lblCityError.AutoSize = true;
            lblCityError.ForeColor = Color.FromArgb(218, 62, 51);
            lblCityError.Location = new Point(201, 335);
            lblCityError.Name = "lblCityError";
            lblCityError.Size = new Size(41, 20);
            lblCityError.TabIndex = 55;
            lblCityError.Text = "Error";
            // 
            // lblAddressError
            // 
            lblAddressError.AutoSize = true;
            lblAddressError.ForeColor = Color.FromArgb(218, 62, 51);
            lblAddressError.Location = new Point(201, 265);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(41, 20);
            lblAddressError.TabIndex = 54;
            lblAddressError.Text = "Error";
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.ForeColor = Color.FromArgb(218, 62, 51);
            lblNameError.Location = new Point(201, 195);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(41, 20);
            lblNameError.TabIndex = 53;
            lblNameError.Text = "Error";
            // 
            // lblCustomerIDError
            // 
            lblCustomerIDError.AutoSize = true;
            lblCustomerIDError.ForeColor = Color.FromArgb(218, 62, 51);
            lblCustomerIDError.Location = new Point(201, 125);
            lblCustomerIDError.Name = "lblCustomerIDError";
            lblCustomerIDError.Size = new Size(41, 20);
            lblCustomerIDError.TabIndex = 52;
            lblCustomerIDError.Text = "Error";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 519);
            ControlBox = false;
            Controls.Add(lblContactNumberError);
            Controls.Add(lblCityError);
            Controls.Add(lblAddressError);
            Controls.Add(lblNameError);
            Controls.Add(lblCustomerIDError);
            Controls.Add(label7);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnDiscard);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtContactNumber);
            Controls.Add(label3);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtContactNumber;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCity;
        private Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtAddress;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtName;
        private Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDiscard;
        private Label label7;
        private Label lblContactNumberError;
        private Label lblCityError;
        private Label lblAddressError;
        private Label lblNameError;
        private Label lblCustomerIDError;
    }
}