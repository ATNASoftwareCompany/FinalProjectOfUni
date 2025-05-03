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
        public BaseResult_VM GetUserSingle(User_VM inputModel)
        {
            var user = _user_DL.GetUser(inputModel); 
            return new BaseResult_VM(user, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
