using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class Activation_VM: Base_VM
    {
        public int ActivationCode { get; set; }
        public string PhoneNo { get; set; }
        public DateTime RemainingTime { get; set; }
    }
}
