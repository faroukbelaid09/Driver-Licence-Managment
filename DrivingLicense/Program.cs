using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicense
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool shouldExit = false;

            while (!shouldExit)
            {
                using (var loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // Show main form
                        var mainForm = new mainForm();
                        Application.Run(mainForm);

                        // Check if we signed out or just closed the main form
                        shouldExit = !mainForm.SignedOut;
                    }
                    else
                    {
                        shouldExit = true;
                    }
                }
            }
        }
    }
}
