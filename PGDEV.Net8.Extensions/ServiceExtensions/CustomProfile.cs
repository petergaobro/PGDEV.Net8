﻿using AutoMapper;
using PGDEV.Net8.Model;

namespace PGDEV.Net8.Extensions.ServiceExtensions
{
    public class CustomProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public CustomProfile()
        {
            CreateMap<Role, RoleVo>()
                .ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
            CreateMap<RoleVo, Role>()
                .ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));
        }
    }
}
