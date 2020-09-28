using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public virtual Customer Customer { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
