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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            lblCustomers = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            dgvCustomers = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            editbtn = new DataGridViewImageColumn();
            deletebtn = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblCustomers);
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(dgvCustomers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1102, 773);
            panel1.TabIndex = 0;
            // 
            // lblCustomers
            // 
            lblCustomers.BackColor = Color.Transparent;
            lblCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomers.Location = new Point(32, 23);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(100, 30);
            lblCustomers.TabIndex = 21;
            lblCustomers.Text = "Customers";
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
            btnAddCustomer.Image = Properties.Resources.addWhite;
            btnAddCustomer.ImageSize = new Size(14, 14);
            btnAddCustomer.Location = new Point(932, 23);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(139, 40);
            btnAddCustomer.TabIndex = 12;
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
            dgvCustomers.Location = new Point(20, 105);
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
            dgvCustomers.Size = new Size(1051, 648);
            dgvCustomers.TabIndex = 11;
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
            dgvCustomers.CellMouseEnter += dgvCustomers_CellMouseEnter;
            dgvCustomers.CellMouseLeave += dgvCustomers_CellMouseLeave;
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
            editbtn.HeaderText = "";
            editbtn.Image = Properties.Resources.edit;
            editbtn.MinimumWidth = 6;
            editbtn.Name = "editbtn";
            // 
            // deletebtn
            // 
            deletebtn.HeaderText = "";
            deletebtn.Image = Properties.Resources.deleteGray;
            deletebtn.MinimumWidth = 6;
            deletebtn.Name = "deletebtn";
            deletebtn.Resizable = DataGridViewTriState.True;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Customers";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1143, 813);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvCustomers;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblCustomers;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact_number;
        private DataGridViewImageColumn editbtn;
        private DataGridViewImageColumn deletebtn;
    }
}
