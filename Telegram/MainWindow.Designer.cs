namespace Telegram
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TelegramBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ExitMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramBrowser)).BeginInit();
            this.ExitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TelegramBrowser
            // 
            this.TelegramBrowser.CreationProperties = null;
            this.TelegramBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.TelegramBrowser.Location = new System.Drawing.Point(-1, -1);
            this.TelegramBrowser.Name = "TelegramBrowser";
            this.TelegramBrowser.Size = new System.Drawing.Size(812, 505);
            this.TelegramBrowser.TabIndex = 1;
            this.TelegramBrowser.ZoomFactor = 1D;
            this.TelegramBrowser.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.TelegramBrowser_CoreWebView2InitializationCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Telegram is running on background. Double click here to reopen.";
            this.notifyIcon1.BalloonTipTitle = "Minimized";
            this.notifyIcon1.ContextMenuStrip = this.ExitMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Telegram";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitApplication});
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(94, 26);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(93, 22);
            this.ExitApplication.Text = "Exit";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 502);
            this.Controls.Add(this.TelegramBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(284, 439);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TelegramBrowser)).EndInit();
            this.ExitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 TelegramBrowser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
    }
}

