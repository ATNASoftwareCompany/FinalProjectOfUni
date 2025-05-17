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
        public List<EnumInfo> GenerateEnumToObject<T>(string nothing) where T : Enum
        {
            var type = typeof(T);
            return Enum.GetValues(type)
                       .Cast<T>()
                       .Select(e => new EnumInfo
                       {
                           Name = e.ToString(),
                           Value = Convert.ToInt32(e),
                           Description = type
                               .GetMember(e.ToString())[0]
                               .GetCustomAttribute<DescriptionAttribute>()?.Description ?? e.ToString()
                       })
                       .ToList();
        }
    }
}
