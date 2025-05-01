using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class Action_VM :Base_VM
    {
        public int ActionCode { get; set; }
        public string ActionName { get; set; }
        public bool IsMenu { get; set; }
        public bool IsShow { get; set; }
        public int Priority { get; set; }

    }
}
