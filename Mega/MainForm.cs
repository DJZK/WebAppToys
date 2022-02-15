using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega
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
            Text = "Mega Browser";
            Icon = Properties.Resources.mega;
            MegaBrowser.Size = Size;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Visible = true;

            MegaBrowser.Width = Width - 15;
            MegaBrowser.Height = Height - 35;
            MegaBrowser.Source = new Uri("https://mega.io");

        }

        private void MegaBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            MegaBrowser.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            MegaBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            MegaBrowser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            MegaBrowser.CoreWebView2.Settings.IsStatusBarEnabled = false;

            MegaBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bypass = true;
            Application.Exit();
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = windowState;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MegaBrowser.Width = Width - 15;
            MegaBrowser.Height = Height - 35;
        }
    }
}
