namespace InventoryManagementSystem
{
    partial class EditCustomer
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
            label7 = new Label();
            btnEditCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnDiscard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            txtName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label6 = new Label();
            txtAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label5 = new Label();
            txtCity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            txtContactNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label3 = new Label();
            txtCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(72, 80, 94);
            label7.Location = new Point(35, 291);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 58;
            label7.Text = "City";
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditCustomer.BorderColor = Color.FromArgb(10, 73, 156);
            btnEditCustomer.BorderRadius = 4;
            btnEditCustomer.BorderThickness = 2;
            btnEditCustomer.Cursor = Cursors.Hand;
            btnEditCustomer.DisabledState.BorderColor = Color.DarkGray;
            btnEditCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditCustomer.FillColor = Color.FromArgb(10, 73, 156);
            btnEditCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditCustomer.ForeColor = Color.White;
            btnEditCustomer.ImageOffset = new Point(0, 1);
            btnEditCustomer.ImageSize = new Size(15, 10);
            btnEditCustomer.Location = new Point(286, 500);
            btnEditCustomer.Margin = new Padding(3, 2, 3, 2);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(129, 30);
            btnEditCustomer.TabIndex = 57;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.TextOffset = new Point(2, 0);
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDiscard
            // 
            btnDiscard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnDiscard.Location = new Point(176, 500);
            btnDiscard.Margin = new Padding(3, 2, 3, 2);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(89, 30);
            btnDiscard.TabIndex = 56;
            btnDiscard.Text = "Discard";
            btnDiscard.TextOffset = new Point(2, 0);
            btnDiscard.Click += btnDiscard_Click;
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
            txtName.Location = new Point(176, 161);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.Size = new Size(239, 33);
            txtName.TabIndex = 55;
            txtName.TextOffset = new Point(10, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(72, 80, 94);
            label6.Location = new Point(35, 166);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 54;
            label6.Text = "Name";
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
            txtAddress.Location = new Point(176, 218);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PlaceholderText = "";
            txtAddress.SelectedText = "";
            txtAddress.Size = new Size(239, 33);
            txtAddress.TabIndex = 53;
            txtAddress.TextOffset = new Point(10, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(72, 80, 94);
            label5.Location = new Point(35, 223);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 52;
            label5.Text = "Address";
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
            txtCity.Location = new Point(176, 278);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.PlaceholderText = "";
            txtCity.SelectedText = "";
            txtCity.Size = new Size(239, 33);
            txtCity.TabIndex = 51;
            txtCity.TextOffset = new Point(10, 0);
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
            txtContactNumber.Location = new Point(176, 345);
            txtContactNumber.Margin = new Padding(3, 4, 3, 4);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PasswordChar = '\0';
            txtContactNumber.PlaceholderText = "";
            txtContactNumber.SelectedText = "";
            txtContactNumber.Size = new Size(239, 33);
            txtContactNumber.TabIndex = 50;
            txtContactNumber.TextOffset = new Point(10, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(72, 80, 94);
            label3.Location = new Point(35, 350);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 49;
            label3.Text = "Contact Number";
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
            txtCustomerID.Enabled = false;
            txtCustomerID.FocusedState.BorderColor = Color.FromArgb(10, 73, 156);
            txtCustomerID.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.ForeColor = Color.FromArgb(72, 80, 94);
            txtCustomerID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCustomerID.Location = new Point(176, 105);
            txtCustomerID.Margin = new Padding(3, 4, 3, 4);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.PasswordChar = '\0';
            txtCustomerID.PlaceholderText = "";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.SelectedText = "";
            txtCustomerID.Size = new Size(239, 33);
            txtCustomerID.TabIndex = 48;
            txtCustomerID.TextOffset = new Point(10, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(72, 80, 94);
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 47;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(56, 62, 73);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 46;
            label1.Text = "Edit Customer";
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 549);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnDiscard);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(txtContactNumber);
            Controls.Add(label3);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEditCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDiscard;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtName;
        private Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtAddress;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCity;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtContactNumber;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtCustomerID;
        private Label label2;
        private Label label1;
    }
}