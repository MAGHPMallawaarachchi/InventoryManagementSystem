using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void heading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rectangle_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string connectionString = "mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.8.0";
            string databaseName = "InventoryManagementSystem";
            string collectionName = "admin";

            // Get the MongoDB client
            MongoClient client = new MongoClient(connectionString);

            // Get the database and collection objects
            IMongoDatabase db = client.GetDatabase(databaseName);
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);

            // Get the username and password entered by the user
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Build the query to find a matching user
            var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", password);

            // Execute the query and check if a matching user is found
            var user = collection.Find(filter).FirstOrDefault();
            if (user != null)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                SystemSounds.Exclamation.Play();

                LoginError loginError = new LoginError();
                loginError.Show();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
        }

        private void heading_Click_1(object sender, EventArgs e)
        {
        }

        private void Logo_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }
    }
}
