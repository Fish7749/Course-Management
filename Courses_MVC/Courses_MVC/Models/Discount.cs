using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Discount
    {
        public int discountId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Discription")]
        public string? discription { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Time")]
        public DateTime time { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Amout")]
        public float sale { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
