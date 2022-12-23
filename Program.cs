using PisFirst.Views;
using System;
using System.Windows.Forms;
using PisFirst.Utils;

namespace PisFirst
{
    internal static class Program
    {
        public static AuthSession AuthSession;
        public static UserRole role;

        /// <summary>
        /// Роли пользователей
        /// </summary>
        public enum UserRole
        {
            TrappingOperator,
            OmsuOperator,
            OtherUserRole
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
            //Application.Run(new MainForm());
        }
    }


}