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
using PisFirst.Utils;
using Spire.Doc;

namespace PisFirst.Controllers.ExportToolsController
{
    internal static class ExportToolsController
    {
        
        public static void ExportExcelRegistryRecords(DataGridViewRowCollection dgvRows,string FilePath)
        {
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

                var ds = dgvRows;
                for (int i = 0; i < ds.Count; i++)
                {
                    sheet.Cells[i + 2, 1].Value = ds[i].Cells[0].Value;
                    sheet.Cells[i + 2, 2].Value = ds[i].Cells[1].Value;
                    sheet.Cells[i + 2, 3].Value = ds[i].Cells[2].Value;
                    sheet.Cells[i + 2, 4].Value = ds[i].Cells[3].Value;
                    sheet.Cells[i + 2, 5].Value = ds[i].Cells[4].Value;
                    sheet.Cells[i + 2, 6].Value = ds[i].Cells[5].Value;
                    sheet.Cells[i + 2, 7].Value = ds[i].Cells[6].Value;
                    sheet.Cells[i + 2, 8].Value = ds[i].Cells[7].Value;
                    sheet.Cells[i + 2, 9].Value = ds[i].Cells[8].Value;
                    sheet.Cells[i + 2, 10].Value = Convert.ToDateTime( ds[i].Cells[9].Value).ToShortDateString();
                }
                sheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(FilePath));
            }
        }

        public static void ExportExcelTrappingApplications(DataGridViewRowCollection dgvRows,string FilePath,Filter filter)
        {
            var path = FilePath;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var totalColumns = 10;
                var sheet = package.Workbook.Worksheets.Add("Лист 1");
                sheet.Cells[1, 4,1,7].Merge = true;
                sheet.Cells[1, 4, 1, 7].Value = "Журнал учёта заявок на отлов животных без владельцев";
                sheet.Cells[2,4].Value = DateTime.Now.ToShortDateString();
                sheet.Cells[2, 5, 2, 6].Merge = true;
                using (var context = new TestDbModel())
                {
                    sheet.Cells[2, 5, 2, 6].Value = context.MunicipalDistrict.First(n=>n.md_id == filter.MunDistrID).md_name;
                    sheet.Cells[2, 5, 2, 6].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                }
                sheet.Cells[2, 7, 2, 8].Merge = true;
                sheet.Cells[2, 7, 2, 8].Value = "муниципального образования";
                sheet.Cells[3, 4, 3, 7].Merge = true;
                sheet.Cells[3, 4, 3, 7].Value = "(наименование муниципального образования)";

                sheet.Cells[4,1,4, totalColumns].Style.TextRotation = 90;
                sheet.Cells[4, 1, 4, totalColumns].Style.WrapText = true;
                sheet.Cells[4, 1, 4, totalColumns].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Cells[4, 1, 4, totalColumns].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                var headerFont = sheet.Cells[4, 1, 4, totalColumns].Style.Font;
                headerFont.Size = 10;
                headerFont.Bold = true;
                headerFont = sheet.Cells[5, 8,5,9].Style.Font;
                headerFont.Bold = true;
                for (int i = 1; i <= totalColumns; i++)
                {
                    sheet.Cells[4, i].Style.Border.Top.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[4, i].Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[4, i].Style.Border.Right.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[4, i].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[5, i].Style.Border.Top.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[5, i].Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[5, i].Style.Border.Right.Style = ExcelBorderStyle.Medium;
                    sheet.Cells[5, i].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                    if (i == 8) sheet.Cells[4, i, 4, i+1].Merge = true;
                    else if(i == 9) continue;
                    else sheet.Cells[4, i, 5, i].Merge = true;
                    
                }                

                sheet.Cells[4, 1].Value = "№ заявки на отлов";
                sheet.Cells[4, 2].Value = "Дата поступления заявки";
                sheet.Cells[4, 3].Value = "Категория животного (собака, щенок, кошка, котенок)";
                sheet.Cells[4, 4].Value = "Место обитания животного";
                sheet.Cells[4, 5].Value = "Причина отлова (агрессивное поведение, отсутствие не снимаемой и несмываемой метки - из заявки)";
                sheet.Cells[4, 6].Value = "Ф.И.О. сотрудника, принявшего заявку";
                sheet.Cells[4, 8, 4, 9].Merge = true;
                sheet.Cells[4, 7].Value = "Дата передачи заявки специалисту организации, осуществляющей отлов";
                sheet.Cells[4, 8, 4, 9].Value = "Отметка об исполнении заявки";
                sheet.Cells[4, 8, 4, 9].Style.TextRotation = 0;

                sheet.Cells[5, 8].Value = "№ и дата заказа-наряда";
                sheet.Cells[5, 9].Value = "№ и дата акта отлова";
                sheet.Cells[4,10].Value = "Подпись специалиста, дата снятия с контроля исполнения";
                sheet.Cells[4,10].Style.TextRotation = 0;
                sheet.Row(4).Height = 100;
               
                for (int i = 0; i < dgvRows.Count; i++)
                {
                    for (var j = 1; j <= totalColumns;j++)
                    {
                        sheet.Cells[i + 6, j].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        sheet.Cells[i + 6, j].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        sheet.Cells[i + 6, j].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        sheet.Cells[i + 6, j].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    }
                    sheet.Cells[i + 6, 1].Value = dgvRows[i].Cells[0].Value.ToString();
                    sheet.Cells[i + 6, 2].Value = dgvRows[i].Cells[1].Value.ToString();
                    sheet.Cells[i + 6, 3].Value = dgvRows[i].Cells[2].Value.ToString();
                    sheet.Cells[i + 6, 4].Value = dgvRows[i].Cells[3].Value.ToString();
                    sheet.Cells[i + 6, 5].Value = dgvRows[i].Cells[4].Value.ToString();
                    sheet.Cells[i + 6, 6].Value = dgvRows[i].Cells[5].Value.ToString();
                    sheet.Cells[i + 6, 7].Value = dgvRows[i].Cells[6].Value.ToString();
                    sheet.Cells[i + 6, 10].Value = dgvRows[i].Cells[9].Value.ToString();
                    
                }
                sheet.Cells.AutoFitColumns();
                sheet.Columns[7].Width = 30;
                package.SaveAs(new FileInfo(path));
                MessageBox.Show("Журнал успешно экспортирован!", "Экспорт Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public static void ExportWordTrappingApplications(DataGridViewRowCollection dgvRows,string FilePath, Filter filter)
        {

            var document = new Document();
            var samplePath = "sample.docx";
            document.LoadFromFile(samplePath);
           
            Table table = document.Sections[0].Tables[0] as Table;
            Table exTable = table.Clone();
            TableRow lastRow = exTable.Rows[table.Rows.Count - 1];
            TableRow templateRow = lastRow.Clone();
            using (var context = new TestDbModel())
            {
                document.Replace("#municipal_distr#",
                    context.MunicipalDistrict.First(n => n.md_id == filter.MunDistrID).md_name, true, true);
            }

            document.Replace("#date_now#",DateTime.Now.ToShortDateString(), true, true);
            for (int i = 0; i < dgvRows.Count; i++)
            {

                Dictionary<string, string> replaceDict = new Dictionary<string, string>();
                replaceDict.Add("#num_rec#", dgvRows[i].Cells[0].Value.ToString());
                replaceDict.Add("#date#", dgvRows[i].Cells[1].Value.ToString());
                replaceDict.Add("#animal#", dgvRows[i].Cells[2].Value.ToString());
                replaceDict.Add("#habitat#", dgvRows[i].Cells[3].Value.ToString());
                replaceDict.Add("#reason#", dgvRows[i].Cells[4].Value.ToString());
                replaceDict.Add("#user#", dgvRows[i].Cells[5].Value.ToString());
                replaceDict.Add("#dateforward#", dgvRows[i].Cells[6].Value.ToString());
                replaceDict.Add("#date_end#", dgvRows[i].Cells[9].Value.ToString());

                foreach (KeyValuePair<string, string> kvp in replaceDict)
                {
                    table.Replace(kvp.Key, kvp.Value, true, true);
                }
                table.Rows.Insert(table.Rows.Count, templateRow);
                templateRow = lastRow.Clone();
            }
            if(table.Rows.Count > 3)
                table.Rows[table.Rows.Count - 1].Cells.Clear();

            var docxPath = FilePath;
            document.SaveToFile(docxPath, FileFormat.Docx);
            
            MessageBox.Show("Журнал успешно экспортирован!", "Экспорт Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }
    }
}
