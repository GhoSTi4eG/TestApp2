using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp2.Models;

namespace TestApp2.Controllers
{
    public class HomeController : Controller
    {
        EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "Описание тестового приложения";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Список контактов телефонного справочника";
            return View(db.Contact);

    }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}