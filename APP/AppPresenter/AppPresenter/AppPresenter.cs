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
using BusinessLogic;
using System.Collections.Generic;

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
                GenreId = DataModel.Enum.GenreType.Activation,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.ActivationCode),
            });
        }

        public BaseResult_VM UserAuthentication(string phoneNo)
        {
            return _presenter.HandleResponse(new Activation_BL().UserAuthentication, phoneNo, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UserAuthentication,
                GenreId = DataModel.Enum.GenreType.Activation,
                MethodInput = JsonConvert.SerializeObject(phoneNo),
                PointerId = Convert.ToInt64(phoneNo),
            });
        }

        public BaseResult_VM GetActivationByPhoneNo(string phoneNo)
        {
            return _presenter.HandleResponse(new Activation_BL().GetActivationByPhoneNo, phoneNo, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetActivationByPhoneNo,
                GenreId = DataModel.Enum.GenreType.Activation,
                MethodInput = JsonConvert.SerializeObject(phoneNo),
                PointerId = Convert.ToInt64(phoneNo),
            });
        }

        public BaseResult_VM UpdateActivation(Activation_VM inputModel)
        {
            return _presenter.HandleResponse(new Activation_BL().UpdateActivation, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateActivation,
                GenreId = DataModel.Enum.GenreType.Activation,
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
                MethodId = DataModel.Enum.MethodsType.InsertPerson,
                GenreId = DataModel.Enum.GenreType.Person,
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
                MethodId = DataModel.Enum.MethodsType.GetUserSinglee,
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
                MethodId = DataModel.Enum.MethodsType.GetUsersCount,
                GenreId = DataModel.Enum.GenreType.User,
                MethodInput = JsonConvert.SerializeObject(book),
                PointerId = Convert.ToInt64(book),
            });
        }

        public BaseResult_VM InsertUser(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().InsertUser, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertUser,
                GenreId = DataModel.Enum.GenreType.User,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM UpdateUser(User_VM inputModel)
        {
            return _presenter.HandleResponse(new User_BL().UpdateUser, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateUser,
                GenreId = DataModel.Enum.GenreType.User,
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
                MethodId = DataModel.Enum.MethodsType.GetBooksCount,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(book),
                PointerId = Convert.ToInt64(book),
            });
        }

        public BaseResult_VM GetBookById(int book)
        {
            return _presenter.HandleResponse(new Book_BL().GetBookById, book, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetBookById,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(book),
                PointerId = Convert.ToInt64(book),
            });
        }

        public BaseResult_VM InsertBook(Book_VM inputModel)
        {
            return _presenter.HandleResponse(new Book_BL().InsertBook, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertBook,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM UpdateBook(Book_VM inputModel)
        {
            return _presenter.HandleResponse(new Book_BL().UpdateBook, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateBook,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM DeleteBook(int id)
        {
            return _presenter.HandleResponse(new Book_BL().DeleteBook, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.DeleteBook,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM BookNameSearch(string text)
        {
            return _presenter.HandleResponse(new Book_BL().BookNameSearch, text, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.BookNameSearch,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(text),
                //PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetBooksListForShow(Book_VM inputModel)
        {
            return _presenter.HandleResponse(new Book_BL().GetBooksListForShow, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetBooksListForShow,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        #endregion

        #region bookPublisher
        public BaseResult_VM InsertBookPublisher(BookPublisher_VM inputModel)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().InsertBookPublisher, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertBookPublisher,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetPublisherName(int id)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().GetPublisherName, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetPublisherName,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetBookPublisher(int id)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().GetBookPublisher, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetBookPublisher,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetAllPublishers(BookPublisher_VM inputModel)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().GetAllPublishers, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetAllPublishers,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM UpdateBookPublisher(BookPublisher_VM inputModel)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().UpdateBookPublisher, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateBookPublisher,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM PublisherNameSearch(string text)
        {
            return _presenter.HandleResponse(new BookPublisher_BL().PublisherNameSearch, text, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.PublisherNameSearch,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(text),
                //PointerId = Convert.ToInt64(id),
            });
        }


        #endregion

        #region BookAuthor
        public BaseResult_VM InsertBookAuthor(BookAuthor_VM inputModel)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().InsertBookAuthor, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.InsertBookAuthor,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetAuthorName(int id)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().GetAuthorName, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetAuthorName,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM AuthorNameSearch(string text)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().AuthorNameSearch, text, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.AuthorNameSearch,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(text),
                //PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetBookAuthor(int id)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().GetBookAuthor, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetBookAuthor,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetAllBookAuthor(BookAuthor_VM inputModel)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().GetAllBookAuthor, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetAllBookAuthor,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM UpdateBookAuthor(BookAuthor_VM inputModel)
        {
            return _presenter.HandleResponse(new BookAuthor_BL().UpdateBookAuthor, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateBookAuthor,
                GenreId = DataModel.Enum.GenreType.Book,
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
                MethodId = DataModel.Enum.MethodsType.InsertBookGenre,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetGenreName(int id)
        {
            return _presenter.HandleResponse(new BookGenre_BL().GetGenreName, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetGenreName,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GetBookGenre(int id)
        {
            return _presenter.HandleResponse(new BookGenre_BL().GetBookGenre, id, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetBookGenre,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(id),
                PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM GenreNameSearch(string text)
        {
            return _presenter.HandleResponse(new BookGenre_BL().GenreNameSearch, text, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GenreNameSearch,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(text),
                //PointerId = Convert.ToInt64(id),
            });
        }

        public BaseResult_VM UpdateBookGenre(BookGenre_VM inputModel)
        {
            return _presenter.HandleResponse(new BookGenre_BL().UpdateBookGenre, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.UpdateBookGenre,
                GenreId = DataModel.Enum.GenreType.Book,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.Id),
            });
        }

        public BaseResult_VM GetAllBookGenre(BookGenre_VM inputModel)
        {
            return _presenter.HandleResponse(new BookGenre_BL().GetAllBookGenre, inputModel, new DataModel.Logging.RequestBaseLog_VM
            {
                CallTime = DateTime.Now,
                MethodId = DataModel.Enum.MethodsType.GetAllBookGenre,
                GenreId = DataModel.Enum.GenreType.Book,
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
                MethodId = DataModel.Enum.MethodsType.SendSms,
                GenreId = DataModel.Enum.GenreType.SMS,
                MethodInput = JsonConvert.SerializeObject(inputModel),
                PointerId = Convert.ToInt64(inputModel.PhoneNo),
            });
        }
        #endregion

        #region Common
        
        #endregion

    }
}
