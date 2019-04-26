
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100), MinLength(2)]
        public string Name { get; set; }

    }
}