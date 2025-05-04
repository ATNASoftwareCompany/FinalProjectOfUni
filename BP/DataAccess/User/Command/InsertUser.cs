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
        public int InsertUser(User_VM inputModel)
        {
            try
            {
                var result = db.Users.Add(inputModel);
                return result.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
    }
}
