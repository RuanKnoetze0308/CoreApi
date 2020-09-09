using AutoMapper;
using CoreApi.Dtos;
using CoreApi.Models;

namespace CoreApi.Profiles
{
    public class ApisProfile : Profile
    {
        public ApisProfile()
        {
            CreateMap<Api, ApiReadDto>();
        }
    }
}