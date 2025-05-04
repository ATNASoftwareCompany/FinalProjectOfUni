using BusinessLogic.Activation;
using BusinessLogic.Common.Methods;
using BusinessLogic.User;
using DataModel;
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
            return _presenter.HandleResponse(new Activation_BL().InsertActivation, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = inputModel.PhoneNo,
            });
        }
        #endregion

        #region Person

        #endregion

        #region User
        /// <summary>
        /// دریافت اطلاعات یک یوزر
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        public BaseResult_VM GetUserSingle(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().GetUserSingle, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetUserSingle,
                GenreId = DataModel.Enum.GenreType.User,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = inputModel.UserName,
            });
        }


        public BaseResult_VM GetUserSinglee(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().GetUserSingle, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetUserSingle,
                GenreId = DataModel.Enum.GenreType.User,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = inputModel.UserName,
            });
        }

        #endregion



    }
}
