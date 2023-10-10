using System;
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Slider : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string? EnName { get; set; }
        public string ArName { get; set; }
        public string ImgUrl { get; set; }
        public string? EnDetails { get; set; }
        public string? ArDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
     
       
     

  

    }

}
