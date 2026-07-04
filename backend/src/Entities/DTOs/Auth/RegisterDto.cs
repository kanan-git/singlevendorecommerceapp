namespace Entities.DTOs.Auth;

public class RegisterDto
{
    public string FirstName {get; set;} = null!;
    public string LastName {get; set;} = null!;
    public DateTime DateOfBirth {get; set;}
    public string ProfileImage {get; set;} = string.Empty;
    public string UserName {get; set;} = null!;
    public string Password {get; set;} = null!;
}
