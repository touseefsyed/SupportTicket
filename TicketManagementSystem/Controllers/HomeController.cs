using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult DashBoard()
        {
            return View();
        }


        public ActionResult GetUsers()
        {
            return View();
        }
    }

}