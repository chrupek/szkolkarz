using System;
using System.Collections.Generic;
using System.Windows.Forms;
using szkolkarz.forms.main;

namespace szkolkarz
{
    static class Program
    {
        /// <summary>
        /// Hell starts here.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
