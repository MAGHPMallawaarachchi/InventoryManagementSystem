﻿namespace InventoryManagementSystem.Messages
{
    partial class Success
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
            panel1 = new Panel();
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            lblSuccessMessage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            btnClose = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 167, 96);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(16, 70);
            panel1.TabIndex = 0;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.Dock = DockStyle.Left;
            siticonePictureBox1.Image = Properties.Resources.success1;
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.Location = new Point(16, 0);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(76, 70);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            siticonePictureBox1.TabIndex = 1;
            siticonePictureBox1.TabStop = false;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(56, 62, 73);
            siticoneHtmlLabel1.Location = new Point(98, 5);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(73, 30);
            siticoneHtmlLabel1.TabIndex = 2;
            siticoneHtmlLabel1.Text = "Success";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.BackColor = Color.Transparent;
            lblSuccessMessage.ForeColor = Color.FromArgb(102, 112, 133);
            lblSuccessMessage.Location = new Point(98, 32);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(113, 22);
            lblSuccessMessage.TabIndex = 3;
            lblSuccessMessage.Text = "success message";
            // 
            // btnClose
            // 
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.closeGreen;
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.ImageSize = new Size(20, 20);
            btnClose.Location = new Point(408, 25);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;
            // 
            // Success
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 247, 240);
            ClientSize = new Size(440, 70);
            Controls.Add(btnClose);
            Controls.Add(lblSuccessMessage);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(siticonePictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Success";
            Text = "Success";
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblSuccessMessage;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton btnClose;
    }
}