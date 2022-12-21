using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PisFirst.Models;
using Spire.Doc;

namespace PisFirst.Controllers.ExportToolsController
{
    internal static class ExportToolsController
    {
        static TestDbModel context = new TestDbModel();
        public static void ExportExcelRegistryRecords(string[] filters, string[] sorts, string FilePath)
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

        public static void ExportExcelTrappingApplications(string[] filters, string[] sorts,string FilePath)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            sfd.FileName = "ExportedJournalOfTrappingApplications";
            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK) return;
            var path = Path.GetFullPath(sfd.FileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var totalColumns = 10;
                var sheet = package.Workbook.Worksheets.Add("Лист 1");
                sheet.Cells[1,1,1, totalColumns].Style.TextRotation = 90;
                sheet.Cells[1, 1, 1, totalColumns].Style.WrapText = true;
                sheet.Cells[1, 1, 1, totalColumns].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Cells[1, 1, 1, totalColumns].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                var headerFont = sheet.Cells[1, 1, 1, totalColumns].Style.Font;
                headerFont.Size = 10;
                headerFont.Bold = true;
                headerFont = sheet.Cells[2, 8,2,9].Style.Font;
                headerFont.Bold = true;
                for (int i = 1; i <= totalColumns; i++)
                {   
                    if(i == 8) sheet.Cells[1, i, 1, i+1].Merge = true;
                    else if(i == 9) continue;
                    else sheet.Cells[1, i, 2, i].Merge = true;
                    sheet.Cells[1, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[1, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }                

                sheet.Cells[1, 1].Value = "№ заявки на отлов";
                sheet.Cells[1, 2].Value = "Дата поступления заявки";
                sheet.Cells[1, 3].Value = "Категория животного (собака, щенок, кошка, котенок)";
                sheet.Cells[1, 4].Value = "Место обитания животного";
                sheet.Cells[1, 5].Value = "Причина отлова (агрессивное поведение, отсутствие не снимаемой и несмываемой метки - из заявки)";
                sheet.Cells[1, 6].Value = "Ф.И.О. сотрудника, принявшего заявку";
                sheet.Cells[1, 8, 1, 9].Merge = true;
                sheet.Cells[1, 7].Value = "Дата передачи заявки специалисту организации, осуществляющей отлов";
                sheet.Cells[1, 8, 1, 9].Value = "Отметка об исполнении заявки";
                sheet.Cells[1, 8, 1, 9].Style.TextRotation = 0;

                sheet.Cells[2, 8].Value = "№ и дата заказа-наряда";
                sheet.Cells[2, 9].Value = "№ и дата акта отлова";
                sheet.Cells[1,10].Value = "Подпись специалиста, дата снятия с контроля исполнения";
                sheet.Cells[1,10].Style.TextRotation = 0;
                sheet.Row(2).Height = 100;
                //todo
                // var ds = context.RegistrationCard.Select(n => n).ToList();
                // for (int i = 0; i < ds.Count(); i++)
                // {
                //     sheet.Cells[i + 2, 1].Value = ds[i].rc_application_date;
                //     sheet.Cells[i + 2, 2].Value = ds[i].rc_id;
                //     sheet.Cells[i + 2, 3].Value = ds[i].ApplicantCategory.apc_name;
                //     sheet.Cells[i + 2, 4].Value = ds[i].Omsu.MunicipalDistrict.md_name;
                //     sheet.Cells[i + 2, 5].Value = ds[i].rc_animal_habitat;
                //     sheet.Cells[i + 2, 6].Value = ds[i].AnimalCategory.anc_name;
                //     sheet.Cells[i + 2, 7].Value = ds[i].UrgencyType.ut_name;
                //     sheet.Cells[i + 2, 8].Value = ds[i].Organization == null ? "" : ds[i].Organization.or_name;
                //     sheet.Cells[i + 2, 9].Value = ds[i].ApplicationStatus.as_name;
                //     sheet.Cells[i + 2, 10].Value = Convert.ToDateTime(ds[i].as_changedate).ToString(CultureInfo.CurrentCulture);
                // }
                sheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(path));
            }
        }
        public static void ExportWordTrappingApplications(string[] filters, string[] sorts, string FilePath)
        {
            var document = new Document();
            var samplePath = "sample.docx";
            document.LoadFromFile(samplePath);
           
            Table table = document.Sections[0].Tables[0] as Spire.Doc.Table;
            Table exTable = table.Clone();
            TableRow lastRow = exTable.Rows[table.Rows.Count - 1];
            TableRow templateRow = lastRow.Clone();
            for (int i = 0; i < context.RegistrationCard.Select(n => n).ToList().Count; i++)
            {
                Dictionary<string, string> replaceDict = new Dictionary<string, string>();
                replaceDict.Add("#num_rec#", context.RegistrationCard.Local[i].rc_id.ToString());
                replaceDict.Add("#date#", context.RegistrationCard.Local[i].rc_application_date.ToString("yyyy-MM-dd"));
                replaceDict.Add("#animal#", context.RegistrationCard.Local[i].AnimalCategory.anc_name);
                replaceDict.Add("#habitat#", context.RegistrationCard.Local[i].rc_animal_habitat);
                replaceDict.Add("#reason#", context.RegistrationCard.Local[i].rc_capture_reason);
                replaceDict.Add("#user#", $"{context.RegistrationCard.Local[i].AppUser.u_first_name} {context.RegistrationCard.Local[i].AppUser.u_second_name}");
                
                foreach (KeyValuePair<string, string> kvp in replaceDict)
                {
                    table.Replace(kvp.Key, kvp.Value, true, true);
                }
                table.Rows.Insert(table.Rows.Count, templateRow);
                templateRow = lastRow.Clone();
            }

            table.Rows[table.Rows.Count - 1].Cells.Clear();

            var docxPath = FilePath;
            document.SaveToFile(docxPath, FileFormat.Docx);
            
            MessageBox.Show("Журнал успешно экспортирован!", "Экспорт Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }
    }
}
