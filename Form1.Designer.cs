namespace inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            password = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            logo = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkBlue;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(password);
            flowLayoutPanel1.Controls.Add(textBox4);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(515, 35);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(479, 455);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 70);
            label1.Name = "label1";
            label1.Size = new Size(247, 77);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.Cursor = Cursors.Cross;
            password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Snow;
            password.Location = new Point(27, 242);
            password.Name = "password";
            password.Size = new Size(161, 35);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(29, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 23);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(379, 23);
            textBox4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 164);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.Image = Properties.Resources.WhatsApp_Image_2022_09_19_at_14_47_15_removebg_preview;
            logo.Location = new Point(63, 201);
            logo.Margin = new Padding(4, 3, 3, 3);
            logo.Name = "logo";
            logo.Size = new Size(363, 164);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(955, 884);
            Controls.Add(logo);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label password;
        private TextBox textBox4;
        private Label label2;
        internal PictureBox logo;
        private PictureBox pictureBox1;
    }
}