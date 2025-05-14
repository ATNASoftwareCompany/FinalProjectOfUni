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
        public bool UpdateActivation(Activation_VM inputModel)
        {
            var result = AppDb.Activations.Where(x => x.Id == inputModel.Id).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            result.Status = inputModel.Status;
            result.UpdateDate = DateTime.Now;
            result.IsDelete = inputModel.IsDelete;
            result.RemainingTime = DateTime.Now;
            AppDb.SaveChanges();
            return true;
        }
    }
}
