using AutoMapper;
using RCCWebApi.DTO.MobileLogin;
using RCCWebApi.Models;

namespace RCCWebApi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ReadOnlyMobileLoginDto, TritMobileLogin>().ReverseMap();
        }
    }
}
