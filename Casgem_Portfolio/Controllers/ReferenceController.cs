using Casgem_Portfolio.Models.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            var values = db.TblReference.ToList();
            return View(values);
        }



        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddReference(TblReference p)
        {
            if (Request.Files.Count > 0)
            {
                var path = Path.GetExtension(Request.Files[0].FileName);
                var fileName = Path.GetFileName(Request.Files[0].FileName);
                var physicalPath = Server.MapPath("~/Templates/sidebar-01/images/" + fileName);
                Request.Files[0].SaveAs(physicalPath);
                p.ReferenceImageURL = "/Templates/sidebar-01/images/" + fileName;

            }
            db.TblReference.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            var value = db.TblReference.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReference(TblReference p)
        {
            var value = db.TblReference.Find(p.ReferenceID);
            value.ReferenceName = p.ReferenceName;
            value.ReferenceJob = p.ReferenceJob;
            value.ReferenceContent = p.ReferenceContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}