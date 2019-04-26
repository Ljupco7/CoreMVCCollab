using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GYM.CoreApp.WebUI.Models
{
    public class CustomerOrder
    {
        [Key]
        public int CustomerOrderId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [Display(Name = "Date ordered")]
        public DateTime DateOrdered { get; set; }

       
    }
}