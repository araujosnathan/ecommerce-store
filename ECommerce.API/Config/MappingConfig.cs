using System;
using AutoMapper;
using ECommerce.API.Data.ValeuObjects;
using ECommerce.API.Model;

namespace ECommerce.API.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product,ProductVO>();
                });
            return mappingConfig;
        }
    }
}

