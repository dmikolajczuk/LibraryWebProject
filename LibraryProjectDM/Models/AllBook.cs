using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public class AllBook : IListBook
    {

        public  List<Book> GetListBook(DataClassesDataContext _db)
        {

            var allBooks = _db.Books.Select(p => p);

            return allBooks.ToList();
        }
    }

}