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
        public BaseResult_VM CheckActivationCode(string PhoneNo , string AuthenticateCode)
        {
            var result = GetActivationCode(new Activation_VM
            {
                PhoneNo = PhoneNo,
                ActivationCode = Convert.ToInt32(AuthenticateCode)
            });
            if(result.ErrorCode != 0)
            {
                return result;
            }


            return null;
        }
    }
}
