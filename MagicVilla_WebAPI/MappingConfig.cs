using MagicVilla_WebAPI.Models.Dto;
using MagicVilla_WebAPI.Models;
using AutoMapper;

namespace MagicVilla_WebAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
