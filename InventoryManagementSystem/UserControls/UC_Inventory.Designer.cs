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
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.White;
            siticonePanel1.BorderColor = Color.White;
            siticonePanel1.BorderRadius = 8;
            siticonePanel1.BorderThickness = 10;
            siticonePanel1.Dock = DockStyle.Top;
            siticonePanel1.Location = new Point(19, 19);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1101, 160);
            siticonePanel1.TabIndex = 0;
            siticonePanel1.Paint += siticonePanel1_Paint;
            // 
            // siticonePanel2
            // 
            siticonePanel2.BackColor = Color.White;
            siticonePanel2.BorderColor = Color.White;
            siticonePanel2.BorderRadius = 8;
            siticonePanel2.BorderThickness = 10;
            siticonePanel2.Dock = DockStyle.Bottom;
            siticonePanel2.Location = new Point(19, 203);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.Size = new Size(1101, 589);
            siticonePanel2.TabIndex = 1;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 241, 243);
            Controls.Add(siticonePanel2);
            Controls.Add(siticonePanel1);
            Name = "UC_Inventory";
            Padding = new Padding(19, 19, 22, 22);
            Size = new Size(1142, 814);
            Load += UC_Inventory_Load;
            SizeChanged += UC_Inventory_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
    }
}
