using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductSize : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string ArSizeName { get; set; } //AddedNew
        public string? EnSizeName { get; set; } //AddedNew

        public virtual Product? Product { get; set; }



    }
}
