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
        public int InsertPerson(Person_VM inputModel)
        {
            try
            {
                Person_VM person = new Person_VM
                {
                    BirthDate = inputModel.BirthDate,
                    E_Mail = inputModel.E_Mail,
                    Family = inputModel.Family,
                    InsertDate = DateTime.Now,
                    IsDelete = false,
                    Name = inputModel.Name,
                    PhoneNo = inputModel.PhoneNo,
                    Status = inputModel.Status,
                    UpdateDate = DateTime.Now,
                };
                var result = db.Persons.Add(person);
                SaveChanges();
                return result.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
