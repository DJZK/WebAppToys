namespace Messenger
{
    partial class MainForm
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
            this.MessengerBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.MessengerBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // MessengerBrowser
            // 
            this.MessengerBrowser.CreationProperties = null;
            this.MessengerBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MessengerBrowser.Location = new System.Drawing.Point(0, -1);
            this.MessengerBrowser.Name = "MessengerBrowser";
            this.MessengerBrowser.Size = new System.Drawing.Size(697, 419);
            this.MessengerBrowser.TabIndex = 0;
            this.MessengerBrowser.ZoomFactor = 1D;
            this.MessengerBrowser.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.MessengerBrowser_CoreWebView2InitializationCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.MessengerBrowser);
            this.MinimumSize = new System.Drawing.Size(711, 456);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MessengerBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 MessengerBrowser;
    }
}

