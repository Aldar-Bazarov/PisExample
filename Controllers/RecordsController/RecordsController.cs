using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PisFirst.Models;
using PisFirst.Utils;

namespace PisFirst.Controllers.RecordsController
{
    internal static class RecordsController
    {
        public static void CreateRecord(string[] values)
        {
            using (var context = new TestDbModel())
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
            using (var context = new TestDbModel())
            {
                comboBoxes[0].ValueMember = "om_id";
                comboBoxes[0].DisplayMember = "om_name";
                comboBoxes[0].DataSource = context.Omsu.ToList();
                comboBoxes[0].SelectedIndex = -1;
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
                // MessageBox.Show(filter.RegCardID.ToString());
                records = context.RegistrationCard
                    .Where(n => n.rc_application_date >= filter.MinRecordDate &&
                                n.rc_application_date <= filter.MaxRecordDate);

                if (filter.RegCardID != 0)
                    records = records
                        .Where(n => n.rc_id == filter.RegCardID);
                if (filter.ApplicantCategoryID != 0)
                    records = records
                        .Where(n => n.ApplicantCategory.apc_id == filter.ApplicantCategoryID);

                if (filter.MunDistrID != 0) records = records.Where(n => n.om_id == filter.MunDistrID);

                if (filter.UrgencyTypeID != 0) records = records.Where(n => n.u_id == filter.UrgencyTypeID);

                if (filter.OrganizationID != 0) records = records.Where(n => n.or_id == filter.OrganizationID);

                if (filter.StatusID != 0) records = records.Where(n => n.as_id == filter.StatusID);
            }


            return records.ToList();
        }

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
    }
}