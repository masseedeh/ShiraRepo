using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiraApplication.Controllers
{
    public class CompanyController : Controller
    {
        

        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCompanyGrid()
        {
            ShiraEntities db = new ShiraEntities();
            //EmployeeEntities edb = new EmployeeEntities();
            // UsersContext u = new UsersContext();  
            var x = db.Company.ToList();
            //var jsonData = new
            //{
            //    total = 1,
            //    page = 1,
            //    records = db.Company.ToList().Count,
            //    rows = (
            //      from company in db.Company.ToList()
            //      select new
            //      {
            //          id = company.CompanyId,
            //          cell = new string[] {
            //            "a","","","","","","","",""
            //        }
            //      }).ToArray()
            //};


            var result = new
            {
                total = db.Company.ToList().Count,
                page = 1,
                records = 2,
                rows = (from company in db.Company.ToList()
                        select new
                        {
                            id = company.CompanyId,
                            RegNo = company.RegestrationNumber,
                            Name = company.Name,
                            Industry = company.IndustryType.Name,
                            Size = company.CompanySize.Name,
                            LineOfDefence = company.LineOfDefence.Name,
                            Address = company.Address,
                            Phone = company.Phone,
                            Logo = company.Logo,
                            ParentId=company.ParentId

                        }).ToArray()
            };
            return Json(result, JsonRequestBehavior.AllowGet);
            
        }

    }
}