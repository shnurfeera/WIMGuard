using Project.WIM.Wells;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Project.WIM.EntityFrameworkCore
{
    public static class WIMDbContextModelCreatingExtensions
    {
        public static void ConfigureWIM(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(WIMConsts.DbTablePrefix + "YourEntities", WIMConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            builder.Entity<Well>(b =>
            {
                b.ToTable(WIMConsts.DbTablePrefix + "Wells",
                          WIMConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}