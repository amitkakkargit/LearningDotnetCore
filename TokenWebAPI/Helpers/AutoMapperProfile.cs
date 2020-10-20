using AutoMapper;
using TokenWebAPI.DTOs;
using System.Text;
using TokenWebAPI.Models;

namespace TokenWebAPI.Helpers
{
    public class AutoMapperProfile: Profile
    {
       public AutoMapperProfile()
        {            
            CreateMap<LoginDto, TblUser>();
            CreateMap<RegisterDto, TblUser>()
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => Encoding.Unicode.GetBytes( src.Password)));
        }
    }
}