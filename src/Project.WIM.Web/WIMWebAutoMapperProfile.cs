using AutoMapper;
using Project.WIM.Wells;

namespace Project.WIM.Web
{
    public class WIMWebAutoMapperProfile : Profile
    {
        public WIMWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<WellDto, CreateUpdateWellDto>();
        }
    }
}
