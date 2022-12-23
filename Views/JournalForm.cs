using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PisFirst.Controllers.ExportToolsController;
using PisFirst.Controllers.RecordsController;
using PisFirst.Models;
using PisFirst.Utils;
using Spire.Pdf.Exporting.XPS.Schema;
using Path = System.IO.Path;

namespace PisFirst.Views
{
    public partial class JournalForm : Form
    {
        private Filter _filter;
        public JournalForm()
        {

            InitializeComponent();
            CreateColumns();
        }

        private void CreateColumns()
        {
            this.journalGrid.Columns.Add("rc_id", "Номер заявки на отлов");
            this.journalGrid.Columns.Add("rc_application_date", "Дата подачи заявления");
            this.journalGrid.Columns.Add("anc_id", "Категория животного");
            this.journalGrid.Columns.Add("rc_animal_habitat", "Место обитания животного");
            this.journalGrid.Columns.Add("rc_capture_reason", "Причина отлова");
            this.journalGrid.Columns.Add("u_id", "ФИО сотрудника");
            this.journalGrid.Columns.Add("rc_find_organizrioin_date", "Дата передачи заявки специалисту организации, осуществляющей отлов");
            this.journalGrid.Columns.Add(" ", "№ и дата заказа-наряда");
            this.journalGrid.Columns.Add(" ", "№ и дата акта отлова");
            this.journalGrid.Columns.Add("rc_capture_date", "Подпись специалиста, дата снятия с контроля исполнения");
            

            journalGrid.Columns[0].Width = 120;
            journalGrid.Columns[1].Width = 55;
            journalGrid.Columns[2].Width = 120;
            journalGrid.Columns[3].Width = 120;
            journalGrid.Columns[4].Width = 120;
            journalGrid.Columns[5].Width = 120;
            journalGrid.Columns[6].Width = 120;
            journalGrid.Columns[7].Width = 40;
            journalGrid.Columns[8].Width = 40;

        }

        private void FillRows()
        {
            
            this.journalGrid.Rows.Clear();
            var context = new TestDbModel();
            List<RegistrationCard> records = context.RegistrationCard.Select(c => c).Where(c => c.Omsu.md_id == _filter.MunDistrID).ToList();
            foreach (var record in records)
            {
                journalGrid.Rows.Add(record.rc_id,
                    Convert.ToDateTime(record.rc_application_date).ToShortDateString(),
                    record.AnimalCategory.anc_name,
                    record.rc_animal_habitat,
                    record.rc_capture_reason,
                    record.AppUser.u_first_name + " " + record.AppUser.u_second_name,
                    Convert.ToDateTime(record.rc_find_organizrioin_date).ToShortDateString(), "","",Convert.ToDateTime( record.rc_capture_date).ToShortDateString());
            }
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            sfd.FileName = $"ПереченьЗаявокНаОтлов";
            DialogResult result = sfd.ShowDialog();

            if (result != DialogResult.OK) return;
            ExportToolsController.ExportExcelTrappingApplications(journalGrid.Rows, Path.GetFullPath(sfd.FileName), _filter);
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Документ Word (*.docx)|*.docx";
            sfd.FileName = $"ПереченьЗаявокНаОтлов";
            DialogResult result = sfd.ShowDialog();
            
            if (result != DialogResult.OK) return;
            ExportToolsController.ExportWordTrappingApplications(journalGrid.Rows, Path.GetFullPath(sfd.FileName),_filter);

        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            dataLabel.Text = $"\"{DateTime.Now.ToShortDateString()}\"";
            var context = new TestDbModel();
            omsuComboBox.ValueMember = "md_id";
            omsuComboBox.DisplayMember = "md_name";
            omsuComboBox.DataSource = context.MunicipalDistrict.ToList();
        }

        private void omsuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter = new Filter();
            _filter.MunDistrID = (int)omsuComboBox.SelectedValue;
            FillRows();
        }


    }
}
