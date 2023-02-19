using System;
using System.ComponentModel.DataAnnotations;

namespace SunnySystem.Data.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("customer")]
    public class Customer
    {
        public int customerid { get; set; }

        [Required]
        [StringLength(255)]
        public string? name { get; set; }

        [StringLength(255)]
        public string? address { get; set; }

        [StringLength(20)]
        public string? phone { get; set; }

        [StringLength(255)]
        public string? email { get; set; }
    }
}
