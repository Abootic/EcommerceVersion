using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductUnitSize : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Width { get; set; }
        public bool? ProductType { get; set; }
        public int? ProductId { get; set; } // from product model
        public virtual Product? Product { get; set; }


    }
}
