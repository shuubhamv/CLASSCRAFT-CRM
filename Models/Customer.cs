using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace CRMSystem.Models
{
    public class Customer
    {
      
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Email Id")]
        public string ContactInfo { get; set; }

        [Display(Name = "Question")]
        public string Notes { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; }
        public string City { get; set; }

        [Display(Name = "Highest Qulification")]
        public string Region { get; set; }

        public string Answer { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }



    }

}
