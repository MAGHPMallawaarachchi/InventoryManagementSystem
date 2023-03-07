namespace InventoryManagementSystem.Messages
{
    partial class AddItemSuccess
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
            pictureBox1 = new PictureBox();
            lblSuccess = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnYes = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnNo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success;
            pictureBox1.Location = new Point(225, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSuccess
            // 
            lblSuccess.BackColor = Color.Transparent;
            lblSuccess.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuccess.ForeColor = Color.FromArgb(39, 174, 96);
            lblSuccess.Location = new Point(204, 107);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(107, 33);
            lblSuccess.TabIndex = 1;
            lblSuccess.Text = "SUCCESS!";
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(159, 148);
            siticoneHtmlLabel1.Margin = new Padding(3, 26, 3, 3);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(197, 27);
            siticoneHtmlLabel1.TabIndex = 2;
            siticoneHtmlLabel1.Text = "Item added successfully!";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(110, 172);
            siticoneHtmlLabel2.Margin = new Padding(3, 26, 3, 3);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(294, 27);
            siticoneHtmlLabel2.TabIndex = 3;
            siticoneHtmlLabel2.Text = "Would you like to add another item?";
            // 
            // btnYes
            // 
            btnYes.BorderColor = Color.FromArgb(39, 174, 96);
            btnYes.BorderRadius = 4;
            btnYes.BorderThickness = 2;
            btnYes.DisabledState.BorderColor = Color.DarkGray;
            btnYes.DisabledState.CustomBorderColor = Color.DarkGray;
            btnYes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnYes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnYes.FillColor = Color.FromArgb(39, 174, 96);
            btnYes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.ForeColor = Color.White;
            btnYes.ImageOffset = new Point(0, 1);
            btnYes.ImageSize = new Size(15, 10);
            btnYes.Location = new Point(266, 218);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(102, 40);
            btnYes.TabIndex = 43;
            btnYes.Text = "Yes";
            btnYes.TextOffset = new Point(2, 0);
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BorderColor = Color.FromArgb(208, 211, 217);
            btnNo.BorderRadius = 4;
            btnNo.BorderThickness = 2;
            btnNo.DisabledState.BorderColor = Color.DarkGray;
            btnNo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNo.FillColor = Color.White;
            btnNo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.ForeColor = Color.FromArgb(93, 102, 121);
            btnNo.ImageOffset = new Point(0, 1);
            btnNo.ImageSize = new Size(15, 10);
            btnNo.Location = new Point(146, 218);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(102, 40);
            btnNo.TabIndex = 42;
            btnNo.Text = "No";
            btnNo.TextOffset = new Point(2, 0);
            btnNo.Click += btnNo_Click;
            // 
            // AddItemSuccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(515, 295);
            ControlBox = false;
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(lblSuccess);
            Controls.Add(pictureBox1);
            Name = "AddItemSuccess";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblSuccess;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnYes;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNo;
    }
}