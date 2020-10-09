using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Project.WIM.Wells
{
    public interface IWellAppService :
        ICrudAppService<
            WellDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateWellDto>
    {

    }
}
