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
        public int InsertBook(Book_VM inputModel)
        {
            try
            {
                Book_VM book = new Book_VM
                {
                    Author = inputModel.Author,
                    BookGenre = inputModel.BookGenre,
                    BookTitle = inputModel.BookTitle,
                    DiscountAmount = inputModel.DiscountAmount,
                    DiscountType = inputModel.DiscountType,
                    //HasCollection = inputModel.HasCollection,
                    HasDiscount = inputModel.HasDiscount,
                    IsDelete = false,
                    Price = inputModel.Price,
                    Publisher = inputModel.Publisher,
                    Quantity = inputModel.Quantity,
                    Summary = inputModel.Summary,
                    Status = inputModel.Status,
                    InsertDate = DateTime.Now,
                    WriteDate = inputModel.WriteDate,
                    UpdateDate = null,
                };

                //if (inputModel.Collection.Count > 0)
                //{
                //    book.Collection = inputModel.Collection;
                //}

                var result = appDb.Books.Add(book);
                SaveChanges();

                return result.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
