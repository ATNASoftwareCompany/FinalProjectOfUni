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
            var result = Person_DL.InsertPerson(inputModel);
            if (result == -1)
            {
                return new BaseResult_VM(null, -1, "خطا در درج اطلاعات شخص", DataModel.Enum.ErrorType.Error);
            }


            return null;
        }
    }
}
