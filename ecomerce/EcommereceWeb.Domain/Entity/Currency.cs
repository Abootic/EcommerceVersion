using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Currency : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string ArName { get; set; } = null!;   //AddedNew
        public string? EnName { get; set; }    //AddedNew

        public string? Simbol { get; set; }
        public string? Value { get; set; }
        public int IsMain { get; set; }

      
    }

}

