using Microsoft.AspNetCore.Identity;

namespace PB.Infrastructure.Authentication;

public class ApplicationUser : IdentityUser
{
    [StringLength(50)]
    public string FirstName { get; set; }

    [StringLength(50)]
    public string LastName { get; set; }
}
