using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public  class Contact : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string SenderEmail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string SenderName { get; set; } = null!;
       
    
    
    }
}
