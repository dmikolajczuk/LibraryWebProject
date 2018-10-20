using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public class AvailableBook : IListBook
    {
        public AvailableBook(DataClassesDataContext db) : base(db)
        {
        }

        public override List<Book> GetListBook()
        {

            var rentBooks = _db.Books.Where(p => p.Is_Available == true);

            return rentBooks.ToList();
        }
    }
}