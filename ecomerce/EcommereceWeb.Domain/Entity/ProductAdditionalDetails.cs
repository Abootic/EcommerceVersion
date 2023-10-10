using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductAdditionalDetails : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string ArTitle { get; set; }   //AddedNew
        public string? EnTitle { get; set; }   //AddedNew
        public string ArValue { get; set; }   //AddedNew
        public string? EnValue { get; set; }   //AddedNew
        public int? ProductId { get; set; } // from product model
        public virtual Product? Product { get; set; }


    }
}
