﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Book
{
    public partial class Book_DL
    {
        public int GetBooksCount()
        {
			try
			{
                return appDb.Books.Count();
			}
			catch (Exception)
			{
                return -1;
			}
        }
    }
}
