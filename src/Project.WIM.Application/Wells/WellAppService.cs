using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Project.WIM.Wells
{
    public class WellAppService :
        CrudAppService<
            Well,
            WellDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateWellDto>,
        IWellAppService
    {
        public WellAppService(IRepository<Well, Guid> repository)
            : base(repository)
        {

        }
    }
}
