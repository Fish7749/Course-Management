using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Register
    {
        public int registerId { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime timeReg { get; set; }

        [Display(Name = "Customer name")]
        [Required(ErrorMessage = "Phải chọn {0}")]
        public string userId { get; set; }

        public AppUser AppUser { get; set; }


        [Display(Name = "Course name")]
        [Required(ErrorMessage = "Phải chọn {0}")]
        public int courseId { get; set; }  

        public Course Course { get; set; }

        public ICollection<Receipt> Receipts { get; set; }
    }
}
