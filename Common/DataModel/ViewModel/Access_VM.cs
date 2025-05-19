using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class Access_VM :Base_VM
    {
        public int ActionCode { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User_VM User { get; set; }

    }
}
