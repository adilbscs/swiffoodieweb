using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwiftFoodiee.Controllers
{
    public class RestauarntController : Controller
    {
        // GET: Restauarnt
        public ActionResult Index()
        {
            return View();
        }
            public ActionResult Login()
            {
                return View();
            }

        public ActionResult resturentDashBoard()
        {
            return View();
        }

        public ActionResult ResturentManageOder()
        {
            return View();
        }
        public ActionResult ResturentOderHistory()
        {
            return View();
        }
        public ActionResult ResturentOderMenu()
        {
            return View();

        }
        public ActionResult DeliveryBoy()
        {
            return View();
        }


    }
}