using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Activation
{
    public partial class Activation_BL
    {
        public BaseResult_VM GetActivationByPhoneNo(string phoneNo)
        {
            var result = dlActivation.GetActivationByPhoneNo(phoneNo);
            if (result == null)
            {
                return new BaseResult_VM(null , -1, "داده ای یافت نشد" , DataModel.Enum.ErrorType.Error);
            }

            return new BaseResult_VM(result, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
