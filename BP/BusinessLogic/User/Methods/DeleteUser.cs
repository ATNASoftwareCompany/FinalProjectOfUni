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
        public BaseResult_VM DeleteUser(User_VM inputModel)
        {
            var user = GetUserSingle(inputModel);
            if (user == null)
            {
                return new BaseResult_VM(null, -1, "داده ای برای حذف یافت نشد", DataModel.Enum.ErrorType.Error);
            }

            User_VM DeleteUser = user.Result as User_VM;

            DeleteUser.IsDelete = true;
            DeleteUser.UpdateDate = DateTime.Now;
            var result = _user_DL.DeleteUser(DeleteUser);
            if (!result)
            {
                return new BaseResult_VM(false, -1, "خطا در حذف رکورد کاربر", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(true, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
