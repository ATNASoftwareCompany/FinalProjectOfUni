using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Access
{
    public partial class Access_BL
    {
        public BaseResult_VM GetUserAccessList(int UserId)
        {
            return new BaseResult_VM(Access_DL.GetUserAccessList(UserId),0,"",DataModel.Enum.ErrorType.Sussess);
        }
    }
}
