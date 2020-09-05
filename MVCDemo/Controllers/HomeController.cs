using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    /// <summary>
    /// Controller link between a View and the Webpage
    /// HomeController means that under Views there will be a Home View which all Action Results are linked to
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// the View will be under Views -> Home -> Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// the View will be under Views -> Home -> About
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// the View will be under Views -> Home -> Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}