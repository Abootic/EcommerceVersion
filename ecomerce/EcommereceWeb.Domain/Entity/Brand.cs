using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Brand : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public string ArName { get; set; } = null!;
        public string? EnName { get; set; }
        public string? CompanyInfo { get; set; }

        public string? ImageUrl { get; set; }
        public virtual ICollection<Product> Products { get; set; }


    }
}
