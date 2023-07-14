using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialHeader()
        {
            var values = db.TblAboutHeader.FirstOrDefault();
            return PartialView(values);
        }
        public ActionResult PartialAbout()
        {
            var values = db.TblAboutPartial.FirstOrDefault();
            return PartialView(values);
        }
        public ActionResult PartialSection()
        {
            var values = db.TblAboutSection.ToList();
            return PartialView(values);
        }
        public ActionResult PartialAbilities()
        {
            return PartialView();
        }
        public ActionResult PartialAwards() { return PartialView(); }
        public ActionResult PartilFooter() { return PartialView(); }
        public ActionResult PartialScript() { return PartialView(); }
    }
}
