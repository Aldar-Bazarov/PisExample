using PisFirst.Controllers.CRUD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PisFirst.Views
{
    /// <summary>
    /// Основная форма для взаимодействия с системой
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация экземпляра
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Событие, которое срабавтывает при загрузке формы
        /// </summary>
        /// <param name="sender">Источник-инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            FillRows(registrationCard_dataGridView);
        }

        /// <summary>
        /// Создание столбцов в registrationCard_dataGridView
        /// </summary>
        private void CreateColumns()
        {
            registrationCard_dataGridView.Columns.Add("rc_id", "ID");
            registrationCard_dataGridView.Columns.Add("rc_application_date", "Дата заявки");
            registrationCard_dataGridView.Columns.Add("rc_animal_habitat", "Место обитания животного");
            registrationCard_dataGridView.Columns.Add("rc_capture_reason", "Причина отлова");
            registrationCard_dataGridView.Columns.Add("rc_signing_date", "Дата подписания");
            registrationCard_dataGridView.Columns.Add("rc_signature", "Подпись");
            registrationCard_dataGridView.Columns.Add("u_id", "Заявку принял");
            registrationCard_dataGridView.Columns.Add("om_id", "Организация");
            registrationCard_dataGridView.Columns.Add("or_id", "ОМСУ");
            registrationCard_dataGridView.Columns.Add("ut_id", "Срочность");
            registrationCard_dataGridView.Columns.Add("anc_id", "Категория животного");
            registrationCard_dataGridView.Columns.Add("apc_id", "Категория заявителя");
            registrationCard_dataGridView.Columns.Add("as_id", "Статус заявки");

            registrationCard_dataGridView.Columns[0].Width = 25;
            registrationCard_dataGridView.Columns[1].Width = 75;
            registrationCard_dataGridView.Columns[2].Width = 100;
            registrationCard_dataGridView.Columns[3].Width = 100;
            registrationCard_dataGridView.Columns[4].Width = 75;
            registrationCard_dataGridView.Columns[5].Width = 75;
            registrationCard_dataGridView.Columns[6].Width = 100;
            registrationCard_dataGridView.Columns[7].Width = 100;
            registrationCard_dataGridView.Columns[8].Width = 100;
            registrationCard_dataGridView.Columns[9].Width = 100;
            registrationCard_dataGridView.Columns[10].Width = 100;
            registrationCard_dataGridView.Columns[11].Width = 100;
            registrationCard_dataGridView.Columns[12].Width = 100;

            registrationCard_dataGridView.RowHeadersVisible = false;
        }

        /// <summary>
        /// Заполнение строк в dataGridView
        /// </summary>
        /// <param name="dgv">dataGridView, которую нужно заполнить</param>
        private void FillRows(DataGridView dgv)
        {
            List<string[]> records = RegistrationCardCRUD.ReadData();

            foreach (var record in records)
            {
                dgv.Rows.Add(record[0], record[1], record[2], record[3], record[4],
                             record[5], record[6], record[7], record[8], record[9],
                             record[10], record[11], record[12]);
            }
        }
    }
}
