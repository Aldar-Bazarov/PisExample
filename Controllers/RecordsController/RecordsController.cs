using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PisFirst.Models;
using PisFirst.Utils;

namespace PisFirst.Controllers.RecordsController
{
    /// <summary>
    /// Контроллер для взаимодействия с записями реестра
    /// </summary>
    internal static class RecordsController
    {
        /// <summary>
        /// Получить одну запись
        /// </summary>
        /// <param name="id"> id записи </param>
        /// <returns> Учётную карточку реестра </returns>
        public static RegistrationCard GetOneRecord(int id)
        {
            using (var context = new TestDbModel())
            {
                var record = context.RegistrationCard.FirstOrDefault(card => card.rc_id == id);

                return record;
            }
        }

        /// <summary>
        /// Создать запись в базе данных
        /// </summary>
        /// <param name="values"> Значения для заполнения </param>
        public static void CreateRecord(string[] values)
        {
            using (var context = new TestDbModel())
            {
                var newCard = new RegistrationCard();
                newCard.rc_application_date = Convert.ToDateTime(values[0]);
                newCard.rc_animal_habitat = values[1];
                newCard.rc_capture_reason = values[2];
                newCard.u_id = Convert.ToInt32(values[3]);
                newCard.om_id = Convert.ToInt32(values[4]);
                newCard.ut_id = Convert.ToInt32(values[5]);
                newCard.anc_id = Convert.ToInt32(values[6]);
                newCard.apc_id = Convert.ToInt32(values[7]);
                newCard.as_id = 1;
                newCard.as_changedate = DateTime.Now;
                newCard.rc_signature = "";

                context.RegistrationCard.Add(newCard);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Изменить запись в базе данных
        /// </summary>
        /// <param name="recordId"> ID записи </param>
        /// <param name="organizationId"> ID организации </param>
        /// <param name="captureDate"> Дата отлова </param>
        /// <param name="captureDateIsChanged"> Флаг на дату отлова </param>
        public static void UpdateRecord(int recordId, int organizationId, DateTime captureDate, bool captureDateIsChanged)
        {
            using (var context = new TestDbModel())
            {
                var targetCard = context.RegistrationCard.SingleOrDefault(card => card.rc_id == recordId);
                if (targetCard != null)
                {
                    if (captureDateIsChanged)
                    {
                        targetCard.rc_capture_date = captureDate;
                    }
                    else if (targetCard.or_id != organizationId)
                    {
                        targetCard.or_id = organizationId;
                    }
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Заполнить comboBox'ы формы учётной карточки
        /// </summary>
        /// <param name="comboBoxes"> comboBox'ы </param>
        public static void FillRecordComboBoxes(ComboBox[] comboBoxes)
        {
            using (var context = new TestDbModel())
            {
                comboBoxes[0].ValueMember = "or_id";
                comboBoxes[0].DisplayMember = "or_name";
                comboBoxes[0].DataSource = context.Organization.ToList();
                comboBoxes[1].ValueMember = "ut_id";
                comboBoxes[1].DisplayMember = "ut_name";
                comboBoxes[1].DataSource = context.UrgencyType.ToList();
                comboBoxes[2].ValueMember = "anc_id";
                comboBoxes[2].DisplayMember = "anc_name";
                comboBoxes[2].DataSource = context.AnimalCategory.ToList();
                comboBoxes[3].ValueMember = "apc_id";
                comboBoxes[3].DisplayMember = "apc_name";
                comboBoxes[3].DataSource = context.ApplicantCategory.ToList();
            }
        }

        /// <summary>
        /// Получить разрешённые записи
        /// </summary>
        /// <param name="filter"> Фильтры </param>
        /// <returns></returns>
        public static List<RegistrationCard> GetPermittedRecords(Filter filter = null)
        {
            IEnumerable<RegistrationCard> records;
            var context = new TestDbModel();
            if (filter == null)
            {
                records = context.RegistrationCard.Select(n => n).ToList();
            }
            else
            {
                records = context.RegistrationCard
                    .Where(n => n.rc_application_date >= filter.MinRecordDate &&
                                n.rc_application_date <= filter.MaxRecordDate);
                if (filter.RegCardID != 0)
                    records = records
                        .Where(n => n.rc_id == filter.RegCardID);
                if (filter.ApplicantCategoryID != 0)
                    records = records
                        .Where(n => n.ApplicantCategory.apc_id == filter.ApplicantCategoryID);
                if (filter.MunDistrID != 0) records = records.Where(n => n.Omsu.MunicipalDistrict.md_id == filter.MunDistrID);

                if (filter.UrgencyTypeID != 0) records = records.Where(n => n.ut_id == filter.UrgencyTypeID);
                if (filter.AnimalCategoryID != 0) records = records.Where(n => n.AnimalCategory.anc_id == filter.AnimalCategoryID);

                if (filter.OrganizationID != 0) records = records.Where(n => n.or_id == filter.OrganizationID);

                if (filter.StatusID != 0) records = records.Where(n => n.as_id == filter.StatusID);
            }

            return records.ToList();
        }

        /// <summary>
        /// Заполнить comboBox'ы контролла с фильтрами
        /// </summary>
        /// <param name="comboBox"> comboBox'ы </param>
        public static void GetFilterComboBoxes(ComboBox[] comboBox)
        {
            using (var context = new TestDbModel())
            {
                comboBox[0].DataSource = context.RegistrationCard.Select(n => n).ToList();
                comboBox[0].DisplayMember = "rc_id";
                comboBox[0].ValueMember = "rc_id";
                comboBox[0].SelectedIndex = -1;
                comboBox[1].DataSource = context.ApplicantCategory.Select(n => n).ToList();
                comboBox[1].DisplayMember = "apc_name";
                comboBox[1].ValueMember = "apc_id";
                comboBox[1].SelectedIndex = -1;
                comboBox[2].DataSource = context.MunicipalDistrict.Select(n => n).ToList();
                comboBox[2].DisplayMember = "md_name";
                comboBox[2].ValueMember = "md_id";
                comboBox[2].SelectedIndex = -1;
                comboBox[3].DataSource = context.AnimalCategory.Select(n => n).ToList();
                comboBox[3].DisplayMember = "anc_name";
                comboBox[3].ValueMember = "anc_id";
                comboBox[3].SelectedIndex = -1;
                comboBox[4].DataSource = context.UrgencyType.Select(n => n).ToList();
                comboBox[4].DisplayMember = "ut_name";
                comboBox[4].ValueMember = "ut_id";
                comboBox[4].SelectedIndex = -1;
                comboBox[5].DataSource = context.Organization.Select(n => n).ToList();
                comboBox[5].DisplayMember = "or_name";
                comboBox[5].ValueMember = "or_id";
                comboBox[5].SelectedIndex = -1;
                comboBox[6].DataSource = context.ApplicationStatus.Select(n => n).ToList();
                comboBox[6].DisplayMember = "as_name";
                comboBox[6].ValueMember = "as_id";
                comboBox[6].SelectedIndex = -1;
            }
        }
        public static List<StatusHistory> GetStatusHistory(int recordID)
        {
            var history = new List<StatusHistory>();
            using (var context = new TestDbModel())
            {
                history = context.StatusHistory.Where(n => n.rc_id == recordID)
                    .ToList();
            }

            return history;
        }

    }
}




