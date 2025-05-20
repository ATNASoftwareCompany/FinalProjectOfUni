using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Access
{
    public partial class Access_DL
    {
        public Access_VM GetAccess(Access_VM inputModel)
        {
            return appDb.Access.Where(x => x.ActionCode.ActionCode == inputModel.ActionCode.ActionCode && x.UserId == inputModel.UserId).FirstOrDefault();
        }
    }
}
