using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Course
    {
        public int courseId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Course Name")]
        public string courseName { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Describe")]
        public string discription { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Listed Price")]
        public int price { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Price")]
        public int originalPrice { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Image")]
        public string imgCourse { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Duration")]
        public string totalTime { get; set; }

        
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Rating")]
        public int rating { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Total students")]
        public int totalStudent { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Title")]
        public int topicId { get; set; }
        public Topic Topic { get; set;}

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Discount")]
        public int discountId { get; set; }
        public Discount Discount { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Register> Registers { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
