using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Logging
{
    public class RequestBaseLog_VM
    {
        public RequestBaseLog_VM()
        {
            CallTime = DateTime.Now;
        }
        public long RequestId { get; set; }
        public string MethodInput { get; set; }
        public string MethodOutput { get; set; }
        public string Exception { get; set; }
        public int MethodId { get; set; }
        public long PointerId { get; set; }
        public DateTime CallTime { get; set; }

    }
}
