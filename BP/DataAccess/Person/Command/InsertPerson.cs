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
                var result = db.Persons.Add(inputModel);
                return result.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
