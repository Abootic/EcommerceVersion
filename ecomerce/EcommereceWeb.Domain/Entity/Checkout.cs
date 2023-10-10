using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Checkout : AuditableEntity, IBaseEntity<int>
    {
        public  int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? EnFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string? PhoneNumberTwo { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public string? Milestone { get; set; }
        public string? ZipCode { get; set; }
        public int? NationalId { get; set; }
        public string? AddressDescription { get; set; }
        public string UserId { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
