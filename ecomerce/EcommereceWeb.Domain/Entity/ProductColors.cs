using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductColors : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; } // from product model
        public int? Quantity { get; set; }
        public string? ImgUrl { get; set; }
        public string ArColorName { get; set; }   //AddedNew
        public string? EnColorName { get; set; }   //AddedNew
        public virtual Product? Product { get; set; }



    }
}
