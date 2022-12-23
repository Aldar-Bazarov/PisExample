﻿using System.Linq;
using System.Windows.Forms;
using PisFirst.Controllers.Authorization;
using PisFirst.Models;
using PisFirst.Utils;

namespace PisFirst.Controllers.AuthorizationController
{
    /// <summary>
    /// Контролллер авторизации пользователя
    /// </summary>
    internal static class UserController
    {
        /// <summary>
        /// Метод авторизации пользователя в системе
        /// </summary>
        /// <param name="login">Введённый логин</param>
        /// <param name="password">Введённый пароль</param>
        /// <returns>Если пользователь авторизован возвращается true, иначе false</returns>
        public static bool Authorize(string login, string password)
        {
            var hashPassword = HashMD5.HashPassword(password);

            var context = new TestDbModel();

            var users = context.AppUser.ToList();

            var isExist = false;
            
            foreach (var user in users)
            {
                isExist = user.u_login == login && user.u_password == hashPassword;
                if (!isExist) continue;
                Program.AuthSession = new AuthSession();
                Program.AuthSession.AppUser = user;
                break;
            }
            return isExist;
        }
    }
}