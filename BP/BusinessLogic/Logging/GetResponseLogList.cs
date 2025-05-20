using DataAccess.Logging.Response;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logging
{
    public class GetLogList
    {
        public BaseResult_VM GetResponseLogList(int id)
        {
            return new BaseResult_VM(new Response_DL().GetResponse(), 0, "", DataModel.Enum.ErrorType.Sussess);
        }
    }
}
