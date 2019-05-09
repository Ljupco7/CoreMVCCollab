using System.ComponentModel.DataAnnotations;

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