using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketManagementSystem.Models
{
    public class TicketDbContext : DbContext
    {

       
            public DbSet<User> Users { get; set; }
           
            public TicketDbContext() : base("name=DefaultConnectionString")
            {

            }
        }
    
}