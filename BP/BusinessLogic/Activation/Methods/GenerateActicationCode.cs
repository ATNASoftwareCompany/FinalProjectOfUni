using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Activation
{
    public partial class Activation_BL
    {
        public BaseResult_VM GenerateActicationCode()
        {
            Random randomNumberGenerator = new Random();
            int rand = randomNumberGenerator.Next(99999);

            return new BaseResult_VM(rand, 0, "", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
