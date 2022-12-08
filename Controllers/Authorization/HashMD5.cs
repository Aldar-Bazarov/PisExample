using System;
using System.Text;
using System.Security.Cryptography;

namespace PisFirst.Controllers.Authorization
{
    /// <summary>
    /// Класс с алгоритмом хэширования пароля
    /// </summary>
    internal static class HashMD5
    {
        /// <summary>
        /// Метод для хэширования пароля
        /// </summary>
        /// <param name="password">Исходный пароль</param>
        /// <returns>Хэш-функцию пароля</returns>
        public static string HashPassword(string password)
        {
            var algorithm = MD5.Create();

            var bytes = Encoding.ASCII.GetBytes(password);

            var hash = algorithm.ComputeHash(bytes);

            var hashFunction = new StringBuilder();

            foreach (var a in hash)
            {
                hashFunction.Append(a.ToString("X2"));
            }

            return Convert.ToString(hashFunction);
        }
    }
}
