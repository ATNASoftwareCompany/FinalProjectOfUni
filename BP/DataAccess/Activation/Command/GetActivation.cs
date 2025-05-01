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
        public Activation_VM GetActivation(Activation_VM inputModel)
        {
           return AppDb.Activations.Where(x => x.ActivationCode == inputModel.ActivationCode).FirstOrDefault();
        }
    }
}
