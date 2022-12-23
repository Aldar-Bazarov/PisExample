//using PisFirst.Controllers.CRUD;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using PisFirst.Controllers.ExportToolsController;
using PisFirst.Controllers.RecordsController;
using PisFirst.Models;
using PisFirst.Utils;
using Spire.Pdf.Exporting.XPS.Schema;
using Path = System.IO.Path;

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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Size.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Size.Height;

            registrationCard_dataGridView.Location = new Point(0, 0);
            registrationCard_dataGridView.Size = new Size(this.Width - 500, this.Height - 50);

            exitButton.Location = new Point(this.Width - 100, 10);
            exitButton.Size = new Size(70, 30);

            userLabel.Location = new Point(this.Width - 485, exitButton.Location.Y + 10);

            filterGroupBox.Location = new Point(this.Width - 485, 50);

            showRegistrationCard.Location = new Point(filterGroupBox.Location.X, filterGroupBox.Location.Y + filterGroupBox.Height + 100);
            showRegistrationCard.Size = new Size(150, 30);

            addRecordButton.Location = new Point(showRegistrationCard.Location.X, showRegistrationCard.Location.Y + 40);
            addRecordButton.Size = new Size(150, 30);

            changeRecordButton.Location = new Point(addRecordButton.Location.X, addRecordButton.Location.Y + 40);
            changeRecordButton.Size = new Size(150, 30);

            journalButton.Location = new Point(changeRecordButton.Location.X, changeRecordButton.Location.Y + 40);
            journalButton.Size = new Size(150, 30);

            exportLabel.Location = new Point(showRegistrationCard.Location.X + 300, filterGroupBox.Location.Y + filterGroupBox.Height + 100);
            exportExcelButton.Location = new Point(exportLabel.Location.X + 20, exportLabel.Location.Y + 30);
            CreateColumns();
            FillRows();
            userLabel.Text =
                $"{Program.AuthSession.AppUser.u_second_name} {Program.AuthSession.AppUser.u_first_name}: " 
                + $"{Program.AuthSession.AppUser.UserRole.ur_name}";
        }

        
        private void FillComboBox()
        {
            ComboBox[] comboFilters = {reg_cardCombo,aplCategoryCombo,
                                        distrCombo,animalCategoryCombo,
                                        urgencyCombo,orgCombo,statusCombo };
            RecordsController.GetFilterComboBoxes(comboFilters);
            dtPickerStart.Value = DateTime.Parse($"01.01.{DateTime.Now.Year}");
            dtPickerEnd.Value = DateTime.Now;
            // comboBox.Items.Clear();
        }

        
        
        /// <summary>
        /// Событие срабатывающее при нажатии на кнопку "Экспорт в Excel",
        /// совершает выгрузку файла Excel с данными из БД
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            sfd.FileName = "ExportedRegistry";
            var dialogResult =  sfd.ShowDialog();
            
            if (dialogResult == DialogResult.OK) {
                var dgvRows = registrationCard_dataGridView.Rows;
                ExportToolsController.ExportExcelRegistryRecords(dgvRows,Path.GetFullPath(sfd.FileName));
                MessageBox.Show("Регистр успешно экспортирован!", "Экспорт регистра Excel", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        /// <summary>
        /// Событие, которое срабавтывает при загрузке формы
        /// </summary>
        /// <param name="sender">Источник-инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
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
            this.registrationCard_dataGridView.Rows.Clear();
            var context = new TestDbModel();
            List<RegistrationCard> records = RecordsController.GetPermittedRecords(_filter);
            foreach (var record in records)
            {
                registrationCard_dataGridView.Rows.Add(record.rc_application_date, record.rc_id, record.ApplicantCategory.apc_name, 
                            record.Omsu.MunicipalDistrict.md_name, record.rc_animal_habitat,
                             record.AnimalCategory.anc_name, record.UrgencyType.ut_name, 
                            record.Organization?.or_name ?? " ", record.ApplicationStatus.as_name, record.as_changedate);
            }
            if (filter == null) FillComboBox();
        }

        /// <summary>
        /// Добавления записи в реестр
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>


        /// <summary>
        /// Просмотр карточки реестра
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>

        /// <summary>
        /// Изменение записи в реестре
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void changeRecordButton_Click(object sender, EventArgs e)
        {

        }
        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            _filter = Filter.CreateInstance();
            _filter.MaxRecordDate = dtPickerEnd.Value;
            _filter.MinRecordDate = dtPickerStart.Value;
            _filter.RegCardID = reg_cardCombo.SelectedValue != null ? (int)reg_cardCombo.SelectedValue : 0;
            _filter.ApplicantCategoryID = aplCategoryCombo.SelectedValue != null ? (int)aplCategoryCombo.SelectedValue:0;
            _filter.MunDistrID = distrCombo.SelectedValue != null ? (int)distrCombo.SelectedValue:0;
            _filter.UrgencyTypeID = urgencyCombo.SelectedValue != null ? (int)urgencyCombo.SelectedValue : 0;
            _filter.OrganizationID = orgCombo.SelectedValue != null ? (int)orgCombo.SelectedValue : 0;
            _filter.StatusID = statusCombo.SelectedValue != null ? (int)statusCombo.SelectedValue : 0;
            FillRows(_filter);
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            _filter = null;
            FillRows();
        }


    

        private void journalButton_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        // Cards

        /// <summary>
        /// Проверить роль пользователя
        /// </summary>
        /// <param name="user"> Пользователь </param>
        /// <returns> Роль </returns>
        private Program.UserRole CheckUserRole(AppUser user)
        {
            switch (user.UserRole.ur_name)
            {
                case "Оператор по отлову":
                    return Program.UserRole.TrappingOperator;
                case "Оператор ОМСУ":
                    return Program.UserRole.TrappingOperator;
                default:
                    addRecordButton.Enabled = false;
                    return Program.UserRole.TrappingOperator;
            }
        }


        /// <summary>
        /// Добавления записи в реестр
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            new RegistrationCardForm(Program.role).ShowDialog();
            FillRows();
        }

        /// <summary>
        /// Просмотр карточки реестра
        /// </summary>
        /// <param name="sender"> Источник-инициатор </param>
        /// <param name="e"> Аргументы события </param>
        /// <exception cref="Exception"> Ошибка при открытии диалогового окна </exception>
        private void showRegistrationCard_Click(object sender, EventArgs e)
        {
            var id = registrationCard_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            new RegistrationCardForm(id, Program.role).ShowDialog();
            FillRows();
        }
    }
}
