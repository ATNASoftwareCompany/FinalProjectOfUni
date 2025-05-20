using DataAccess.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Access
{
    public partial class Access_BL
    {
        Access_DL Access_DL;
        public Access_BL()
        {
            Access_DL = new Access_DL();
        }
    }
}
