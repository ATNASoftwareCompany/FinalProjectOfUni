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
        public bool UpdateAccessList(List<Access_VM> AccessIds)
        {
            foreach (var item in AccessIds)
            {
                var access = GetAccessById(item.Id);
                if(access == null)
                {
                    continue;
                }
                access.Status = item.Status;
                access.UpdateDate = DateTime.Now;
                SaveChanges();
            }
            return true;
        }
    }
}
