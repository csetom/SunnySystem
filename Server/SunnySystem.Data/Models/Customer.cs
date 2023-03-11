

using System.ComponentModel.DataAnnotations.Schema;
namespace SunnySystem.Data.Models;


[Table("users")]
public class Customer
{
    [Column("customer_id")]
    public int CustomerID { get; set; }
    [Column("name")]
    public string? Name { get; set; }
    [Column("address")]
    public string? Address { get; set; }
    [Column("phone")]
    public string? Phone { get; set; }
    [Column("email")]
    public string? Email { get; set; }

    public virtual ICollection<Project>? Projects { get; set; }

}
