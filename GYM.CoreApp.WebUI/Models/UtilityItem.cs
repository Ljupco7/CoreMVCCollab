using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class UtilityItem
    {
        [Key]
        public int UtilityItemId { get; set; }

        [ForeignKey("Utility")]
        public int UtilityId { get; set; }
        public Utility Utility { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Date of entry")]
        public DateTime DateOfEntry { get; set; }

    }
}