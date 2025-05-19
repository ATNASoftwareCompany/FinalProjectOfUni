using DataModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Book
{
    public partial class Book_DL
    {
        public bool DeleteBook(int id)
        {
            var result = GetBook(id);
            result.IsDelete = true;
            result.Status = (int)BStatus.DeActiva;
            return UpdateBook(result);
        }
    }
}
