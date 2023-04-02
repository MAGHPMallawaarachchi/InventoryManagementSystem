namespace InventoryManagementSystem.UserControls
{
    partial class UC_Invoices
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblInvoices = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            dgvInvoices = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            invoice_no = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            status_check = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1599, 848);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblInvoices, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvInvoices, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.372642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.62736F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1599, 848);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInvoices
            // 
            lblInvoices.BackColor = Color.Transparent;
            lblInvoices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvoices.Location = new Point(15, 15);
            lblInvoices.Margin = new Padding(15);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(77, 30);
            lblInvoices.TabIndex = 28;
            lblInvoices.Text = "Invoices";
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AllowUserToResizeColumns = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.ColumnHeadersHeight = 50;
            dgvInvoices.Columns.AddRange(new DataGridViewColumn[] { invoice_no, customer, date, total_amount, status, status_check });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle4.Padding = new Padding(12, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle4;
            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.GridColor = Color.FromArgb(240, 241, 243);
            dgvInvoices.Location = new Point(3, 74);
            dgvInvoices.Margin = new Padding(3, 3, 30, 3);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(93, 102, 121);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(10, 93, 156);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInvoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 50;
            dgvInvoices.RowTemplate.Height = 29;
            dgvInvoices.Size = new Size(1566, 771);
            dgvInvoices.TabIndex = 27;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInvoices.ThemeStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.GridColor = Color.FromArgb(240, 241, 243);
            dgvInvoices.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInvoices.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoices.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInvoices.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.ThemeStyle.HeaderStyle.Height = 50;
            dgvInvoices.ThemeStyle.ReadOnly = false;
            dgvInvoices.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoices.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInvoices.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoices.ThemeStyle.RowsStyle.Height = 29;
            dgvInvoices.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInvoices.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoices.CellFormatting += dgvInvoices_CellFormatting;
            dgvInvoices.CellMouseDown += dgvInvoices_CellMouseDown;
            dgvInvoices.CellMouseEnter += dgvInvoices_CellMouseEnter;
            dgvInvoices.CellMouseLeave += dgvInvoices_CellMouseLeave;
            // 
            // invoice_no
            // 
            invoice_no.HeaderText = "Invoice No";
            invoice_no.MinimumWidth = 6;
            invoice_no.Name = "invoice_no";
            // 
            // customer
            // 
            customer.HeaderText = "Customer";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // total_amount
            // 
            total_amount.HeaderText = "Total Amount";
            total_amount.MinimumWidth = 6;
            total_amount.Name = "total_amount";
            // 
            // status
            // 
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(225, 145, 51);
            status.DefaultCellStyle = dataGridViewCellStyle3;
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // status_check
            // 
            status_check.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status_check.HeaderText = "";
            status_check.Image = Properties.Resources.threeDots;
            status_check.MinimumWidth = 6;
            status_check.Name = "status_check";
            // 
            // UC_Invoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Invoices";
            Padding = new Padding(19, 19, 22, 21);
            Size = new Size(1640, 888);
            Load += UC_Invoices_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvInvoices;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblInvoices;
        private DataGridViewTextBoxColumn invoice_no;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn status_check;
    }
}
