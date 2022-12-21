using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using PisFirst.Models;

namespace PisFirst.Controllers.DataController
{
    public class DataController
    {
        private TestDbModel db = new TestDbModel();

        public void FilterRecords(string[] filters, string[] sorts)
        {
            throw new NotImplementedException();
        }

        public DbSet<RegistrationCard> GetRegistryData() => db.RegistrationCard;

        // public ComboBox getComboBoxSourceFromDb(ComboBox comboBox)
        // {
        //     var column = comboBox.Items[0].ToString();
        //     // if 
        //     // return 
        // }
    }
}
