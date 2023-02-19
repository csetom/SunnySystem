using System;
using System.ComponentModel.DataAnnotations;

namespace SunnySystem.Data.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(255)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }
    }
}
