using AutoMapper;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
                CreateMap<Feature,GetFeatureDto>().ReverseMap();
                CreateMap<Feature,ResultFeatureDto>().ReverseMap();
                CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
                CreateMap<Feature,CreateFeatureDto>().ReverseMap();
        }
    }
}
