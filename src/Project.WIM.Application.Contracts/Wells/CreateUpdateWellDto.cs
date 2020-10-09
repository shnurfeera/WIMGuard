using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project.WIM.Wells
{
    public class CreateUpdateWellDto
    {
        public const int MaxWellNameLength = 25;

        public const int MaxFieldLength = 40;

        public const int MaxPlatformLength = 40;

        public const int MaxPscLength = 15;

        [Required]
        public int TenantId { get; set; }

        //public virtual Tenant Tenant { get; set; }

        [Required]
        [StringLength(MaxWellNameLength)]
        public string Name { get; set; }

        //[Index]
        [Required]
        [StringLength(MaxFieldLength)]
        public string Field { get; set; }

        //[Index]
        [Required]
        [StringLength(MaxPlatformLength)]
        public string Platform { get; set; }

        [Required]
        [StringLength(MaxPscLength)]
        public string Psc { get; set; }

        //[InverseProperty(nameof(Well))]
        //public virtual ICollection<WellString> WellStrings { get; set; }
        public WellType Producer { get; set; }

        public WellCategory Category { get; set; }
    }
}
