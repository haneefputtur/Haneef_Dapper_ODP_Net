using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Haneef_Dapper_ODP.Models;
using Haneef_Dapper_ODP.Utilities;

namespace Haneef_Dapper_ODP.Controllers
    {
    public class HomeController : Controller
        {
        public ActionResult Index()
            {
            return View();
            }

        public ActionResult About()
            {
            ViewBag.Message = "Your application description page.";

            return View();
            }

        public ActionResult Contact()
            {
            ViewBag.Message = "Your contact page.";

            return View();
            }


        public ActionResult Employee()
            {

            List<Employee> emp = new List<Employee>();

            string pdept = "Computer";

            emp = function.emp_list(pdept);
     

            return View(emp);
            }

       
        }
    }