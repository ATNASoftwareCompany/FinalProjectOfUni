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
        public List<Access_VM> GetUserAccessList(int UserId)
        {
            //var tt = appDb.Access.Include(x => x.ActionCode).Where(x => x.UserId == UserId).ToList();
            return appDb.Access.Include(x => x.ActionCode).Where(x => x.UserId == UserId).ToList();
        }
    }
}
