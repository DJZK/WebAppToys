using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram
{
    public partial class MainWindow : Form
    {

        private bool bypass;
        private bool first = true;
        private FormWindowState windowState;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = "Telegram";
            Icon = Properties.Resources.Telegram ;
            TelegramBrowser.Size = Size;

            TelegramBrowser.Width = Width - 15;
            TelegramBrowser.Height = Height - 35;
            TelegramBrowser.Source = new Uri("https://web.telegram.org/");

        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            TelegramBrowser.Width = Width - 15;
            TelegramBrowser.Height = Height - 35;
        }

        private void TelegramBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            TelegramBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            TelegramBrowser.CoreWebView2.IsMuted = false;
            TelegramBrowser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            TelegramBrowser.ZoomFactor = 0.9;
            TelegramBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }
        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri);
            e.Handled = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
        
            Show();
            WindowState = windowState;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            bypass = true;
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
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
