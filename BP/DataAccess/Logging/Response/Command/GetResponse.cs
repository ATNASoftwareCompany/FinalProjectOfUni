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
        public List<ResponseBaseLog_VM> GetResponse()
        {
            return logDb.responseLog.OrderByDescending(x => x.ResponseID).Take(1000).ToList();
        }
    }
}
