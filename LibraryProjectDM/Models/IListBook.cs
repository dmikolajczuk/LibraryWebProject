using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public interface  IListBook
    {
          List<Book> GetListBook(DataClassesDataContext _db);
    }
}