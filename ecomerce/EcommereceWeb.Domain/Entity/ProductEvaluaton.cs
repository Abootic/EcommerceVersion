using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductEvaluaton : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public int? ProductId { get; set; }
        public string? UserId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual User? Users { get; set; }


    }
}
