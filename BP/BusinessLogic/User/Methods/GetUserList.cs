using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.User
{
    public partial class User_BL
    {
        public BaseResult_VM GetUserList(int id)
        {
            return new BaseResult_VM(_user_DL.GetUserList(), 0, "", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
