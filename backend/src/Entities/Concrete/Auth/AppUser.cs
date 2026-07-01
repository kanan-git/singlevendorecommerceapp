using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete.Auth;

public class AppUser : IdentityUser<Guid>
{
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
}
