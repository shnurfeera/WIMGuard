using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Project.WIM.Wells
{
    public class Well : AuditedAggregateRoot<Guid>
        //: FullAuditedEntity<long>, IMustHaveTenant
    {

        //[Index("IX_Well", Order = 1, IsUnique = true)]
        public int TenantId { get; set; }

        //[ForeignKey(nameof(TenantId))]
        //public virtual Tenant Tenant { get; set; }

        //[Index("IX_Well", Order = 2, IsUnique = true)]
        //[StringLength(MaxWellNameLength)]
        public string Name { get; set; }

        //[Index]
        //[StringLength(MaxFieldLength)]
        public string Field { get; set; }

        //[Index]
        //[StringLength(MaxPlatformLength)]
        public string Platform { get; set; }

        //[StringLength(MaxPscLength)]
        public string Psc { get; set; }

        //[InverseProperty(nameof(Well))]
        //public virtual ICollection<WellString> WellStrings { get; set; }
        public WellType Producer { get; set; }

        public WellCategory Category { get; set; }
    }
}
