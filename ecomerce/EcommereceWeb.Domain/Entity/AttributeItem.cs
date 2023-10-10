using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class AttributeItem : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string ArName { get; set; }
        public string? EnName { get; set; }
        public string? Code { get; set; }
        public string? Details { get; set; }
        public string? ColorCode { get; set; }
        public int? AttributeId { get; set; }
        public virtual Attribute? Attribute { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }


    }
}
