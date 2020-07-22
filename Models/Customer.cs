using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(22)]
        [MinLength(1)]
        [Required(ErrorMessage = "Please make your first Initials Capital")]
        [Display(Name = "Full Name", Prompt = "Full Name", Description = "Customer Full Name")]
        [RegularExpression("^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$", ErrorMessage = "Please enter a valid name")]
        public string CustName { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter digits only")]
        [Display(Name = "Phone Number", Prompt = "Phone Number")]
        public string Mobile { get; set; }

        [Display(Name = "Email", Prompt = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Unit No.", Prompt = "Unit No.")]
        public string UnitNumber { get; set; }

        [Required(ErrorMessage = "Please enter the street number")]
        [Range(10, 99999)]
        [Display(Name = "Street No.", Prompt = "Street No.")]
        public int StreetNumber { get; set; }

        [Required(ErrorMessage = "Please enter the street name")]
        [MaxLength(11)]
        [MinLength(2)]
        [Display(Name = "Street Name", Prompt = "Street Name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please enter the postal code")]
        [MinLength(3)]
        [Display(Name = "Postal Code", Prompt = "Postal Code")]
        public string PostalCode { get; set; }

        [MaxLength(10)]
        [MinLength(9)]
        [Required(ErrorMessage = "Please enter the password")]
        [Display(Name = "Password", Prompt = "Password")]
        public string Password { get; set; }

        [MaxLength(10)]
        [MinLength(9)]
        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password", Prompt = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DefaultValue(false)]
        public bool IsCompletedReg { get; set; }

        public virtual ICollection<Login> Logins { get; set; }

        public CheckList CheckList { get; set; }
    }
}
