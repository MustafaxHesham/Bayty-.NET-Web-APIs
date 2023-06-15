using BaytyAPIs.DTOs.AdvertisementDTOs;
using AutoMapper;
using Models.Entities;

namespace BaytyAPIs.Profiles
{
    public class AdProfile : Profile
    {
        public AdProfile()
        {
            CreateMap<AdDTO, Advertisement>();

            CreateMap<Advertisement, AdCardDTO>()
                .ForPath(dest => dest.IsForRent, opts => opts.MapFrom(src => src.HouseBase.IsForRent))
                .ForPath(dest => dest.Price, opts => opts.MapFrom(src => src.HouseBase.Price))
                .ForPath(dest => dest.Area, opts => opts.MapFrom(src => src.HouseBase.Area))
                .ForPath(dest => dest.MainImagePath, opts => opts.MapFrom(src => src.HouseBase.HouseBaseImagePaths.FirstOrDefault()));
        }
    }
}
