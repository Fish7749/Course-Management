using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{

    public class Receipt
    {
        public int receiptId { get; set; }

        [Display(Name = "Total Price")]
        public float totalPrice { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Time")]
        public DateTime timeReceipt { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Register")]
        public int registerId { get; set; }

        public Register Register { get; set; }
    }
}
