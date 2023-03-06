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
            panel3 = new Panel();
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
            panel2.Location = new Point(19, 200);
            panel2.Margin = new Padding(30);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 592);
            panel2.TabIndex = 1;
            panel2.SizeChanged += panel2_SizeChanged;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
