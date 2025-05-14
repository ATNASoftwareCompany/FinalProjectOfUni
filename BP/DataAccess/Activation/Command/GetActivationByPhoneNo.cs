using DataModel.Enum;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Activation
{
    public partial class Activation_DL
    {
        public Activation_VM GetActivationByPhoneNo(string phoneNo)
        {
            return AppDb.Activations.Where(x => x.PhoneNo == phoneNo && x.Status == (int)BStatus.Active).FirstOrDefault();
        }
    }
}
