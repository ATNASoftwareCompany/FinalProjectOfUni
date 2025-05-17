using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum DiscountType
    {
        [Description("درصد")]
        Percetage = 1,

        [Description("مبلغ")]
        Amount = 2
    }
}
