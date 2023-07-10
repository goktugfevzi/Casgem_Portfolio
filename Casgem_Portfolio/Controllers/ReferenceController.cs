using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        // GET: Reference
        public ActionResult Index()
        {
            var values = db.TblService.ToList();
            return View();
        }
    }
}