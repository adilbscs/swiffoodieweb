using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftFoodiee.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRestaurant()
        {
            ViewBag.Message = "My Resturent Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ManageRestuarant()
        {
            ViewBag.Message = "manage restaurant page.";

            return View();
        }
        public ActionResult ManageCustomer()
        {
            ViewBag.Message = "manage customer page.";
            return View();
        }
        public ActionResult ManageOrders()
        {
            ViewBag.Message = "manage orders page.";
            return View();
        }
    }
}