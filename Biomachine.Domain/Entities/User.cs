using Microsoft.AspNetCore.Identity;

namespace Biomachine.Domain.Entities;

public class User : IdentityUser
{
    public string? Initials { get; set; }
}
