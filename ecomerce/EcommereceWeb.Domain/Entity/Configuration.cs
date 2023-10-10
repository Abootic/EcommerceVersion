using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Configuration : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ArValue { get; set; }      //AddedNew
        public string? EnValue { get; set; }     //AddedNew
        public string Name { get; set; }
        public string? Description { get; set; }





    }

}

