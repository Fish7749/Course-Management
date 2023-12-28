using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Contact
    {
        public int contactId { get; set; }

        [Display(Name = "Username")]
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public string HoTen { get; set; }

        [Display(Name ="Email")]
        [EmailAddress(ErrorMessage = "Email must be in correct format")]
        public string  email { get; set; }

        [Display(Name = "Phone number")]
        [Phone]
        [StringLength(100, ErrorMessage = "{0} must be at least {1} characters.")]
        [Required(ErrorMessage = "You must enter phone number")]
        public string  SDT { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Content")]
        public string content { get; set; }

        [Display(Name = "Written date")]
        public DateTime time { get; set; }
    }
}
