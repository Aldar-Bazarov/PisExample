﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PisFirst.Models;

namespace PisFirst.Controllers.DataController
{
    public class DataController
    {
        private lab5 db = new lab5();

        public void FilterRecords(string[] filters, string[] sorts)
        {
            throw new NotImplementedException();
        }

        public DbSet<RegistrationCard> GetRegistryData() => db.RegistrationCard;

    }
}
