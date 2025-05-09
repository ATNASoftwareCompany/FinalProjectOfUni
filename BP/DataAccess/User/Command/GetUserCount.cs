using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.User
{
    public partial class User_DL
    {
        public int GetUserCount()
        {
            return db.Users.Count(); 
        }
    }
}
