using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Models
{
    public class FaktoryBook
    {
        public DataClassesDataContext _db;

        public FaktoryBook(DataClassesDataContext db)
        {
            this._db = db;
        }
        public IListBook CreateBook(string s)
        {
            if (s.Equals("Rent"))
            {
                return new RentBook();
            }
            else if (s.Equals("Available"))
            {
                return new AvailableBook();
            }
            else
            {
                return new AllBook();
            }

        }
    }
}