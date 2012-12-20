using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using VGC.Api;
using VGC.DomainModel;

namespace VGC.Engine
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Company, CompanyDto>()
                .ForAllMembers(opt => opt.NullSubstitute(String.Empty));

            Mapper.CreateMap<Platform, PlatformDto>()
                .ForAllMembers(opt => opt.NullSubstitute(String.Empty));

            Mapper.CreateMap<Game, GameDto>()
                .ForAllMembers(opt => opt.NullSubstitute(String.Empty));
        }
    }
}
