using DataModel;
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
        public BaseResult_VM GetUsers(User_VM inputModel)
        {
            var result = _user_DL.GetUsers();
            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
