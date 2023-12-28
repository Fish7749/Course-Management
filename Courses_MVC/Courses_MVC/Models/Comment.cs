using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Comment
    {
        [Display(Name = "Comment code")]
        public int cmtId { get; set; }

        [Display(Name = "User name")]
        [Required(ErrorMessage = "You must enter {0}")]
        public string userId { get; set; }
        
        public AppUser AppUser { get; set; }

        [Display(Name = "Course name")]
        [Required(ErrorMessage = "You must enter {0}")]
        public int courseId { get; set; }

        public Course Course { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "You must enter {0}")]
        public string content { get; set; }

        [Display(Name = "Rating")]
        [Range(0,10,ErrorMessage = "{0} must be from 0 to 10 points")]
        [Required(ErrorMessage = "You must enter {0}")]
        public float evaluate { get; set; }   

        
    }
}
