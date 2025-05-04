using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.Enum;

namespace DataModel.Logging
{
    public class ResponseBaseLog_VM
    {
        public ResponseBaseLog_VM()
        {
            CallTime = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ResponseID { get; set; }
        public long RequestId { get; set; } = new RequestBaseLog_VM().RequestId;
        public string MethodInput { get; set; }
        public string MethodOutput { get; set; }
        public string Exception { get; set; }
        public GenreType GenreId { get; set; }
        public MethodsType MethodId { get; set; }
        public object PointerId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime ResponseTime { get; set; }
    }
}
