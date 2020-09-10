using AutoMapper;
using CoreApi.Dtos;
using CoreApi.Models;

namespace CoreApi.Profiles
{
    public class ApisProfile : Profile
    {
        public ApisProfile()
        {
            //Source --> Target
            CreateMap<Api, ApiReadDto>();
            CreateMap<ApiCreateDto, Api>();
            CreateMap<ApiUpdateDto, Api>();
            CreateMap<Api, ApiUpdateDto>();
        }
    }
}