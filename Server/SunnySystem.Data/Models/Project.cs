using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunnySystem.Data.Models
{


public class Project
{
    [Key]
    [Column("project_id")]
    public int ProjectID { get; set; }
    [Column("project_name")]
    public string? ProjectName { get; set; }
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    [Column("end_date")]
    public DateTime EndDate { get; set; }
    [Column("customer_id")]
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

}

}