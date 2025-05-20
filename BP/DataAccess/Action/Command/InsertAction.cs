using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Action
{
    public partial class Action_DL
    {
        public int InsertAction(List<Action_VM> inputModel)
        {
			try
			{
                var result = db.Actions.AddRange(inputModel);
                SaveChanges();
                return 0;
			}
			catch (Exception)
			{
                return -1;
			}
        }
    }
}
