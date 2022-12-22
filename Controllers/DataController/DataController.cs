using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using PisFirst.Models;
using PisFirst.Utils;

namespace PisFirst.Controllers.DataController
{
    public static class DataController
    {

        public static void FilterRecords(string[] filters, string[] sorts)
        {
            throw new NotImplementedException();
        }

        public static DbSet<RegistrationCard> GetFilteredRegistryData(Filter filter)
        {
            return null;
        }

       
    }
}
