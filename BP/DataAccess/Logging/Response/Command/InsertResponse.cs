using DataModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logging.Response
{
    public partial class Response_DL
    {
        public long InsertResponse(ResponseBaseLog_VM inputModel)
        {
            ResponseBaseLog_VM responseModel = new ResponseBaseLog_VM
            {
                Exception = inputModel.Exception,
                RequestId = inputModel.RequestId,
                MethodId = inputModel.MethodId,
                MethodInput = inputModel.MethodInput,
                MethodOutput = inputModel.MethodOutput,
                PointerId = inputModel.PointerId,
                ResponseTime = inputModel.ResponseTime,
            };

            var result = logDb.responseLog.Add(responseModel).ResponseID;
            SaveChanges();
            return result;
        }
    }
}
