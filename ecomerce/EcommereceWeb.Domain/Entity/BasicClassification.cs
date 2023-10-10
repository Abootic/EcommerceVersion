
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class BasicClassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string ArBasicClassificationName { get; set; } = null!;
        public string? EnBasicClassificationName { get; set; }
        public int? MainClassificationId { get; set; } // from MainClassification Model
        public string? ImageUrl { get; set; }
        public virtual MainClassification? MainClassification { get; set; }
        public virtual ICollection<SubClassificationBase> SubClassificationBases { get; set; }
        public virtual ICollection<Product> Products { get; set; }




    }
}
