using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum AuthenticateType
    {
        [Description("ثبت نام")]
        Register = 1,

        [Description("بازیابی کلمه عبور")]
        RestorePassword = 2
    }
}
