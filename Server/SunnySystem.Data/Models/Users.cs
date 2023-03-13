using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SunnySystem.Data.Models;

[Table("users")]
public partial class User
{
  public User(string username, string password, int privilage)
  {
    Username = username;
    Password = password;
    Privilage = privilage;
  }

  [Key]
  [Column("username")]
  public String Username { get; set; }
  [Column("password")]
  [Required]
  public String Password { get; set; }
  [Column("privilage")]
  public int Privilage {get; set;}
  
  public override string ToString()
  {
    return $"Username: {Username}, Password: {Password}, Privilage: {Privilage}";
  }
}