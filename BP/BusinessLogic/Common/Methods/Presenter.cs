using DataModel.Logging;
using DataModel.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Common.Methods
{
    public class Presenter
    {
        public BaseResult_VM HandleResponse<T>(Func<T , BaseResult_VM> func ,T methodInput, RequestBaseLog_VM requestLog )
        {

            requestLog.MethodInput = requestLog.MethodInput == null ? JsonConvert.SerializeObject(methodInput) : null;

            try
            {
                 
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
}
