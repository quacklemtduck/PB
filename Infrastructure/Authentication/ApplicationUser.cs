using Microsoft.AspNetCore.Identity;

namespace PB.Infrastructure.Authentication;

public class ApplicationUser : IdentityUser
{
    [StringLength(50)]
    [PersonalData]
    public string FirstName { get; set; }

    [StringLength(50)]
    [PersonalData]
    public string LastName { get; set; }
}
