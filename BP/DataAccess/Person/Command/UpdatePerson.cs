using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Person
{
    public partial class Person_DL
    {
        public bool UpdatePerson(Person_VM inputModel)
        {
            try
            {
                Person_VM user = new Person_VM
                {
                    Id = inputModel.Id,
                    IsDelete = inputModel.IsDelete,
                    Status = inputModel.Status,
                    UpdateDate = DateTime.Now,
                    PhoneNo = inputModel.PhoneNo,
                    BirthDate = inputModel.BirthDate,
                    E_Mail = inputModel.E_Mail,
                    Family = inputModel.Family,
                    Name = inputModel.Name,
                };

                var result = db.Persons.Where(x => x.Id == user.Id).FirstOrDefault();
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
