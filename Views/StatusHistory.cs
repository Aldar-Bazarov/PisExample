using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PisFirst.Controllers.RecordsController;

namespace PisFirst.Views
{
    public partial class StatusHistory : Form
    {
        private List<Models.StatusHistory> _history;
        public StatusHistory(int recordID)
        {
            InitializeComponent();
            _history = RecordsController.GetStatusHistory(recordID);
            CreateColumns();
            fillStatusDGW();
        }

        void fillStatusDGW()
        {

            for (int i = 0; i < _history.Count; i++)
            {
               status_DGV.Rows.Add(Convert.ToDateTime(_history[i].as_changedate).ToShortDateString(),
                                   _history[i].as_name, 
                                   _history[i].or_name != null ? _history[i].or_name : "");
            }
        }
        void CreateColumns()
        {
            status_DGV.Columns.Add("as_changedate", "Дата изменения");
            status_DGV.Columns.Add("as_name", "Статус");
            status_DGV.Columns.Add("or_name", "Организация");
        }
    }
}
