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
        public int InsertActivation(Activation_VM inputModel)
        {
            Activation_VM activation = new Activation_VM
            {
                ActivationCode = inputModel.ActivationCode,
                InsertDate = DateTime.Now,
                IsDelete = false,
                PhoneNo = inputModel.PhoneNo,
                Status = (int)BStatus.Active,
                RemainingTime = DateTime.Now.AddMilliseconds(600),
                UpdateDate = null
            };

            var result = AppDb.Activations.Add(activation);
            AppDb.SaveChanges();
            return result.Id;
        }
    }
}
