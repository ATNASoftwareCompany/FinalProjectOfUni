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
        public BaseResult_VM GetPersonList(int id)
        {
            return new BaseResult_VM(Person_DL.GetPersonList(), 0, "", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
