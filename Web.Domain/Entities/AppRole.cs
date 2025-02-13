using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Domain.Entities;

public class AppRole : IdentityRole<Guid>
{

}
