using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } = "Employee"; // Default Role

        [Required]
        [StringLength(100)]
      
        public string Position { get; set; }

        public DateTime DateHired { get; set; } = DateTime.Now;



       
        public int LeadID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public string Status { get; set; }

        public DateTime FollowUpDate { get; set; }

        public virtual Customer Customer { get; set; }

        // Navigation properties
        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}