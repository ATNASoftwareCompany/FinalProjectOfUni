﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp
{
    public class RegisterDTO : Base_VM
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNo { get; set; }
        public string E_Mail { get; set; }
        public string Password { get; set; }
    }
}
