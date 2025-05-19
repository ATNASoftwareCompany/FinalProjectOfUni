using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Enum
{
    public enum AccessType
    {

        [Description("دریافت اطلاعات کاربر")]
        GetUserSingle = 10001,

        [Description("اعتبارسنجی کاربر")]
        UserAuthentication = 10002,

        [Description("دریافت کد فعالسازی با شماره تلفن همراه")]
        GetActivationByPhoneNo = 10003,

        [Description("بروزرسانی کد فعالسازی")]
        UpdateActivation = 10004,

        [Description("درج شخص")]
        InsertPerson = 10005,

        [Description("دریافت اطلاعات کاربر")]
        GetUserSinglee = 10006,

        [Description("دریافت تعداد کاربران")]
        GetUsersCount = 10007,

        [Description("درج کاربر")]
        InsertUser = 10008,

        [Description("بروزرسانی کاربر")]
        UpdateUser = 10009,

        [Description("دریافت تعداد کتاب ها")]
        GetBooksCount = 10010,

        [Description("دریافت اطلاعات کتاب")]
        GetBookById = 10011,

        [Description("درج کتاب")]
        InsertBook = 10012,

        [Description("بروزرسانی کتاب")]
        UpdateBook = 10013,

        [Description("حذف کتاب")]
        DeleteBook = 10014,

        [Description("جستجوی کتاب بر اساس حروف")]
        BookNameSearch = 10015,

        [Description("دریافت لیست کتاب ها")]
        GetBooksListForShow = 10016,

        [Description("درج ناشر")]
        InsertBookPublisher = 10017,

        [Description("دریافت نام ناشر")]
        GetPublisherName = 10018,

        [Description("دریافت اطلاعات ناشر")]
        GetBookPublisher = 10019,

        [Description("دریافت لیست تمامی ناشر ها")]
        GetAllPublishers = 10020,

        [Description("بروزرسانی ناشر")]
        UpdateBookPublisher = 10021,

        [Description("جستجوی ناشران بر اساس نام")]
        PublisherNameSearch = 10022,

        [Description("درج نویسنده")]
        InsertBookAuthor = 10023,

        [Description("دریافت اطلاعات نویسنده")]
        GetAuthorName = 10024,

        [Description("جستجوی نویسندگان بر اساس نام")]
        AuthorNameSearch = 10025,

        [Description("دریافت نویسنده")]
        GetBookAuthor = 10026,

        [Description("دریافت اطلاعات تمام نویسندگان")]
        GetAllBookAuthor = 10027,

        [Description("بروزرسانی نویسنده")]
        UpdateBookAuthor = 10028,

        [Description("درج ژانر")]
        InsertBookGenre = 10029,

        [Description("دریافت نام ژانر")]
        GetGenreName = 10030,

        [Description("دریافت ژانر")]
        GetBookGenre = 10031,

        [Description("جستجوی ژانر بر اساس نام")]
        GenreNameSearch = 10032,

        [Description("بروزرسانی ژانر")]
        UpdateBookGenre = 10033,

        [Description("دریافت لیست ژانر ها")]
        GetAllBookGenre = 10034,

        [Description("ارسال پیامک")]
        SendSms = 10035,
    }
}
