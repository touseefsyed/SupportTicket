using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.ViewModels
{
    public class RegisterRequest
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(250)]

        public string Email { get; set; }
        [Required]
        [StringLength(200)]
        public string Password { get; set; }
        [Required]
        [StringLength(200)]
        [Compare(("Password"))]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }


        public static User ToUser(RegisterRequest r)
        {
            var user = new User
            {
                ID= r.ID,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Password = r.Password,
              
                Email = r.Email
               
            };
            return user;
        }


    }
}