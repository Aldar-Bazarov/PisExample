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
using PisFirst.Controllers.DataController;
using PisFirst.Models;

namespace PisFirst.Views
{
    /// <summary>
    /// Основная форма для взаимодействия с системой
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Событие срабатывающее при загрузке формы
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDGW();
        }

        private void FillDGW()
        {
            var registryBindingSource = new BindingSource();
            var registryDataController = new DataController();
            registryBindingSource.DataSource = registryDataController.GetRegistryData();
            registyDGW.DataSource = registryBindingSource;
            AdjustColumnNames();
            registyDGW.Refresh();
        }

        private void AdjustColumnNames()
        {
            registyDGW.Columns["rc_application_date"].HeaderText = registyDGW.Columns[0].HeaderText;
            InsertColumn(registyDGW.Columns["rc_application_date"], 0);

            registyDGW.Columns["rc_id"].HeaderText = registyDGW.Columns[1].HeaderText;
            InsertColumn(registyDGW.Columns["rc_id"],1);

            registyDGW.Columns["rc_id"].HeaderText = registyDGW.Columns[1].HeaderText;
            InsertColumn(registyDGW.Columns["rc_id"], 1);

            registyDGW.Columns["rc_id"].HeaderText = registyDGW.Columns[2].HeaderText;
            InsertColumn(registyDGW.Columns["rc_id"], 2);
            registyDGW.Columns["rc_id"].DisplayIndex = 1;
        }

        private void InsertColumn(DataGridViewColumn column,int index)
        {
            column.DisplayIndex = index;
        }
        /// <summary>
        /// Событие срабатывающее при нажатии на кнопку "Экспорт в Excel",
        /// совершает выгрузку файла Excel с данными из БД
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FillDGW();
            ExportToolsController.ExportExcelRegistryRecords();
        }

        private void btnViewJournal_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }
    }
}
