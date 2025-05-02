using DataModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logging.Request
{
    public partial class Request_DL
    {
        public long InserRequest(RequestBaseLog_VM inputModel)
        {
            RequestBaseLog_VM request = new RequestBaseLog_VM
            {
                Exception = inputModel.Exception,
                CallTime = inputModel.CallTime,
                MethodId = inputModel.MethodId,
                MethodInput = inputModel.MethodInput,
                PointerId = inputModel.PointerId,
            };

            var result = logDb.RequestLog.Add(request).RequestId;
            SaveChanges();

            return result;
        }
    }
}
