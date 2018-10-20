using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public abstract class IListBook
    {
        protected DataClassesDataContext _db;

        protected IListBook(DataClassesDataContext db)
        {
            this._db = db;
        }

        public abstract List<Book> GetListBook();
    }
}