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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Messenger";
            Icon = Properties.Resources.Messenger;
            MessengerBrowser.Size = Size;

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
    }
}
