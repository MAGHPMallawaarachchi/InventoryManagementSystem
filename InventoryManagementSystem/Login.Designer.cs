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
            loginButton = new Button();
            textBox1 = new TextBox();
            passwordLabel = new Label();
            username = new TextBox();
            usernameLabel = new Label();
            heading = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 73, 156);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(username);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(heading);
            panel1.Location = new Point(483, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 443);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Black;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(57, 299);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(260, 30);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = SystemColors.ButtonHighlight;
            passwordLabel.Location = new Point(57, 234);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // username
            // 
            username.Location = new Point(57, 194);
            username.Name = "username";
            username.Size = new Size(260, 27);
            username.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(57, 171);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += label1_Click;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = SystemColors.ButtonHighlight;
            heading.Location = new Point(41, 98);
            heading.Name = "heading";
            heading.Size = new Size(164, 73);
            heading.TabIndex = 0;
            heading.Text = "Login";
            heading.Click += heading_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2022_09_19_at_14_471;
            pictureBox1.Location = new Point(30, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 530);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label heading;
        private Label usernameLabel;
        private Button loginButton;
        private TextBox textBox1;
        private Label passwordLabel;
        private TextBox username;
        private PictureBox pictureBox1;
    }
}