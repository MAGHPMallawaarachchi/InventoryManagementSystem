namespace InventoryManagementSystem.UserControls
{
    partial class UC_Customers
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
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            lblCustomers = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(siticoneDataGridView1);
            siticonePanel1.Controls.Add(btnAddCustomer);
            siticonePanel1.Controls.Add(lblCustomers);
            siticonePanel1.Dock = DockStyle.Fill;
            siticonePanel1.Location = new Point(17, 14);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(963, 580);
            siticonePanel1.TabIndex = 0;
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            siticoneDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            siticoneDataGridView1.ColumnHeadersHeight = 19;
            siticoneDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.Columns.AddRange(new DataGridViewColumn[] { customer_id, name, address, city, contact_number });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            siticoneDataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.Location = new Point(24, 82);
            siticoneDataGridView1.Name = "siticoneDataGridView1";
            siticoneDataGridView1.RowHeadersVisible = false;
            siticoneDataGridView1.RowTemplate.Height = 25;
            siticoneDataGridView1.Size = new Size(918, 479);
            siticoneDataGridView1.TabIndex = 3;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 19;
            siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // customer_id
            // 
            customer_id.HeaderText = "Customer ID";
            customer_id.Name = "customer_id";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // address
            // 
            address.HeaderText = "Adress";
            address.Name = "address";
            // 
            // city
            // 
            city.HeaderText = "City";
            city.Name = "city";
            // 
            // contact_number
            // 
            contact_number.HeaderText = "Contact Number";
            contact_number.Name = "contact_number";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnAddCustomer.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.ImageOffset = new Point(0, 1);
            btnAddCustomer.ImageSize = new Size(15, 10);
            btnAddCustomer.Location = new Point(817, 29);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(110, 30);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextOffset = new Point(2, 0);
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblCustomers
            // 
            lblCustomers.BackColor = Color.Transparent;
            lblCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(39, 36);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(81, 23);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(siticonePanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Customers";
            Padding = new Padding(17, 14, 19, 16);
            Size = new Size(999, 610);
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomers;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact_number;
    }
}
