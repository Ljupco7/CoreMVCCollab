using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [MaxLength(200), MinLength(2)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Bank account")]
        public long BankAccount { get; set; }

    }
}