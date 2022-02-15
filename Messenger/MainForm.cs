using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class MainForm : Form

    {
        private bool bypass = false, first = true;
        private FormWindowState windowState;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Messenger";
            Icon = Properties.Resources.Messenger;
            MessengerBrowser.Size = Size;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Visible = true;

            MessengerBrowser.Width = Width - 15;
            MessengerBrowser.Height = Height - 35;
            MessengerBrowser.Source = new Uri("https://messenger.com");


        }

        private void MessengerBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            MessengerBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            // MessengerBrowser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            MessengerBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            {
                MessengerBrowser.Width = Width - 15;
                MessengerBrowser.Height = Height - 35;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bypass = true;
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = windowState;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bypass)
            {
                e.Cancel = true;
                windowState = this.WindowState;
                WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;

                if (first)
                {
                    notifyIcon1.ShowBalloonTip(1000);
                    first = false;
                }

            }
        }
    }
}
