using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PisFirst.Controllers.ExportTools;
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
        /// Событие срабатывающее при нажатии на кнопку "Экспорт в Excel",
        /// совершает выгрузку файла Excel с данными из БД
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            ExportTools.ExportExcelRegistryRecords();
        }
        /// <summary>
        /// Событие срабатывающее при загрузке формы
        /// </summary>
        /// <param name="sender">Инициатор</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
