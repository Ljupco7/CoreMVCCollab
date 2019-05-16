using System;
using System.ComponentModel.DataAnnotations;

namespace GYM.CoreApp.WebUI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(100), MinLength(2)]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(100), MinLength(2)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required")]
        [Range(typeof(DateTime), "1/1/1966", "1/1/2020", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "EMBG is required")]
        [MaxLength(13), MinLength(13)]
        [Display(Name = "EMBG")]
        public string EMBG { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MaxLength(200), MinLength(2)]
        [Display(Name = "Home address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(13), MinLength(9)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Salary per month is required")]
        [Display(Name = "Salary per month")]
        public int SalaryPerMonth { get; set; }

        [Required(ErrorMessage = "Date when joined is required")]
        [Display(Name = "Date when joined company")]
        public DateTime DateWhenJoined { get; set; }

        [Required]
        [Display(Name = "Still Employed")]
        public bool StillEmployed { get; set; }

    }
}