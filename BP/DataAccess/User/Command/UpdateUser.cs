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
        public bool UpdateUser(User_VM inputModel)
        {
            try
            {
                User_VM user = new User_VM
                {
                    Id = inputModel.Id,
                    IsDelete = inputModel.IsDelete,
                    Password = inputModel.Password,
                    Status = inputModel.Status,
                    UpdateDate = DateTime.Now,
                    UserName = inputModel.UserName,
                };

                var result = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
                SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
