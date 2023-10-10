using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class MasterData : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? CodeValue { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; }

        public virtual ICollection<DetailsData> DetailsDatas { get; set; }




    }

}

