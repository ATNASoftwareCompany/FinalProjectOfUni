using DataAccess.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Person
{
    public partial class Person_BL
    {
        Person_DL Person_DL;
        public Person_BL()
        {
            Person_DL = new Person_DL();
        }
    }
}
