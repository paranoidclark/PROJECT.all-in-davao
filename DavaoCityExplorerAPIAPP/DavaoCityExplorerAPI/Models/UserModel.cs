using System.ComponentModel.DataAnnotations;

namespace DavaoCityExplorerAPI.Models;

public class UserModel
{
    [Key]
    public int UserID { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    public string Role { get; set; } = "User";
}
