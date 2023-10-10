using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class AddProductToFavorite : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
     
        public int? ProductId { get; set; } // from Product Model
        public string? UserId { get; set; } // from user Model

        public virtual Product? Products { get; set; }
        public virtual User? Users { get; set; }

    }
}
