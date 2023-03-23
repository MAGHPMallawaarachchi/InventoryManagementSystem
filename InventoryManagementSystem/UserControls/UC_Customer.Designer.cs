namespace InventoryManagementSystem.UserControls
{
    partial class UC_Customer
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
            lblCustomer = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            dgvCustomers = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            editbtn = new DataGridViewButtonColumn();
            deletebtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.BackColor = Color.Transparent;
            lblCustomer.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomer.Location = new Point(39, 49);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(127, 31);
            lblCustomer.TabIndex = 10;
            lblCustomer.Text = "Customers";
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
            btnAddCustomer.Location = new Point(891, 40);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(139, 40);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextOffset = new Point(2, 0);
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeight = 50;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customer_id, name, address, city, contact_number, editbtn, deletebtn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.GridColor = Color.FromArgb(240, 241, 243);
            dgvCustomers.Location = new Point(39, 105);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 50;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.Size = new Size(1032, 668);
            dgvCustomers.TabIndex = 8;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvCustomers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.ThemeStyle.HeaderStyle.Height = 50;
            dgvCustomers.ThemeStyle.ReadOnly = false;
            dgvCustomers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCustomers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomers.ThemeStyle.RowsStyle.Height = 29;
            dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClickAsync;
            // 
            // customer_id
            // 
            customer_id.DataPropertyName = "customer_id";
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
            address.HeaderText = "Address";
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
            // editbtn
            // 
            editbtn.HeaderText = "Actions";
            editbtn.MinimumWidth = 6;
            editbtn.Name = "editbtn";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            // 
            // deletebtn
            // 
            deletebtn.HeaderText = "";
            deletebtn.MinimumWidth = 6;
            deletebtn.Name = "deletebtn";
            deletebtn.Text = "Delete";
            deletebtn.UseColumnTextForButtonValue = true;
            // 
            // UC_Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCustomers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Customer";
            Size = new Size(1143, 813);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCustomers;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact_number;
        private DataGridViewButtonColumn editbtn;
        private DataGridViewButtonColumn deletebtn;
    }
}
