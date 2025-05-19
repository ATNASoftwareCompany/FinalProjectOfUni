using DataAccess;
using DataAccess.Logging.Request;
using DataAccess.Logging.Response;
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
        public BaseResult_VM HandleResponse<T>(Func<T, BaseResult_VM> func, T methodInput, RequestBaseLog_VM requestLog)
        {
            requestLog.MethodInput = JsonConvert.SerializeObject(methodInput);
            BaseResult_VM result = new BaseResult_VM(null, 0, "", DataModel.Enum.ErrorType.Sussess);

            try
            {
                new Request_DL().InserRequest(new RequestBaseLog_VM
                {
                    MethodInput = JsonConvert.SerializeObject(requestLog.MethodInput),
                    GenreId = requestLog.GenreId,
                    CallTime = requestLog.CallTime,
                    Exception = null,
                    MethodId = requestLog.MethodId,
                    MethodOutput = JsonConvert.SerializeObject(result),
                    PointerId = requestLog.PointerId,
                });

                result = func.Invoke(methodInput);
                new Response_DL().InsertResponse(new ResponseBaseLog_VM
                {
                    RequestId = requestLog.RequestId,
                    MethodInput = requestLog.MethodInput,
                    GenreId = requestLog.GenreId,
                    ResponseTime = DateTime.Now,
                    CallTime = requestLog.CallTime,
                    Exception = null,
                    MethodId = requestLog.MethodId,
                    MethodOutput = JsonConvert.SerializeObject(result),
                    PointerId = requestLog.PointerId,
                });
                return result;
            }
            catch (Exception ex)
            {
                new Response_DL().InsertResponse(new ResponseBaseLog_VM
                {
                    RequestId = requestLog.RequestId,
                    MethodInput = requestLog.MethodInput,
                    ResponseTime = DateTime.Now,
                    CallTime = requestLog.CallTime,
                    Exception = ex.Message + "\n StackTrace: " + ex.StackTrace,
                    MethodId = requestLog.MethodId,
                    MethodOutput = ex.Message + "\n StackTrace: " + ex.StackTrace,
                    PointerId = requestLog.PointerId,
                });

                return new BaseResult_VM(null, -100, "خطا در اپلیکیشن", DataModel.Enum.ErrorType.Error);
            }
        }
    }
}
