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
        public Access_VM GetAccessById(int id)
        {
            return appDb.Access.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
