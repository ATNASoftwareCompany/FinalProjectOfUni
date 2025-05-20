using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Access
{
    public partial class Access_DL
    {
        public int InsertAccess(List<Access_VM> inputModel)
        {
            try
            {
                var result = appDb.Access.AddRange(inputModel);
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
