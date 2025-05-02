using BusinessLogic.Activation;
using BusinessLogic.Common.Methods;
using DataModel.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPresenter
{
    public class AppPresenter 
    {
        Presenter _presenter;
        public AppPresenter()
        {
            _presenter = new Presenter();
        }

        #region Access

        #endregion

        #region Action

        #endregion

        #region Activation
        public BaseResult_VM InsertActivation(Activation_VM inputModel)
        {
            return _presenter.HandleResponse<Activation_VM>(new Activation_BL().InsertActivation, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.PhoneNo),
            });
        }
        #endregion

        #region Person

        #endregion

        #region User

        #endregion



    }
}
