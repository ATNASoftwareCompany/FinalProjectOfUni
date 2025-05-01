using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum BStatus
    {
        [Description("غیرفعال")]
        DeActiva = 0,

        [Description("فعال")]
        Active = 1
    }
}
