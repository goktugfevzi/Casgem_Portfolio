using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.contactTitle = db.TblContacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactPhoneNumber = db.TblContacts.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.contactEMail = db.TblContacts.Select(x => x.EMail).FirstOrDefault();
            ViewBag.contactAddress = db.TblContacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }
    }
}