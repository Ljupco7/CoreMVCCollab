using System;
using System.ComponentModel.DataAnnotations;

namespace GYM.CoreApp.WebUI.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(100), MinLength(2)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(100), MinLength(2)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "EMBG is required")]
        [MaxLength(13), MinLength(13)]
        [Display(Name = "EMBG")]
        public string EMBG { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MaxLength(200), MinLength(2)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(13), MinLength(9)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        

    }


}