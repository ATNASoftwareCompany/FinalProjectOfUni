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
        public bool DeletePerson(Person_VM inputModel)
        {
            return UpdatePerson(inputModel);
        }
    }
}
