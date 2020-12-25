﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderning.Application.Mapper
{
    public class OrderMapper
    {
        public static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<OrderMappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;

        });

        public static IMapper Mapper => Lazy.Value;
    }
}
