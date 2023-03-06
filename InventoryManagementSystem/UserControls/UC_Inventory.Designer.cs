namespace InventoryManagementSystem
{
    partial class UC_Inventory
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnAddItem = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnFilters = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            panel3 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 159);
            panel1.TabIndex = 0;
            panel1.SizeChanged += panel1_SizeChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnAddItem);
            panel2.Controls.Add(btnFilters);
            panel2.Location = new Point(19, 200);
            panel2.Margin = new Padding(30);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(19);
            panel2.Size = new Size(1101, 592);
            panel2.TabIndex = 1;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.BorderColor = Color.FromArgb(10, 73, 156);
            btnAddItem.BorderRadius = 4;
            btnAddItem.BorderThickness = 2;
            btnAddItem.DisabledState.BorderColor = Color.DarkGray;
            btnAddItem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItem.FillColor = Color.FromArgb(10, 73, 156);
            btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.ImageOffset = new Point(0, 1);
            btnAddItem.ImageSize = new Size(15, 10);
            btnAddItem.Location = new Point(859, 22);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(102, 40);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextOffset = new Point(2, 0);
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnFilters
            // 
            btnFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilters.BorderColor = Color.FromArgb(208, 211, 217);
            btnFilters.BorderRadius = 4;
            btnFilters.BorderThickness = 2;
            btnFilters.DisabledState.BorderColor = Color.DarkGray;
            btnFilters.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilters.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilters.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilters.FillColor = Color.White;
            btnFilters.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilters.ForeColor = Color.FromArgb(93, 102, 121);
            btnFilters.Image = Properties.Resources.filters;
            btnFilters.ImageOffset = new Point(0, 1);
            btnFilters.ImageSize = new Size(15, 10);
            btnFilters.Location = new Point(977, 22);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(102, 40);
            btnFilters.TabIndex = 0;
            btnFilters.Text = "Filters";
            btnFilters.TextOffset = new Point(2, 0);
            btnFilters.Click += btnFilters_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(19, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 773);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_Inventory";
            Padding = new Padding(19, 19, 22, 22);
            Size = new Size(1142, 814);
            Load += UC_Inventory_Load;
            SizeChanged += UC_Inventory_SizeChanged;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFilters;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddItem;
    }
}
