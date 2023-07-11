using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.TblEmployee.Count();
            ViewBag.maxSalaryEmployee = db.TblEmployee.Where(x => x.EmployeeSalary == db.TblEmployee.Max(y => y.EmployeeSalary)).Select(x => x.EmployeeName).FirstOrDefault();
            ViewBag.totalCityCount = db.TblEmployee.Select(x => x.EmployeeCity).Distinct().Count();
            ViewBag.avgEmployeeSalary = db.TblEmployee.Average(x => x.EmployeeSalary);
            ViewBag.countSoftwareDepartment = db.TblEmployee.Where(x => x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentID).FirstOrDefault()).Count();
            ViewBag.cityQuery = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" || x.EmployeeCity == "Adana").Sum(y => y.EmployeeSalary);
            //ViewBag.ankaraQuery= db.TblEmployee.Where(x => x.EmployeeDepartment == db.TblDepartment.Where(z=>z.DepartmentName=="Yazılım").Select(y=>y.DepartmentID).Where(y=)
            return View();
        }
    }
}