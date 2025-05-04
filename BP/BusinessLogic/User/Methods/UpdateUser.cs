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
        public BaseResult_VM UpdateUser(User_VM inputModel)
        {
            var result = _user_DL.UpdateUser(inputModel);
            if (!result)
            {
                return new BaseResult_VM(false,-1,"خطا در بروزرسانی رکورد کاربر",DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(true, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
