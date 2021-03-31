using System;
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
                var loading = new Loading();

                if (loading.ShowDialog() == DialogResult.OK)
                {
                    var principal = new Principal {Customers = loading.Customers};
                    Application.Run(principal);
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new Principal());
        }
    }
}
