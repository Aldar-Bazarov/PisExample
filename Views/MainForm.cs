//using PisFirst.Controllers.CRUD;
using PisFirst.Controllers.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PisFirst.Controllers.ExportToolsController;
using PisFirst.Controllers.DataController;
using PisFirst.Models;
using PisFirst.Utils;

namespace PisFirst.Views
{
    /// <summary>
    /// Основная форма для взаимодействия с системой
    /// </summary>
    public partial class MainForm : Form
    {
        private Filter _filter;
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void FillComboBox()
        {
            ComboBox[] comboFilters = {reg_cardCombo,aplCategoryCombo,
                                        distrCombo,animalCategoryCombo,
                                        urgencyCombo,orgCombo,statusCombo };
            RecordsController.GetFilterComboBoxes(comboFilters);

            // comboBox.Items.Clear();
        }

        
        
        /// <summary>
        /// Событие срабатывающее при нажатии на кнопку "Экспорт в Excel",
        /// совершает выгрузку файла Excel с данными из БД
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            
            // ExportToolsController.ExportExcelRegistryRecords();
        }

        private void btnViewJournal_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
            
        }

        /// <summary>
        /// Событие, которое срабавтывает при загрузке формы
        /// </summary>
        /// <param name="sender">Источник-инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            FillRows();
            FillComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Создание столбцов в registrationCard_dataGridView
        /// </summary>
        private void CreateColumns()
        {
            registrationCard_dataGridView.Columns.Add("rc_application_date", "Дата подачи заявления");
            registrationCard_dataGridView.Columns.Add("rc_id", "Номер заявки");
            registrationCard_dataGridView.Columns.Add("apc_id", "Категория заявителя");
            registrationCard_dataGridView.Columns.Add("md_id", "Населенный пункт, на территории которого " +
                                                                                    "следует отловить животное");
            registrationCard_dataGridView.Columns.Add("rc_animal_habitat", "Место обитания животного");
            registrationCard_dataGridView.Columns.Add("anc_id", "Категория животного");
            registrationCard_dataGridView.Columns.Add("ut_id", "Срочность исполнения");
            registrationCard_dataGridView.Columns.Add("or_id", "Организация по отлову");
            registrationCard_dataGridView.Columns.Add("as_id", "Текущий статус заявки");
            registrationCard_dataGridView.Columns.Add("as_changedate", "Дата установки статуса");

            // registrationCard_dataGridView.Columns.Add("rc_capture_reason", "Причина отлова");
            // registrationCard_dataGridView.Columns.Add("rc_signing_date", "Дата подписания");
            // registrationCard_dataGridView.Columns.Add("rc_signature", "Подпись");
            // registrationCard_dataGridView.Columns.Add("u_id", "Заявку принял");

            registrationCard_dataGridView.Columns[0].Width = 120;
            registrationCard_dataGridView.Columns[1].Width = 55;
            registrationCard_dataGridView.Columns[2].Width = 120;
            registrationCard_dataGridView.Columns[3].Width = 120;
            registrationCard_dataGridView.Columns[4].Width = 120;
            registrationCard_dataGridView.Columns[5].Width = 120;
            registrationCard_dataGridView.Columns[6].Width = 50;
            registrationCard_dataGridView.Columns[7].Width = 100;
            registrationCard_dataGridView.Columns[8].Width = 120;
            registrationCard_dataGridView.Columns[9].Width = 120;
            // registrationCard_dataGridView.Columns[10].Width = 100;
            // registrationCard_dataGridView.Columns[11].Width = 100;
            // registrationCard_dataGridView.Columns[12].Width = 100;

            registrationCard_dataGridView.RowHeadersVisible = false;
        }

        /// <summary>
        /// Заполнение строк в dataGridView
        /// </summary>
        private void FillRows(Filter filter=null)
        {
            
            var context = new TestDbModel();
            List<RegistrationCard> records = RecordsController.GetPermittedRecords(_filter);
            foreach (var record in records)
            {
                registrationCard_dataGridView.Rows.Add(record.rc_application_date, record.rc_id, record.ApplicantCategory.apc_name, 
                            record.Omsu.MunicipalDistrict.md_name, record.rc_animal_habitat,
                             record.AnimalCategory.anc_name, record.UrgencyType.ut_name, 
                            record.Organization?.or_name ?? " ", record.ApplicationStatus.as_name, record.as_changedate);
            }

          
        }

        /// <summary>
        /// Добавления записи в реестр
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void btnAddRegCard_Click(object sender, EventArgs e)
        {
            var addRecordForm = new RegistrationCardForm(false);
            addRecordForm.Show();
                //if (addRecordForm.ShowDialog() != DialogResult.OK)
                //{
                //    throw new Exception("Не удалось открыть окно добавления записи");
                //}
            
        }

        /// <summary>
        /// Просмотр карточки реестра
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void btnViewRegCard_Click(object sender, EventArgs e)
        {
            using (var addRecordForm = new RegistrationCardForm(true))
            {
                if (addRecordForm.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("Не удалось открыть окно добавления записи");
                }
            }
        }

        /// <summary>
        /// Изменение записи в реестре
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void btnEditRegCard_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            _filter = Filter.CreateInstance();
            _filter.RegCardID = (int)reg_cardCombo.SelectedValue;
            _filter.MaxRecordDate = dtPickerEnd.Value;
            _filter.MinRecordDate = dtPickerStart.Value;
            FillRows(_filter);
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            FillRows();
        }
    }
}
