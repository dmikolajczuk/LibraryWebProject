using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public class AvailableBook : IListBook
    {

        public  List<Book> GetListBook(DataClassesDataContext _db)
        {

            var rentBooks = _db.Books.Where(p => p.Is_Available == true);

            return rentBooks.ToList();
        }
    }
}