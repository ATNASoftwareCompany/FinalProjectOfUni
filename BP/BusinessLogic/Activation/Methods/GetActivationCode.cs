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
        public BaseResult_VM GetActivationCode(Activation_VM inputModel)
        {
            Activation_VM activation = new Activation_VM();
            if (inputModel.ActivationCode > 0)
            {
                activation.ActivationCode = inputModel.ActivationCode;
            }

            if (string.IsNullOrEmpty(inputModel.PhoneNo))
            {
                activation.PhoneNo = inputModel.PhoneNo;
            }

            var activeCode = dlActivation.GetActivation(activation);

            return new BaseResult_VM(activeCode, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
