using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class CouponItem : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public int? CouponId { get; set; }
        public int? ProductId { get; set; }  //   productId 


        public virtual Product? Products { get; set; }
        public virtual Coupon? Coupons { get; set; }


    }

}
