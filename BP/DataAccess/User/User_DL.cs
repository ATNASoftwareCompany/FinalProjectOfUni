using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.User
{
    public partial class User_DL
    {
        AppDb db = new AppDb();
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
