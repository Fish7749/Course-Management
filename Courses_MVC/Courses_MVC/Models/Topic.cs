using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Topic
    {
        public int topicId { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Topic Name")]
        public string topicName { get; set; }
        public ICollection<Course> Course { get; set; }

    }
}
