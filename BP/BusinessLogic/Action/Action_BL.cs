using DataAccess.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Action
{
    public partial class Action_BL
    {
        Action_DL Action_DL;
        public Action_BL()
        {
            Action_DL = new Action_DL();
        }
    }
}
