using Microsoft.AspNetCore.Identity;

namespace DemoApp.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public bool IsSystemUser { get; set; }
}
