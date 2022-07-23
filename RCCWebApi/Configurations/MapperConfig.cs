using AutoMapper;
using RCCWebApi.DTO.DailyRate;
using RCCWebApi.DTO.MobileLogin;
using RCCWebApi.Models;

namespace RCCWebApi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ReadOnlyMobileLoginDto, TritMobileLogin>().ReverseMap();
            CreateMap<TritMobileLogin, UpdatePassword>().ReverseMap();
            CreateMap<ReadOnlyDailyRates,TritDailyRate>().ReverseMap();

        }
    }
}
