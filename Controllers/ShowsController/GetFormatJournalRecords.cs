using PisFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisFirst.Controllers.showController
{
    internal class GetFormatJournalRecords
    {
        lab5 context = new lab5();
        public void ShowJournal(string[] filters, string[] sort)
        {
            var cardsList = context.RegistrationCard.ToList();
            var selectedCards = new List<RegistrationCard>();
            if (filters.Length != 0)
            {
                foreach (var item in filters)
                {

                }
            }
            selectedCards = cardsList;


        }
    }
}