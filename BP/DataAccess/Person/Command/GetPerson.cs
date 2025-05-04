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
        public Person_VM GetPerson(Person_VM inputModel)
        {
            return db.Persons.Where(x => x.PhoneNo == inputModel.PhoneNo).FirstOrDefault();
        }
    }
}
