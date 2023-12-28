using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Exercise
    {
        public int exerciseId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Assignment Name")]
        public string exerciseName { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Content")]
        public string content { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Input")]
        public string input { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Output")]
        public string output { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Deadline")]
        public DateTime deadline { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Lesson Name")]
        public int lessonId { get; set; }

        public Lesson Lesson { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Owner")]
        public string userId { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<ExerciseInUser> ExerciseInUsers { get; set; }
    }
}
