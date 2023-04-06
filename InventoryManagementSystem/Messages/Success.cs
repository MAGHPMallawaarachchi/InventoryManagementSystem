using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Messages
{
    public partial class Success : Form
    {
        private System.Timers.Timer timer;

        public Success(string message)
        {
            InitializeComponent();
            lblSuccessMessage.Text = message;

            // create the timer and set its interval to 5 seconds
            timer = new System.Timers.Timer(5000);
            timer.AutoReset = false; // disable auto-repeating
            timer.Elapsed += Timer_Elapsed!;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // stop the timer and close the form
            timer.Stop();
            Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
