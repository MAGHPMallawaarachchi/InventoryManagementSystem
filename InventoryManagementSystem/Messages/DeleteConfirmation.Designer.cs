namespace InventoryManagementSystem.Messages
{
    partial class DeleteConfirmation
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
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblSuccessMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            btnCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.Image = Properties.Resources.deleteConfirmation;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(150, 25);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(59, 55);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.TabStop = false;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(56, 62, 73);
            siticoneHtmlLabel1.Location = new Point(111, 81);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(128, 30);
            siticoneHtmlLabel1.TabIndex = 3;
            siticoneHtmlLabel1.Text = "Are you sure?";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.BackColor = Color.Transparent;
            lblSuccessMessage.ForeColor = Color.FromArgb(102, 112, 133);
            lblSuccessMessage.Location = new Point(30, 119);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(291, 22);
            lblSuccessMessage.TabIndex = 4;
            lblSuccessMessage.Text = "Deleting will permanently remove this from \r\n\r\n";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.ForeColor = Color.FromArgb(102, 112, 133);
            siticoneHtmlLabel2.Location = new Point(58, 138);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(234, 22);
            siticoneHtmlLabel2.TabIndex = 5;
            siticoneHtmlLabel2.Text = "\r\nthe system. This cannot be undone!";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BorderColor = Color.FromArgb(218, 62, 51);
            btnDelete.BorderRadius = 4;
            btnDelete.BorderThickness = 2;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(218, 62, 51);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageOffset = new Point(0, 1);
            btnDelete.ImageSize = new Size(15, 15);
            btnDelete.Location = new Point(183, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.TextOffset = new Point(2, 0);
            btnDelete.Click += btnDelete_Click;
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
            btnCancel.Location = new Point(74, 177);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.TextOffset = new Point(2, 0);
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 250);
            ControlBox = false;
            Controls.Add(lblSuccessMessage);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticonePictureBox1);
            Name = "DeleteConfirmation";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblSuccessMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCancel;
    }
}