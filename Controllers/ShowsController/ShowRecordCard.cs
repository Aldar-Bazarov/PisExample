using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using PisFirst.Models;
using PisFirst.Views;

namespace PisFirst.Controllers.showController
{
    public static class ShowRecordCard
    {

        public static void ShowRegistrationCard(string recordId)
        {
            lab5 context = new lab5();
            RegistrationCard card = context.RegistrationCard.Where(c => c.rc_id == Convert.ToInt32(recordId)).First();
            (new RecordCard(card)).ShowDialog();
        }

    }
}