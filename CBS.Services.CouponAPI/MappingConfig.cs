using AutoMapper;
using CBS.Services.CouponAPI.DTO;
using CBS.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CBS.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
