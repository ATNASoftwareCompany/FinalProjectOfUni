﻿using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class User_VM : Base_VM
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //public virtual ICollection<Access_VM> UserAccesses { get; set; }
    }
}
