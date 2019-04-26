using System;
using System.ComponentModel.DataAnnotations;

namespace GYM.CoreApp.WebUI.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(13), MinLength(13)]
        [Display(Name = "EMBG")]
        public string EMBG { get; set; }

        [Required]
        [MaxLength(200), MinLength(2)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [MaxLength(13), MinLength(9)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        

    }


}