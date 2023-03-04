namespace InventoryManagementSystem
{
    partial class LoginError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginError));
            error = new Label();
            LoginFailed = new Label();
            pictureBox1 = new PictureBox();
            retryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // error
            // 
            error.AutoSize = true;
            error.Location = new Point(53, 81);
            error.Name = "error";
            error.Size = new Size(240, 15);
            error.TabIndex = 0;
            error.Text = "Your username and password do not match.";
            error.Click += label1_Click;
            // 
            // LoginFailed
            // 
            LoginFailed.AutoSize = true;
            LoginFailed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginFailed.Location = new Point(133, 59);
            LoginFailed.Name = "LoginFailed";
            LoginFailed.Size = new Size(76, 15);
            LoginFailed.TabIndex = 1;
            LoginFailed.Text = "Login Failed!";
            LoginFailed.TextAlign = ContentAlignment.MiddleCenter;
            LoginFailed.Click += LoginFailed_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.error_icon_25243;
            pictureBox1.Location = new Point(154, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // retryButton
            // 
            retryButton.FlatStyle = FlatStyle.System;
            retryButton.Location = new Point(133, 105);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(76, 29);
            retryButton.TabIndex = 4;
            retryButton.Text = "Retry";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += retryButton_Click;
            // 
            // LoginError
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(345, 151);
            Controls.Add(retryButton);
            Controls.Add(pictureBox1);
            Controls.Add(LoginFailed);
            Controls.Add(error);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginError";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginError_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label error;
        private Label LoginFailed;
        private PictureBox pictureBox1;
        private Button retryButton;
    }
}