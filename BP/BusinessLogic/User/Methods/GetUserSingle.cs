using DataModel;
using DataModel.Enum;
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
            if (user == null)
            {
                return new BaseResult_VM(null, 1, "کاربر مورد نظر یافت نشد", DataModel.Enum.ErrorType.Error);
            }

            if (user.Status == (int)UserStatus.AciveateWating)
            {
                return new BaseResult_VM(null, 5, "لطفا فرایند احراز هویت را تکمیل نمایید.", DataModel.Enum.ErrorType.Warning);
            }

            if(user.Status == (int)UserStatus.Banned)
            {
                return new BaseResult_VM(null, -1, "کاربر گرامی شما حساب کاربری شما توسط مدیر سیستم به حالت تعلیق درآمده است", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(user, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
