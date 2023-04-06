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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            heading = new Label();
            rectangle = new Siticone.Desktop.UI.WinForms.SiticoneShapes();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(heading);
            panel1.Controls.Add(rectangle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 701);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vertical_Original__PVT_LTD;
            pictureBox1.Location = new Point(132, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(631, 430);
            btnLogin.Margin = new Padding(4, 2, 4, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(298, 28);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(631, 392);
            txtPassword.Margin = new Padding(4, 2, 4, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(631, 338);
            txtUsername.Margin = new Padding(4, 2, 4, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(296, 27);
            txtUsername.TabIndex = 17;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.FromArgb(10, 73, 156);
            passwordLabel.ForeColor = SystemColors.ButtonHighlight;
            passwordLabel.Location = new Point(631, 370);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(10, 73, 156);
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(631, 315);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username";
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.FromArgb(10, 73, 156);
            heading.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = SystemColors.ButtonHighlight;
            heading.Location = new Point(615, 234);
            heading.Margin = new Padding(4, 0, 4, 0);
            heading.Name = "heading";
            heading.Size = new Size(164, 73);
            heading.TabIndex = 14;
            heading.Text = "Login";
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
            rectangle.Location = new Point(469, 0);
            rectangle.Margin = new Padding(0);
            rectangle.Name = "rectangle";
            rectangle.PolygonSkip = 1;
            rectangle.Rotate = 0F;
            rectangle.RoundedRadius = 10;
            rectangle.Shape = Siticone.Desktop.UI.WinForms.Enums.ShapeType.Rounded;
            rectangle.Size = new Size(1030, 696);
            rectangle.TabIndex = 13;
            rectangle.Text = "Rectangle";
            rectangle.UseTransparentBackground = true;
            rectangle.Zoom = 80;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1168, 701);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label heading;
        private Siticone.Desktop.UI.WinForms.SiticoneShapes rectangle;
        private PictureBox pictureBox1;
    }
}