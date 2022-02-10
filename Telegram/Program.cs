using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Telegram
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            using (var mutex = new Mutex(false, "Telegram"))
            {
                // TimeSpan.Zero to test the mutex's signal state and
                // return immediately without blocking
                bool isAnotherInstanceOpen = !mutex.WaitOne(TimeSpan.Zero);
                if (isAnotherInstanceOpen)
                {
                    MessageBox.Show("Application already running! Check system tray", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // main application entry point
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
        
                mutex.ReleaseMutex();
            }


        }
    }
}
