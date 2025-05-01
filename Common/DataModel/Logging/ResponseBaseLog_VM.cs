using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Logging
{
    public class ResponseBaseLog_VM: RequestBaseLog_VM
    {
        public long ResponseID { get; set; }
        public DateTime ResponseTime { get; set; }
    }
}
