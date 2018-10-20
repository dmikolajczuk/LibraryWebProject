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
        private static  DataClassesDataContext _db = new DataClassesDataContext();
        static IListBook _classGetBook = new AllBook(_db);
        List<Book> _listBook = _classGetBook.GetListBook();
        
        

        [HttpGet]
        public ActionResult Index()
        {
            return View(_listBook);
        }


        public RedirectToRouteResult Rent(int id)
        {

            try
            {
                Book b = _db.Books.FirstOrDefault(e => e.Id_Book ==id);
                b.Is_Available = false;
                _db.SubmitChanges();

                int maxIdRent =0;
                if (_db.Rents.Any())
                    maxIdRent = _db.Rents.Max(e => e.ID_Rent);
            

                _db.Rents.InsertOnSubmit(new Rent(id,maxIdRent+1));
                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult UnRent(int id)
        {
            try
            {
                Book b = _db.Books.FirstOrDefault(e => e.Id_Book == id);
                b.Is_Available = true;
                _db.SubmitChanges();



                Rent r = _db.Rents.FirstOrDefault(e => e.ID_Book == id);
                _db.Rents.DeleteOnSubmit(r);
                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index");
        }

        public RedirectToRouteResult Filtr(string Answer)
        {
            FaktoryBook factoryBook = new FaktoryBook(_db);
            _classGetBook = factoryBook.CreateBook(Answer);
            _listBook = _classGetBook.GetListBook();
            return RedirectToAction("Index");
        }
    }
}