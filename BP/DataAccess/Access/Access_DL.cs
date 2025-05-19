using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Access
{
    public partial class Access_DL
    {
        AppDb appDb = new AppDb();
        public void SaveChanges()
        {
            appDb.SaveChanges();
        }
    }
}
