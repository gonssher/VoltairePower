using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class UnplaanedEvent
    {


        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "Please Enter even Description")]
        [Display(Name = "Event Description", Prompt = "Event Description")]
        public string EventDescription { get; set; }


        [Required(ErrorMessage = "Please Enter the cause of the Event")]
        [Display(Name = "Event Cause", Prompt = "Event Cause")]

        public string EventCause { get; set; }



        [Required(ErrorMessage = "Please Enter the Self Action Taken")]
        [Display(Name = "Self Action", Prompt = "Self Action")]

        public string SelfActionTaken { get; set; }



        [Required(ErrorMessage = "Please Enter the cause of the Event")]
        [Display(Name = "Result", Prompt = "Result")]

        public string Result { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }



    }
}
