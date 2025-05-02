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
        public User_VM GetUser(User_VM inputModel)
        {
            return db.Users.Where(x => x.UserName == inputModel.UserName).FirstOrDefault();
        }
    }
}
