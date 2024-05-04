using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            //burada maplemek istediğim metotlarımı çağırıcam

            //about sınıfıyla resultaboutdtoyu eşleştir
            //reversemap() hem about resultla eşleşebilir hem de result about ile eşleşebilir
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();    
            CreateMap<About,UpdateAboutDto>().ReverseMap();
                
        }
    }
}
