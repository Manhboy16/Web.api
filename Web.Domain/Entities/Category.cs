using DemoApp.Domain.Abstractions;
using DemoApp.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Domain.Entities
{

    [Table("Categories")]
    public class Category : DomainEntity<Guid>, IAuditTable
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }
        public string? ImageJson { get; set; }
        public ICollection<Product> Products { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Status { get; set; }
    }
}
