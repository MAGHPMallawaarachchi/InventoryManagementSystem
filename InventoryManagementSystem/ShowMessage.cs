using InventoryManagementSystem.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace InventoryManagementSystem
{
    internal class ShowMessage
    {
        public void ShowSuccessMessage(string Message, Form parentForm)
        {
            Success success = new Success(Message);

            success.StartPosition = FormStartPosition.Manual;
            success.Location = new Point(parentForm.Location.X + (parentForm.Width - success.Width)/2, parentForm.Location.Y + 10);

            // Set opacity and animation
            success.Opacity = 0;
            success.Show();
            for (double i = 0; i <= 1; i += 0.05)
            {
                success.Opacity = i;
                success.Refresh();
                Thread.Sleep(10);
            }

            // Hide message after 5 seconds
            Timer timer = new Timer();
            timer.Interval = 5000; // 5000 milliseconds = 5 seconds
            timer.Tick += (s, args) =>
            {
                if (!success.IsDisposed && success.Visible)
                {
                    for (double i = 1; i >= 0; i -= 0.05)
                    {
                        success.Opacity = i;
                        success.Refresh();
                        Thread.Sleep(10);
                    }
                    success.Close();
                    timer.Stop();
                }
            };
            timer.Start();
        }

        public void ShowErrorMessage(string Message, Form parentForm)
        {
            Error error = new Error(Message);

            error.StartPosition = FormStartPosition.Manual;
            error.Location = new Point(parentForm.Location.X + (parentForm.Width - error.Width) / 2, parentForm.Location.Y + 10);

            // Set opacity and animation
            error.Opacity = 0;
            error.Show();
            for (double i = 0; i <= 1; i += 0.05)
            {
                error.Opacity = i;
                error.Refresh();
                Thread.Sleep(10);
            }

            // Hide message after 5 seconds
            Timer timer = new Timer();
            timer.Interval = 5000; // 5000 milliseconds = 5 seconds
            timer.Tick += (s, args) =>
            {
                if (!error.IsDisposed && error.Visible)
                {
                    for (double i = 1; i >= 0; i -= 0.05)
                    {
                        error.Opacity = i;
                        error.Refresh();
                        Thread.Sleep(10);
                    }
                    error.Close();
                    timer.Stop();
                }
            };
            timer.Start();
        }
    }
}
