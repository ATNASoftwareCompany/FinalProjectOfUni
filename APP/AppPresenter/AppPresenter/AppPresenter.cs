using BusinessLogic.Activation;
using BusinessLogic.Book;
using BusinessLogic.BookAuthor;
using BusinessLogic.BookGenre;
using BusinessLogic.BookPublisher;
using BusinessLogic.Common.Methods;
using BusinessLogic.Person;
using BusinessLogic.SMS;
using BusinessLogic.User;
using DataModel;
using DataModel.ViewModel;
using System;

using Newtonsoft.Json;

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
                PointerId = Convert.ToInt64(inputModel.ActivationCode),
            });
        }

        public BaseResult_VM UserAuthentication(string phoneNo)
        {
            return _presenter.HandleResponse(new Activation_BL().UserAuthentication, phoneNo, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(phoneNo),
                PointerId = Convert.ToInt64(phoneNo),
            });
        }

        public BaseResult_VM GetActivationByPhoneNo(string phoneNo)
        {
            return _presenter.HandleResponse(new Activation_BL().GetActivationByPhoneNo, phoneNo, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(phoneNo),
                PointerId = Convert.ToInt64(phoneNo),
            });
        }

        public BaseResult_VM UpdateActivation(Activation_VM inputModel)
        {
            return _presenter.HandleResponse(new Activation_BL().UpdateActivation, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.ActivationCode),
            });
        }
        #endregion

        #region Person
        public BaseResult_VM InsertPerson(Person_VM inputModel)
        {
            return _presenter.HandleResponse(new Person_BL().InsertPerson, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.PhoneNo),
            });
        }
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
                PointerId = Convert.ToInt64(inputModel.UserName),
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
                PointerId = Convert.ToInt64(inputModel.UserName),
            });
        }

        public BaseResult_VM GetUsersCount(int book)
        {
            return _presenter.HandleResponse(new User_BL().GetUsersCount, book, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(book),
                PointerId = Convert.ToInt64(book),
            });
        }

        public BaseResult_VM InsertUser(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().InsertUser, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM UpdateUser(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().UpdateUser, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        #endregion

        #region Book
        public BaseResult_VM GetBooksCount(int book)
        {
            return _presenter.HandleResponse(new Book_BL().GetBooksCount, book, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(book),
                PointerId = Convert.ToInt64(book),
            });
        }

        
        #endregion

        #region bookPublisher
        public BaseResult_VM InsertBookPublisher(BookPublisher_VM inputModel)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().InsertBookPublisher, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetAllPublishers(BookPublisher_VM inputModel)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().GetAllPublishers, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }


        #endregion

        #region BookAuthor
        public BaseResult_VM InsertBookAuthor(BookAuthor_VM inputModel)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().InsertBookAuthor, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetAllBookAuthor(BookAuthor_VM inputModel)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().GetAllBookAuthor, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }
        #endregion

        #region BookGenre
        public BaseResult_VM InsertBookGenre(BookGenre_VM inputModel)
        {
            return _presenter.HandleResponse(new BookGenre_BL().InsertBookGenre, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetAllBookGenre(BookGenre_VM inputModel)
        {
            return _presenter.HandleResponse(new BookGenre_BL().GetAllBookGenre, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }
        #endregion

        #region SMS
        public BaseResult_VM SendSms(Sms_VM inputModel)
        {
            return _presenter.HandleResponse(new Sms_BL().SendSms, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertActivation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.PhoneNo),
            });
        }
        #endregion

    }
}
