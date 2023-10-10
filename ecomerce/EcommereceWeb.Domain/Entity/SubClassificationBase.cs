using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class SubClassificationBase : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string ArSubClassificationName { get; set; } //AddedNew
        public string? EnSubClassificationName { get; set; }  //AddedNew
        public int? BasicClassificationId { get; set; } // from BasicClassification model
        public string? ImageUrl { get; set; }

        public virtual BasicClassification? BasicClassification { get; set; }
        public virtual ICollection<SubSubclassification> SubSubclassifications { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}