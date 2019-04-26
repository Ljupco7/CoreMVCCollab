using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class Utility
    {
        [Key]
        public int UtilityId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}