using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.CoreApp.WebUI.Models
{
    public class UtilityItem
    {
        [Key]
        public int UtilityItemId { get; set; }

        [ForeignKey("Utility")]
        public int UtilityId { get; set; }
        public Utility Utility { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Date of entry is required")]
        [Display(Name = "Date of entry")]
        public DateTime DateOfEntry { get; set; }

    }
}