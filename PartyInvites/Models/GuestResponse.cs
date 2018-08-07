using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "enter email")]
        [RegularExpression(".+\\@.+\\..+", 
            ErrorMessage = "enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "enter your number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "u attend or what?")]
        public bool? WillAttend { get; set; }
    }
}