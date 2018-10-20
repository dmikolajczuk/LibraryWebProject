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

        public AllBook(DataClassesDataContext db) : base(db)
        {
        }

        public override List<Book> GetListBook()
        {

            var allBooks = _db.Books.Select(p => p);

            return allBooks.ToList();
        }
    }

}