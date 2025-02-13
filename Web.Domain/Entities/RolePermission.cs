using System.ComponentModel.DataAnnotations.Schema;
using DemoApp.Domain.Abstractions;

namespace DemoApp.Domain.Entities
{
    [Table("RolesPermissions")]
    public class RolePermission : DomainEntity<Guid>
	{
        public Guid RoleId { get; set; }
        public string PermissionCode { get; set; } = string.Empty;
    }
}
