using DataModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RequestId { get; set; } 
        public string MethodInput { get; set; }
        public string MethodOutput { get; set; } = null;
        public string Exception { get; set; }
        public MethodsType MethodId { get; set; }
        public GenreType GenreId { get; set; }
        public object PointerId { get; set; }
        public DateTime CallTime { get; set; }

    }
}
