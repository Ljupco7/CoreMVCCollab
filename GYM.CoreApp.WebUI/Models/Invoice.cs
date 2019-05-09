using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.CoreApp.WebUI.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Required]
        [Display(Name = "Date ordered")]
        public DateTime DateOrdered { get; set; }

        [Required]
        [Display(Name = "Date due")]
        public DateTime DateDue { get; set; }

        [Required]
        [Display(Name = "Total value")]
        public int TotalValue { get; set; }
    }
}