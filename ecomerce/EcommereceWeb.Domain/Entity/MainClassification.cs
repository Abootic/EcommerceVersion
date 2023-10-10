using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class MainClassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string ArMainClassificationName { get; set; } //AddedNew
        public string? EnMainClassificationName { get; set; }  //AddedNew

        public string? ImageUrl { get; set; }
        public virtual ICollection<BasicClassification> BasicClassifications { get; set; }
        public virtual ICollection<Product> Products { get; set; }



    }
}
