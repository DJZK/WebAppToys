using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mushroom
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
            Text = "Mushroom";
            Icon = Properties.Resources.mushroom;
            MushroomBrowser.Size = Size;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Visible = true;

            MushroomBrowser.Width = Width - 15;
            MushroomBrowser.Height = Height - 35;
            MushroomBrowser.Source = new Uri("https://mushroom.gg");
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MushroomBrowser.Width = Width - 15;
            MushroomBrowser.Height = Height - 35;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = windowState;
        }

        private void MushroomBrowser_CoreWebView2InitializationCompleted_1(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            MushroomBrowser.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;
            MushroomBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            MushroomBrowser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            MushroomBrowser.CoreWebView2.Settings.IsStatusBarEnabled = false;

            MushroomBrowser.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void exiitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bypass = true;
            Application.Exit();

        }


    }
}
