using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryProjectDM.App_Data;
using LibraryProjectDM.Models;

namespace LibraryProjectDM.Controllers
{
    public class HomeController : Controller
    {
        DataClassesDataContext _db = new DataClassesDataContext();
        static IListBook _classGetBook = new AllBook();
        private List<Book> _listBook;
        
        

        [HttpGet]
        public ActionResult Index()
        {
            _listBook = _classGetBook.GetListBook(_db);

            return View(_listBook);
        }

        public RedirectToRouteResult UnRent(int id)
        {
            try
            {
                Book b = _db.Books.FirstOrDefault(e => e.Id_Book == id);
                b.Is_Available = true;

                Rent r = _db.Rents.FirstOrDefault(e => e.ID_Book == id);
                _db.Rents.DeleteOnSubmit(r);
                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index","Home");
        }

        public RedirectToRouteResult Filtr(string Answer)
        {
            FaktoryBook factoryBook = new FaktoryBook(_db);
            _classGetBook = factoryBook.CreateBook(Answer);

            return RedirectToAction("Index");
        }
    }
}