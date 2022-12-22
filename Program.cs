using PisFirst.Views;
using System;
using System.Windows.Forms;
using PisFirst.Utils;

namespace PisFirst
{
    internal static class Program
    {
        public static AuthSession AuthSession;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new AuthorizationForm());
            Application.Run(new MainForm());
        }
    }

   
}
