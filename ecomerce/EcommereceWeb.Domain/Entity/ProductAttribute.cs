using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductAttribute : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? AttributeId { get; set; }
        public string? Name { get; set; }
        public int? AttributeItemId { get; set; }
        public virtual Attribute? Attribute { get; set; }
        public virtual Product? Product { get; set; }
        public virtual AttributeItem? AttributeItem { get; set; }


    }


}
