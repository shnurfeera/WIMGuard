using AutoMapper;
using Project.WIM.Wells;

namespace Project.WIM
{
    public class WIMApplicationAutoMapperProfile : Profile
    {
        public WIMApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Well, WellDto>();
            CreateMap<CreateUpdateWellDto, Well>();
        }
    }
}
