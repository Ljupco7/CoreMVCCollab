using System.ComponentModel.DataAnnotations;

namespace GYM.CoreApp.WebUI.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [MaxLength(200), MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bank account number is required")]
        [Display(Name = "Bank account")]
        public long BankAccount { get; set; }

    }
}