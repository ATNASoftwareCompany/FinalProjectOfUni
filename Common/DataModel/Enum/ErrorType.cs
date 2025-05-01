using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum ErrorType
    {
        [Description("موفق")]
        Sussess = 1,

        [Description("هشدار")]
        Warning = 2,

        [Description("خطا")]
        Error = 3
    }
}
