namespace InventoryManagementSystem.Messages
{
    partial class LogoutConfirmation
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
            lblSuccessMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnLogout = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.BackColor = Color.Transparent;
            lblSuccessMessage.ForeColor = Color.FromArgb(102, 112, 133);
            lblSuccessMessage.Location = new Point(62, 132);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(226, 22);
            lblSuccessMessage.TabIndex = 46;
            lblSuccessMessage.Text = "Are you sure you want to log out?";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BorderColor = Color.FromArgb(218, 62, 51);
            btnLogout.BorderRadius = 4;
            btnLogout.BorderThickness = 2;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.FromArgb(218, 62, 51);
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageOffset = new Point(0, 1);
            btnLogout.ImageSize = new Size(15, 15);
            btnLogout.Location = new Point(183, 184);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 35);
            btnLogout.TabIndex = 49;
            btnLogout.Text = "Logout";
            btnLogout.TextOffset = new Point(2, 0);
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BorderColor = Color.FromArgb(208, 211, 217);
            btnCancel.BorderRadius = 4;
            btnCancel.BorderThickness = 2;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(93, 102, 121);
            btnCancel.HoverState.BorderColor = Color.FromArgb(93, 102, 121);
            btnCancel.HoverState.ForeColor = Color.FromArgb(93, 102, 121);
            btnCancel.ImageOffset = new Point(0, 1);
            btnCancel.ImageSize = new Size(15, 10);
            btnCancel.Location = new Point(74, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Cancel";
            btnCancel.TextOffset = new Point(2, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(56, 62, 73);
            siticoneHtmlLabel1.Location = new Point(98, 94);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(154, 30);
            siticoneHtmlLabel1.TabIndex = 45;
            siticoneHtmlLabel1.Text = "Are you leaving?";
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.Image = Properties.Resources.logoutConfirmation;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(146, 32);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(59, 55);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox1.TabIndex = 44;
            siticonePictureBox1.TabStop = false;
            // 
            // LogoutConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 250);
            ControlBox = false;
            Controls.Add(lblSuccessMessage);
            Controls.Add(btnLogout);
            Controls.Add(btnCancel);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticonePictureBox1);
            Name = "LogoutConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblSuccessMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogout;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}