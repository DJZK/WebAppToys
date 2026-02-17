using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techpos
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = "Techpos";
            Icon = Properties.Resources.Techpos;
            TechposBrowser.Size = Size;

            TechposBrowser.Width = Width - 15;
            TechposBrowser.Height = Height - 35;
            TechposBrowser.Source = new Uri("http://192.168.111.208:8091");
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            TechposBrowser.Width = Width - 15;
            TechposBrowser.Height = Height - 35;
        }

        private void TechposBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            TechposBrowser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            TechposBrowser.CoreWebView2.IsMuted = false;
            TechposBrowser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            TechposBrowser.ZoomFactor = 0.9; 
        }
    }
}
