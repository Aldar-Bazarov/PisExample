using PisFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;

namespace PisFirst.Controllers.Records
{
    internal static class RecordsCRUD
    {
        public static List<string[]> ReadRecords()
        {
            using (var context = new TestDbContext())
            {
                var resultList = new List<string[]>();
             
                var records = context.RegistrationCard.ToList();
                var appUsers = context.AppUser.ToList();
                var organizations = context.Organization.ToList();
                var omsus = context.Omsu.ToList();
                var urgencyTypes = context.UrgencyType.ToList();
                var animalCategories = context.AnimalCategory.ToList();
                var applicantCategories = context.ApplicantCategory.ToList();
                var applicationStatuses = context.ApplicationStatus.ToList();

                foreach (var record in records)
                {
                    var user = appUsers.Find(appUser => appUser.u_id == record.u_id);
                    var userName = $"{user.u_first_name} {user.u_second_name}" ?? "Имя не задано";
                    var organizationName = organizations.Find((organization) => organization.or_id == record.or_id)?.or_name.ToString() ?? String.Empty;
                    var omsuName = omsus.Find((omsu) => omsu.om_id == record.om_id)?.om_name.ToString() ?? String.Empty;
                    var urgencyTypeName = urgencyTypes.Find((urgencyType) => urgencyType.ut_id == record.ut_id)?.ut_name.ToString() ?? String.Empty;
                    var animalCategoryName = animalCategories.Find((animalCategory) => animalCategory.anc_id == record.anc_id)?.anc_name.ToString() ?? String.Empty;
                    var applicantCategoryName = applicantCategories.Find((applicantCategory) => applicantCategory.apc_id == record.apc_id)?.apc_name.ToString() ?? String.Empty;
                    var applicationStatusName = applicationStatuses.Find((applicationStatus) => applicationStatus.as_id == record.as_id)?.as_name.ToString() ?? String.Empty;

                    resultList.Add(new string[]
                    {
                        record.rc_id.ToString(),
                        record.rc_application_date.ToString(),
                        record.rc_animal_habitat.ToString(),
                        record.rc_capture_reason.ToString(),
                        record.rc_signing_date.ToString(),
                        record.rc_signature.ToString(),
                        userName,
                        organizationName,
                        omsuName,
                        urgencyTypeName,
                        animalCategoryName,
                        applicantCategoryName,
                        applicationStatusName
                    });
                }

                return resultList;
            }
        }

        public static void CreateRecord(string[] values)
        {
            using (var context = new TestDbContext())
            {

                var newCard = new RegistrationCard()
                {
                    rc_application_date = Convert.ToDateTime(values[0]), // доделать
                    rc_animal_habitat = values[1],
                    rc_capture_reason = values[2],
                    rc_signing_date = Convert.ToDateTime(values[3]), // доделать
                    rc_signature = values[4],
                    u_id = 1, // доделать
                    om_id = Convert.ToInt32(values[5]),
                    or_id = Convert.ToInt32(values[6]),
                    ut_id = Convert.ToInt32(values[7]),
                    anc_id = Convert.ToInt32(values[8]),
                    apc_id = Convert.ToInt32(values[9]),
                    as_id = 1
                };

                context.RegistrationCard.Add(newCard);

                context.SaveChanges();
            }
        }

        public static void UpdateRecord()
        {

        }

        public static void FillComboBoxes(ComboBox[] comboBoxes)
        {
            using (var context = new TestDbContext())
            {
                comboBoxes[0].ValueMember = "om_id";
                comboBoxes[0].DisplayMember = "om_name";
                comboBoxes[0].DataSource = context.Omsu.ToList();

                comboBoxes[1].ValueMember = "or_id";
                comboBoxes[1].DisplayMember = "or_name";
                comboBoxes[1].DataSource = context.Organization.ToList();

                comboBoxes[2].ValueMember = "ut_id";
                comboBoxes[2].DisplayMember = "ut_name";
                comboBoxes[2].DataSource = context.UrgencyType.ToList();

                comboBoxes[3].ValueMember = "anc_id";
                comboBoxes[3].DisplayMember = "anc_name";
                comboBoxes[3].DataSource = context.AnimalCategory.ToList();

                comboBoxes[4].ValueMember = "apc_id";
                comboBoxes[4].DisplayMember = "apc_name";
                comboBoxes[4].DataSource = context.ApplicantCategory.ToList();
            }
        }
    }
}
