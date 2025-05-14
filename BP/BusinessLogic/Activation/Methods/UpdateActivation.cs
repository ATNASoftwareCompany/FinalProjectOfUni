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
        public BaseResult_VM UpdateActivation(Activation_VM inputModel)
        {
            var result = dlActivation.UpdateActivation(inputModel);
            if (!result)
            {
                return new BaseResult_VM(null, -1, "خطای بازیابی کد احراز هویت", DataModel.Enum.ErrorType.Error);
            }
            return new BaseResult_VM(true, 0, "عملیات با موفقیت انجام شد", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
