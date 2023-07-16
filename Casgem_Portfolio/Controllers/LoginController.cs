using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblUser user)
        {

            var values = db.TblUser.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                return RedirectToAction("Index", "Message");
            }
            else { return View(); }
        }
    }
}