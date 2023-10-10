using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class SubSubclassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string ArSubSubClassificationName { get; set; } //AddedNew
        public string? EnSubSubClassificationName { get; set; }  //AddedNew
        public int? SubClassificationBaseId { get; set; } // from  Subclassification model
        public string? ImageUrl { get; set; }
        public virtual SubClassificationBase? SubClassificationBase { get; set; }
        public virtual ICollection<Product> Products { get; set; }




    }
}
