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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            dgvCustomers = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            lblCustomers = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.Controls.Add(dgvCustomers);
            siticonePanel1.Controls.Add(btnAddCustomer);
            siticonePanel1.Controls.Add(lblCustomers);
            siticonePanel1.Dock = DockStyle.Fill;
            siticonePanel1.Location = new Point(19, 19);
            siticonePanel1.Margin = new Padding(3, 4, 3, 4);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1101, 773);
            siticonePanel1.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.ColumnHeadersHeight = 50;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customer_id, name, address, city, contact_number });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomers.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.Location = new Point(27, 109);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 25;
            dgvCustomers.Size = new Size(1049, 639);
            dgvCustomers.TabIndex = 3;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCustomers.ThemeStyle.HeaderStyle.Height = 50;
            dgvCustomers.ThemeStyle.ReadOnly = false;
            dgvCustomers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCustomers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomers.ThemeStyle.RowsStyle.Height = 25;
            dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // customer_id
            // 
            customer_id.HeaderText = "Customer ID";
            customer_id.MinimumWidth = 6;
            customer_id.Name = "customer_id";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // address
            // 
            address.HeaderText = "Adress";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // city
            // 
            city.HeaderText = "City";
            city.MinimumWidth = 6;
            city.Name = "city";
            // 
            // contact_number
            // 
            contact_number.HeaderText = "Contact Number";
            contact_number.MinimumWidth = 6;
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
            btnAddCustomer.Location = new Point(934, 39);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(126, 40);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextOffset = new Point(2, 0);
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblCustomers
            // 
            lblCustomers.BackColor = Color.Transparent;
            lblCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(45, 48);
            lblCustomers.Margin = new Padding(3, 4, 3, 4);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(100, 30);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(siticonePanel1);
            Name = "UC_Customers";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1142, 813);
            Load += UC_Customers_Load;
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomers;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCustomers;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact_number;
    }
}
