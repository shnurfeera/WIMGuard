using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Project.WIM.Wells
{
    public class WellDto : AuditedEntityDto<Guid>
    {
        //public const int MaxWellNameLength = 25;

        //public const int MaxFieldLength = 40;

        //public const int MaxPlatformLength = 40;

        //public const int MaxPscLength = 15;

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
