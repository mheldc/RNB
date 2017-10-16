using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using BNRLibrary;

namespace CAReserveSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Length > 1)
            {
                Logging.Activity("Launching of another instance of the application is not permitted.");
                MessageBox.Show("There is already an instance of the software running.", "Multiple Instance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            } else
            {
                Logging.Activity("Preparing the system...");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Logging.Activity("Loading sign in screen to user.");
                Application.Run(new mdiCAMain());            }
        }
    }
}
