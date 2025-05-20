using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Action
{
    public partial class Action_DL
    {
        public int GetCountOfActions()
        {
            return db.Actions.Count();
        }
    }
}
