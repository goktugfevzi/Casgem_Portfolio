using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialHireMe()
        {
            return PartialView();
        }
        public PartialViewResult PartialWhoAmI()
        {
            var values = db.TblWhoAmI.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialVideoSection()
        {
            var values = db.TblVideoSection.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimational()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureImageURL = db.TblFeature.Select(x => x.FeatureImageURL).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult MyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTypingText()
        {
            var values = db.TblTypingText.ToArray();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x => x.MessageSubject == "Teşekkür").Count();

            return PartialView();
        }
    }
}