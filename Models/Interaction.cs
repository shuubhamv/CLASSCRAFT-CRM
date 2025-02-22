using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMSystem.Models
{
    public class Interaction
    {
        [Key]
        public int InteractionID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public string Type { get; set; }

        public string Details { get; set; }

        public DateTime Date { get; set; }

        public virtual Customer Customer { get; set; }
    }
}