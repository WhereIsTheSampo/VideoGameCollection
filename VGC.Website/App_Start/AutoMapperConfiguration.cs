using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using VGC.DomainModel;
using VGC.Website.Models;

namespace VGC.Website
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Game, GameDto>()
                .ForAllMembers(opt => opt.NullSubstitute(String.Empty));
        }
    }
}
