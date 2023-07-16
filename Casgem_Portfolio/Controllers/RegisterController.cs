using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class RegisterController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblUser p)
        {
            db.TblUser.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Login");

        }
    }
}


