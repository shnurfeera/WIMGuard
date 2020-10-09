using System;
using System.Threading.Tasks;
using Project.WIM.Wells;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Project.WIM
{
    public class WIMDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Well, Guid> _wellRepository;

        public WIMDataSeederContributor(IRepository<Well, Guid> wellRepository)
        {
            _wellRepository = wellRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _wellRepository.GetCountAsync() <= 0)
            {
                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 1,
                        Name = "J-A1",
                        Field = "Jerun",
                        Platform = "Jerun A",
                        Psc = "SK408",
                        Producer = WellType.Gas,
                        Category = WellCategory.Normal
                    },
                    autoSave: true
                );

                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 1,
                        Name = "J-A2",
                        Field = "Jerun",
                        Platform = "Jerun A",
                        Psc = "SK408",
                        Producer = WellType.Gas,
                        Category = WellCategory.Normal
                    },
                    autoSave: true
                );

                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 2,
                        Name = "B15-A1St1",
                        Field = "B15",
                        Platform = "B15A",
                        Psc = "SK310",
                        Producer = WellType.Gas,
                        Category = WellCategory.HPHT
                    },
                    autoSave: true
                );

                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 4,
                        Name = "EPA-12L",
                        Field = "East Piatu",
                        Platform = "EPA",
                        Psc = "PM329",
                        Producer = WellType.Oil,
                        Category = WellCategory.GasLifted
                    },
                    autoSave: true
                );

                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 4,
                        Name = "EPA-12S",
                        Field = "East Piatu",
                        Platform = "EPA",
                        Psc = "PM329",
                        Producer = WellType.Oil,
                        Category = WellCategory.GasLifted
                    },
                    autoSave: true
                );

                await _wellRepository.InsertAsync
                (
                    new Well
                    {
                        TenantId = 5,
                        Name = "EPA-29",
                        Field = "East Belumut",
                        Platform = "EBA",
                        Psc = "PM323",
                        Producer = WellType.Injector,
                        Category = WellCategory.Normal
                    },
                    autoSave: true
                );
            }
        }
    }
}
