﻿using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
                CreateMap<Product,GetProductDto>().ReverseMap();
                CreateMap<Product,ResultProductDto>().ReverseMap();
                CreateMap<Product,UpdateProductDto>().ReverseMap();
                CreateMap<Product,CreateProductDto>().ReverseMap();
                CreateMap<Product,ResultProductWithCategory>().ReverseMap();
        }
    }
}
