using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Book
{
    public partial class Book_DL
    {
        public bool UpdateBook(Book_VM inputModel)
        {
            Book_VM book = GetBook(inputModel.Id);
            if (book == null)
            {
                return false;
            }

            book.UpdateDate = DateTime.Now;
            book.WriteDate = inputModel.WriteDate;
            book.IsDelete = inputModel.IsDelete;
            book.InsertDate = inputModel.InsertDate;
            book.HasDiscount = inputModel.HasDiscount;
            book.Status = inputModel.Status;
            book.Author = inputModel.Author;
            book.Quantity = inputModel.Quantity;
            book.Price = inputModel.Price;
            book.BookGenre = inputModel.BookGenre;
            book.BookTitle = inputModel.BookTitle;
            book.DiscountAmount = inputModel.DiscountAmount;
            book.DiscountType = inputModel.DiscountType;
            book.Publisher = inputModel.Publisher;
            book.Summary = inputModel.Summary;
            
            SaveChanges();
            return true;
        }
    }
}
