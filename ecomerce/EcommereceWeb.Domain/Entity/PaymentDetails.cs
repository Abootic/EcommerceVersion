using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class PaymentDetails : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

    }
}
