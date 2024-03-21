using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace sudoku
{
    internal class LoadingDialog : Form
    {
        private ProgressBar loadingProgressBar;

        public LoadingDialog()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 20);

            loadingProgressBar = new ProgressBar();
            loadingProgressBar.Style = ProgressBarStyle.Marquee;
            loadingProgressBar.Dock = DockStyle.Fill;

            this.Controls.Add(loadingProgressBar);
        }

        // Method to show the dialog asynchronously in a separate thread
        public void ShowDialogAsync()
        {
            // Create and start a new thread for the loading dialog
            Thread thread = new Thread(new ThreadStart(() =>
            {
                Application.Run(this); // Start the dialog on this thread
            }));

            thread.IsBackground = true; // Set the thread as background so it will automatically close when the application exits
            thread.Start();
        }

        public void CloseDialog()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.Close()));
            }
            else
            {
                this.Close();
            }
        }
    }
}