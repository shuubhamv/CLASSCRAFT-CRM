using System;
using System.ComponentModel.DataAnnotations;

namespace CRMSystem.Models
{
    public class SalesReport
    {
        [Key]
        public int ReportID { get; set; }

        [Required]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        [Required]
        public int TotalLeads { get; set; }

        [Required]
        public int ConvertedLeads { get; set; }

        [Required]
        public decimal TotalRevenue { get; set; } // Sales revenue

        [Required]
        public int TotalInteractions { get; set; }

        public string Notes { get; set; } // Additional comments or insights
    }
}
