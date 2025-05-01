using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Base_VM
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public bool IsDelete { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
