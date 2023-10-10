using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class DetailsData : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
       // public int CodeValue { get; set; }
        public string ArValue { get; set; }  //AddedNew
        public string? EnValue { get; set; }    //AddedNew
        public string? Description { get; set; }
        public int? MasterDataId { get; set; } // from MasterData model

        public virtual MasterData? MasterData { get; set; }



    }

}

