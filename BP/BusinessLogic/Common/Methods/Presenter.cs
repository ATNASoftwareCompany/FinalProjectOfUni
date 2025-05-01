using DataAccess;
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
            LogDb logDb = new LogDb();
            requestLog.MethodInput = requestLog.MethodInput == null ? JsonConvert.SerializeObject(methodInput) : null;

            try
            {
                requestLog = new RequestBaseLog_VM
                {
                    CallTime = DateTime.Now,

                };
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
}
