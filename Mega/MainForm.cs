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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Mega Browser";
            Icon = Properties.Resources.mega;
            MegaBrowser.Size = Size;

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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MegaBrowser.Width = Width - 15;
            MegaBrowser.Height = Height - 35;
        }
    }
}
