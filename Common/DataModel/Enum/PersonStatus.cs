using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum PersonStatus
    {
        [Description("غیرفعال")]
        Deactive = 0,
        
        [Description("فعال")]
        Active = 1,
        
        [Description("در انتظار فعالسازی")]
        WaitForActive = 10,
    }
}
