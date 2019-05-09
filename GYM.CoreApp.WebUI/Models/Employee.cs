using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(100), MinLength(2)]
        [Display(Name ="First Name")]
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
        [Display(Name = "Home address")]
        public string Address { get; set; }

        [Required]
        [MaxLength(13), MinLength(9)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Salary per month")]
        public int SalaryPerMonth { get; set; }

        [Required]
        [Display(Name = "Date when joined company")]
        public DateTime DateWhenJoined { get; set; }

        [Required]
        [Display(Name = "Still Employed")]
        public bool StillEmployed { get; set; }

    }
}