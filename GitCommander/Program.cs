using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace GitCommander
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string this_process_name = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(this_process_name);
            int num_of_processes = processes.Length;
            if (num_of_processes > 1) { Application.Exit(); }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
