using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Access
{
    public partial class Access_DL
    {
        public bool CheckAccess(Access_VM inputModel)
        {
            var result = appDb.Access.Include(x => x.ActionCode).Where(x => x.ActionCode.ActionCode == inputModel.ActionCode.ActionCode && x.UserId == inputModel.UserId).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
