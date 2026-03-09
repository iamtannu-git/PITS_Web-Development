using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Models;
[Index(nameof(Email),IsUnique = true)]
[Index(nameof(Username), IsUnique = true)]
public class UserAccount
{
    [Key]
    public int id { get; set; }
    [Required(ErrorMessage="First Name is required.")]
    [MaxLength(50, ErrorMessage="Max 50 characters allowed.")]
    public string FirstName { get; set; } 
    [Required(ErrorMessage="Last Name is required.")]
    [MaxLength(50, ErrorMessage="Max 50 characters allowed.")]
    public string LastName { get; set; }
    [Required(ErrorMessage="Email is required.")]
    [MaxLength(50, ErrorMessage="Max 50 characters allowed.")]
    public string Email { get; set; }
    [Required(ErrorMessage="Username is required.")]
    [MaxLength(100, ErrorMessage="Username is too long.")]
    public string Username { get; set; }
    
    [Required(ErrorMessage="Password is required.")]
    [MaxLength(20, ErrorMessage="Max 20 characters allowed.")]
    public string Password { get; set; }
    
}