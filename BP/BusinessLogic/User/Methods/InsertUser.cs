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
        public BaseResult_VM InsertUser(User_VM inputModel)
        {
            if (inputModel == null)
            {
                return new BaseResult_VM(null, -1, "لطفا داده های ورودی را به درستی تکمیل نمایید.", DataModel.Enum.ErrorType.Error);
            }

            if (string.IsNullOrEmpty(inputModel.UserName))
            {
                return new BaseResult_VM(null, -1, "لطفا نام کاربری را به درستی تکمیل نمایید.", DataModel.Enum.ErrorType.Error);
            }

            if (string.IsNullOrEmpty(inputModel.Password))
            {
                return new BaseResult_VM(null, -1, "لطفا کلمه عبور را به درستی تکمیل نمایید.", DataModel.Enum.ErrorType.Error);
            }

            var existUser = _user_DL.GetUser(new User_VM
            {
                UserName = inputModel.UserName,
            });

            if (existUser != null)
            {
                return new BaseResult_VM(null, -1, "کاربر گرامی ، یوزر قبلا ثبت نام شده است.", DataModel.Enum.ErrorType.Error);
            }

            User_VM user = new User_VM
            {
                Password = inputModel.Password,
                UserName = inputModel.UserName,
                IsDelete = false,
                Status = (int)UserStatus.Active,
                InsertDate = DateTime.Now,
                UpdateDate = null
            };

            var result = _user_DL.InsertUser(user);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج اطلاعات کاربر", ErrorType.Error);
            }
            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", ErrorType.Sussess);
        }
    }
}
