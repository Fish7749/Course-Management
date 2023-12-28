using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Lesson
    {
        public int lessonId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Describe")]
        public string description { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Content")]
        public string content { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Lesson link")]
        public string link { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Caption")]
        public string captionLink { get; set; }


        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Course")]
        public int courseId { get; set; }

        public Course Course { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}
