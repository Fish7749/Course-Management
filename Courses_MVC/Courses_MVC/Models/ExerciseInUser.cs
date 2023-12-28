using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class ExerciseInUser
    {
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Assignment")]
        public int exerciseId { get; set; }

        
        public Exercise Exercise { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "User Name")]
        public string userId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Content")]
        public string content { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        
        [Display(Name = "Status")]
        public string status { get; set; }

        public AppUser AppUser { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Submit Time")]
        public DateTime submit { get; set; }

        [Display(Name = "Score")]
        [Range(0,10,ErrorMessage = "{0} must be on a scale of 0 to 10")]
        public float scores { get; set; }

    }
}
