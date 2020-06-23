using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketManagementSystem.Models;
using TicketManagementSystem.ViewModels;

namespace TicketManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
            TicketDbContext = new TicketDbContext();
        }

        public TicketDbContext TicketDbContext;

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginRequest request)
        {

            if (ModelState.IsValid)
            {

                var userRequest = TicketDbContext.Users.FirstOrDefault(x => x.Email == request.Email && x.Password == request.Password);
                if (userRequest != null)
                {
                    Session["FullName"] = userRequest.FirstName;
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterRequest request)
        {

            if (ModelState.IsValid) {
                User user = new User
            {
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
               
            };

           
            TicketDbContext.Users.Add(user);
            TicketDbContext.SaveChanges();
            }
            return View();
        }
    }
}