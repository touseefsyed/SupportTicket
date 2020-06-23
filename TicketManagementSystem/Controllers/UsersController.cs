using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketManagementSystem.Models;
using TicketManagementSystem.ViewModels;

namespace TicketManagementSystem.Controllers
{
    public class UsersController : Controller
    {
       
        public UsersController()
        {
            TicketDbContext = new TicketDbContext();
        }
         public TicketDbContext TicketDbContext;
        // GET: Users
        public ActionResult UserList()
        {
            var userList = TicketDbContext.Users.ToList();
            return View(new UserListViewModel { Users = userList });
           
        }
    }
}