﻿using AutoMapper;
using SignalR.DtoLayer.SocialMedia;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
        }
    }
}
