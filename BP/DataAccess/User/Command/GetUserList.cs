using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.User
{
    public partial class User_DL
    {
        public List<User_VM> GetUserList()
        {
            return db.Users.ToList();
        }
    }
}
