namespace InventoryManagementSystem
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvCustomers = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            editbtn = new DataGridViewButtonColumn();
            deletebtn = new DataGridViewButtonColumn();
            lblCustomers = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
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
            dgvCustomers.Location = new Point(38, 66);
            dgvCustomers.Margin = new Padding(3, 2, 3, 2);
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
            dgvCustomers.Size = new Size(1361, 550);
            dgvCustomers.TabIndex = 25;
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
            address.HeaderText = "Address";
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
            // editbtn
            // 
            editbtn.HeaderText = "Actions";
            editbtn.Name = "editbtn";
            editbtn.Text = "Edit";
            editbtn.UseColumnTextForButtonValue = true;
            // 
            // deletebtn
            // 
            deletebtn.HeaderText = "";
            deletebtn.Name = "deletebtn";
            deletebtn.Text = "Delete";
            deletebtn.UseColumnTextForButtonValue = true;
            // 
            // lblCustomers
            // 
            lblCustomers.BackColor = Color.Transparent;
            lblCustomers.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(38, 31);
            lblCustomers.Margin = new Padding(10, 9, 3, 2);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(74, 22);
            lblCustomers.TabIndex = 26;
            lblCustomers.Text = "Customers";
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
            btnAddCustomer.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.HoverState.FillColor = Color.FromArgb(10, 73, 156);
            btnAddCustomer.ImageOffset = new Point(0, 1);
            btnAddCustomer.ImageSize = new Size(15, 10);
            btnAddCustomer.Location = new Point(1228, 31);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(122, 30);
            btnAddCustomer.TabIndex = 46;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextOffset = new Point(2, 0);
            btnAddCustomer.Visible = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddCustomer);
            Controls.Add(lblCustomers);
            Controls.Add(dgvCustomers);
            Name = "UC_Customers";
            Size = new Size(1435, 666);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCustomers;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact_number;
        private DataGridViewButtonColumn editbtn;
        private DataGridViewButtonColumn deletebtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomers;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
    }
}
