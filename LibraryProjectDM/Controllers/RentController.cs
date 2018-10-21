using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryProjectDM.App_Data;

namespace LibraryProjectDM.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        private DataClassesDataContext _db = new DataClassesDataContext();
        static int book_id;

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            book_id = id;
            return View("Index");
        }

        public RedirectToRouteResult Rent(string name)
        {

            try
            {
                Book b = _db.Books.FirstOrDefault(e => e.Id_Book == book_id);
                b.Is_Available = false;

                User u = _db.Users.FirstOrDefault(s => s.Name.Equals(name));

                if (u == null)
                    return RedirectToAction("ErrorUser");

                int maxIdRent = 0;
                if (_db.Rents.Any())
                    maxIdRent = _db.Rents.Max(e => e.ID_Rent);

                _db.Rents.InsertOnSubmit(new Rent(book_id, maxIdRent + 1, u.ID_User));
                _db.SubmitChanges();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ErrorUser()
        {
            return View("ErrorUsers");
        }
    }
}