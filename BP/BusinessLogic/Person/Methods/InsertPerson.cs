using DataModel;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Person
{
    public partial class Person_BL
    {
        public BaseResult_VM InsertPerson(Person_VM inputModel)
        {
            var existPerson = Person_DL.GetPerson(new Person_VM
            {
                PhoneNo = inputModel.PhoneNo,
            });

            if (existPerson != null)
            {
                return new BaseResult_VM(null, -1, "کاربر با شماره همراه وارد شده قبلا ثبت نام کرده است", DataModel.Enum.ErrorType.Error);
            }

            var result = Person_DL.InsertPerson(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج اطلاعات شخص", DataModel.Enum.ErrorType.Error);
            }

            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
