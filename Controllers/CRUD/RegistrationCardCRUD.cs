using PisFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PisFirst.Controllers.CRUD
{
    /// <summary>
    /// Класс для
    /// </summary>
    internal static class RegistrationCardCRUD
    {
        /// <summary>
        /// Чтение данных из таблицы RegistrationCard
        /// </summary>
        /// <returns>Данные из БД</returns>
        public static List<string[]> ReadData()
        {
            var context = new TestDbContext();

            var cards = context.RegistrationCard.ToList();

            List<string[]> records = new List<string[]>();

            foreach (var card in cards)
            {
                string[] record = new string[13]
                {
                    card.rc_id.ToString(),
                    card.rc_application_date.ToString(),
                    card.rc_animal_habitat.ToString(),
                    card.rc_capture_reason.ToString(),
                    card.rc_signing_date.ToString(),
                    card.rc_signature.ToString(),
                    card.u_id.ToString(),
                    card.om_id.ToString(),
                    card.or_id.ToString(),
                    card.ut_id.ToString(),
                    card.anc_id.ToString(),
                    card.apc_id.ToString(),
                    card.as_id.ToString()
                };

                records.Add(record);
            }

            return records;
        }

        /// <summary>
        /// Добавление данных в таблицу RegistrationCard
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public static void CreateRecord()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Изменение данных в таблице RegistrationCard
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public static void UpdateRecord()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удаление данных в таблице RegistrationCard
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public static void DeleteRecord()
        {
            throw new NotImplementedException();
        }
    }
}
