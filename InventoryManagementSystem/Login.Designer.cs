namespace InventoryManagementSystem
{
    partial class Login
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
            Logo = new PictureBox();
            loginButton = new Button();
            password = new TextBox();
            username = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            heading = new Label();
            rectangle = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(password);
            panel1.Controls.Add(username);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(heading);
            panel1.Controls.Add(rectangle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 561);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.WhatsApp_Image_2022_09_19_at_14_47_15_removebg_preview;
            Logo.Location = new Point(34, 187);
            Logo.Name = "Logo";
            Logo.Size = new Size(397, 179);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 20;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaptionText;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(505, 344);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(238, 22);
            loginButton.TabIndex = 19;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // password
            // 
            password.Location = new Point(505, 314);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(238, 23);
            password.TabIndex = 18;
            password.TextChanged += password_TextChanged;
            // 
            // username
            // 
            username.Location = new Point(505, 270);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(238, 23);
            username.TabIndex = 17;
            username.TextChanged += username_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.FromArgb(10, 73, 156);
            passwordLabel.ForeColor = SystemColors.ButtonHighlight;
            passwordLabel.Location = new Point(505, 296);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(10, 73, 156);
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(505, 252);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.FromArgb(10, 73, 156);
            heading.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = SystemColors.ButtonHighlight;
            heading.Location = new Point(492, 187);
            heading.Name = "heading";
            heading.Size = new Size(132, 59);
            heading.TabIndex = 14;
            heading.Text = "Login";
            heading.Click += heading_Click_1;
            // 
            // rectangle
            // 
            rectangle.BackColor = Color.Transparent;
            rectangle.BackgroundImageLayout = ImageLayout.None;
            rectangle.BorderColor = Color.FromArgb(10, 73, 156);
            rectangle.BorderThickness = 0;
            rectangle.Enabled = false;
            rectangle.FillColor = Color.FromArgb(10, 73, 156);
            rectangle.LineThickness = 1;
            rectangle.Location = new Point(375, 0);
            rectangle.Margin = new Padding(0);
            rectangle.Name = "rectangle";
            rectangle.PolygonSkip = 1;
            rectangle.Rotate = 0F;
            rectangle.RoundedRadius = 10;
            rectangle.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            rectangle.Size = new Size(824, 557);
            rectangle.TabIndex = 13;
            rectangle.Text = "Rectangle";
            rectangle.UseTransparentBackground = true;
            rectangle.Zoom = 80;
            rectangle.Click += rectangle_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(934, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo;
        private Button loginButton;
        private TextBox password;
        private TextBox username;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label heading;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes rectangle;
    }
}