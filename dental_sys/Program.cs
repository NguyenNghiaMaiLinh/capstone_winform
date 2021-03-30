﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fLogin = new LoginPage();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Loading());
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new Principal());
        }
    }
}
