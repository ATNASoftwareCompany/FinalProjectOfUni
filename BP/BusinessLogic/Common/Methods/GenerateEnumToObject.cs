using DataModel.Enum;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public partial class Common_BL
    {
        public BaseResult_VM GenerateEnumToObject(string nothing) //where T : Enum
        {
            var type = typeof(AccessType);
            return new BaseResult_VM(Enum.GetValues(type)
                       .Cast<AccessType>()
                       .Select(e => new EnumInfo
                       {
                           Name = e.ToString(),
                           Value = Convert.ToInt32(e),
                           Description = type
                               .GetMember(e.ToString())[0]
                               .GetCustomAttribute<DescriptionAttribute>()?.Description ?? e.ToString()
                       })
                       .ToList(), 0, "", DataModel.Enum.ErrorType.Sussess);
        }

        public BaseResult_VM GenerateEnumToObject(int id) //where T : Enum
        {
            var type = typeof(AccessType);
            return new BaseResult_VM(Enum.GetValues(type)
                       .Cast<AccessType>()
                       .Select(e => new EnumInfo
                       {
                           Name = e.ToString(),
                           Value = Convert.ToInt32(e),
                           Description = type
                               .GetMember(e.ToString())[0]
                               .GetCustomAttribute<DescriptionAttribute>()?.Description ?? e.ToString()
                       })
                       .FirstOrDefault(x => x.Value == id), 0, "", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
