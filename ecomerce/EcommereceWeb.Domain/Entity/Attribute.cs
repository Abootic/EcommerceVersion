
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Attribute : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string ArName { get; set; }
        public string? EnName { get; set; }
        public string? Code { get; set; }
        public int? Type { get; set; }
        public virtual ICollection<AttributeItem> AttributeItems { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }


}
