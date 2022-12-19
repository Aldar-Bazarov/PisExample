using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using PisFirst.Models;

namespace PisFirst.Controllers.ExportToolsController
{
    internal static class ExportToolsController
    {
        static TestDbModel context = new TestDbModel();
        public static void ExportExcelRegistryRecords(params string[] filters)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            sfd.FileName = "ExportedRegistry";
            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK) return;
            var path = Path.GetFullPath(sfd.FileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var sheet = package.Workbook.Worksheets.Add("Лист 1");
                var columnsList = new RegistrationCard().GetType().GetProperties();
                sheet.Cells[1, 1].Value = "Дата подачи заявки";

                sheet.Cells[1, 2].Value = "Номер заявки";
                sheet.Cells[1, 3].Value = "Категория заявителя";
                sheet.Cells[1, 4].Value = "Населенный пункт, на территории которого следует отловить животное";
                sheet.Cells[1, 5].Value = "Место обитания животного";
                sheet.Cells[1, 6].Value = "Категория животного";
                sheet.Cells[1, 7].Value = "Срочность исполнения";
                sheet.Cells[1, 8].Value = "Организация по отлову";
                sheet.Cells[1, 9].Value = "Текущий статус заявки";
                sheet.Cells[1, 10].Value = "Дата установки статуса";

                var ds = context.RegistrationCard.Select(n=>n).ToList();
                for (int i = 0; i < ds.Count(); i++)
                {
                    sheet.Cells[i + 2, 1].Value = ds[i].rc_application_date;
                    sheet.Cells[i + 2, 2].Value = ds[i].rc_id;
                    sheet.Cells[i + 2, 3].Value = ds[i].ApplicantCategory.apc_name;
                    sheet.Cells[i + 2, 4].Value = ds[i].Omsu.MunicipalDistrict.md_name;
                    sheet.Cells[i + 2, 5].Value = ds[i].rc_animal_habitat;
                    sheet.Cells[i + 2, 6].Value = ds[i].AnimalCategory.anc_name;
                    sheet.Cells[i + 2, 7].Value = ds[i].UrgencyType.ut_name;
                    sheet.Cells[i + 2, 8].Value = ds[i].Organization == null ? "" : ds[i].Organization.or_name;
                    sheet.Cells[i + 2, 9].Value = ds[i].ApplicationStatus.as_name;
                    sheet.Cells[i + 2, 10].Value = Convert.ToDateTime(ds[i].as_changedate).ToString(CultureInfo.CurrentCulture);

                }
                sheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(path));
            }
        }
    }
}
