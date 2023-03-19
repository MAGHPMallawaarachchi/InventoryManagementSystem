namespace InventoryManagementSystem
{
    partial class Filters
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
            cbBrand = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            btnClear = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnAddFilters = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            SuspendLayout();
            // 
            // cbBrand
            // 
            cbBrand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBrand.BackColor = Color.Transparent;
            cbBrand.BorderColor = Color.FromArgb(208, 213, 221);
            cbBrand.BorderRadius = 8;
            cbBrand.DrawMode = DrawMode.OwnerDrawFixed;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.ForeColor = Color.FromArgb(72, 80, 94);
            cbBrand.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbBrand.ItemHeight = 30;
            cbBrand.Location = new Point(192, 79);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(270, 36);
            cbBrand.TabIndex = 50;
            cbBrand.SelectedValueChanged += cbBrand_SelectedValueChanged;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderColor = Color.FromArgb(208, 213, 221);
            cbCategory.BorderRadius = 8;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(72, 80, 94);
            cbCategory.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            cbCategory.ItemHeight = 30;
            cbCategory.Location = new Point(192, 140);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(270, 36);
            cbCategory.TabIndex = 51;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BorderColor = Color.FromArgb(208, 211, 217);
            btnClear.BorderRadius = 4;
            btnClear.BorderThickness = 2;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(93, 102, 121);
            btnClear.HoverState.BorderColor = Color.FromArgb(10, 73, 156);
            btnClear.HoverState.FillColor = Color.Transparent;
            btnClear.HoverState.ForeColor = Color.FromArgb(10, 73, 156);
            btnClear.ImageOffset = new Point(0, 1);
            btnClear.ImageSize = new Size(15, 10);
            btnClear.Location = new Point(242, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 40);
            btnClear.TabIndex = 52;
            btnClear.Text = "Clear";
            btnClear.TextOffset = new Point(2, 0);
            btnClear.Click += btnClear_Click;
            // 
            // btnAddFilters
            // 
            btnAddFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddFilters.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddFilters.BorderRadius = 4;
            btnAddFilters.BorderThickness = 2;
            btnAddFilters.Cursor = Cursors.Hand;
            btnAddFilters.DisabledState.BorderColor = Color.DarkGray;
            btnAddFilters.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddFilters.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddFilters.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddFilters.FillColor = Color.FromArgb(10, 73, 156);
            btnAddFilters.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFilters.ForeColor = Color.White;
            btnAddFilters.ImageOffset = new Point(0, 1);
            btnAddFilters.ImageSize = new Size(15, 10);
            btnAddFilters.Location = new Point(360, 220);
            btnAddFilters.Name = "btnAddFilters";
            btnAddFilters.Size = new Size(102, 40);
            btnAddFilters.TabIndex = 53;
            btnAddFilters.Text = "Add Filters";
            btnAddFilters.TextOffset = new Point(2, 0);
            btnAddFilters.Click += btnAddFilters_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(56, 62, 73);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 54;
            label1.Text = "Filters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(72, 80, 94);
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 56;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(72, 80, 94);
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 55;
            label2.Text = "Brand";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FillColor = Color.White;
            btnClose.IconColor = Color.Black;
            btnClose.Location = new Point(440, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 59;
            btnClose.Click += btnClose_Click;
            // 
            // Filters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(486, 287);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddFilters);
            Controls.Add(btnClear);
            Controls.Add(cbBrand);
            Controls.Add(cbCategory);
            Name = "Filters";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Filters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbBrand;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClear;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddFilters;
        private Label label1;
        private Label label3;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox btnClose;
    }
}