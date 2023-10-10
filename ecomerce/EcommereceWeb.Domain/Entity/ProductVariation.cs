using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductVariation : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? ArName { get; set; }
        public string? EnName { get; set; }
        public string? AttItemId { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public int? Quantity { get; set; }



        public virtual Product? Product { get; set; }

    }


}
