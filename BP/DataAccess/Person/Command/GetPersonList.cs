﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Person
{
    public partial class Person_DL
    {
        public List<Person_VM> GetPersonList()
        {
            return db.Persons.ToList();
        }
    }
}
