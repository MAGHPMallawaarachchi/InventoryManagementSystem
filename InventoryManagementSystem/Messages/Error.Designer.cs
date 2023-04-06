namespace InventoryManagementSystem.Messages
{
    partial class Error
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
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            lblErrorMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticoneButton1
            // 
            siticoneButton1.BorderColor = Color.FromArgb(186, 186, 187);
            siticoneButton1.Cursor = Cursors.Hand;
            siticoneButton1.CustomBorderColor = Color.FromArgb(186, 186, 187);
            siticoneButton1.CustomBorderThickness = new Padding(1, 0, 0, 0);
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.Dock = DockStyle.Right;
            siticoneButton1.FillColor = Color.White;
            siticoneButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.FromArgb(186, 186, 187);
            siticoneButton1.Location = new Point(425, 0);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(97, 70);
            siticoneButton1.TabIndex = 9;
            siticoneButton1.Text = "CLOSE";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.BackColor = Color.Transparent;
            lblErrorMessage.ForeColor = Color.FromArgb(102, 112, 133);
            lblErrorMessage.Location = new Point(98, 32);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(97, 22);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.Text = "Error message";
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(56, 62, 73);
            siticoneHtmlLabel1.Location = new Point(98, 5);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(46, 30);
            siticoneHtmlLabel1.TabIndex = 7;
            siticoneHtmlLabel1.Text = "Error";
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.Dock = DockStyle.Left;
            siticonePictureBox1.Image = Properties.Resources.error;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(16, 0);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(76, 70);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox1.TabIndex = 6;
            siticonePictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 62, 51);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(16, 70);
            panel1.TabIndex = 5;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 70);
            Controls.Add(siticoneButton1);
            Controls.Add(lblErrorMessage);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticonePictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Error";
            Text = "Error";
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblErrorMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Panel panel1;
    }
}