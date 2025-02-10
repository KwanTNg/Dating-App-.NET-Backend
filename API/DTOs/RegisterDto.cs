
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    //Data Annotation
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }

}
