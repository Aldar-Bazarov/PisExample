using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PisFirst.Models;

namespace PisFirst.Controllers.ExportTools
{
    internal static class ExportTools
    {
        static labEntity context = new labEntity();
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

                }
                // var wf = RegistrationCard
                // ExcelRange firstCell = sheet.Cells[1, 1];
                // firstCell.Value = "will it work?";
                // sheet.Cells["A2"].Formula = "CONCATENATE(A1,\" ... Of course it will!\")";
                //
                // // Numbers
                // var moneyCell = sheet.Cells["A3"];
                // moneyCell.Style.Numberformat.Format = "$#,##0.00";
                // moneyCell.Value = 15.25M;
                //
                // // Easily write any Enumerable to a sheet
                // // In this case: All Excel functions implemented by EPPlus
                // var funcs = package.Workbook.FormulaParserManager.GetImplementedFunctions()
                //     .Select(x => new { FunctionName = x.Key, TypeName = x.Value.GetType().FullName });
                // sheet.Cells["A4"].LoadFromCollection(funcs, true);
                //
                // // Styling cells
                // var someCells = sheet.Cells["A1,A4:B4"];
                // someCells.Style.Font.Bold = true;
                // someCells.Style.Font.Color.SetColor(Color.Ivory);
                // someCells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                // someCells.Style.Fill.BackgroundColor.SetColor(Color.Navy);

                sheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(path));
            }
        }
    }
}
