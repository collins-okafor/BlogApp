using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Model;
using AutoMapper;

namespace api.Helper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<BlogPost, BlogPostForCreation>();
            CreateMap<BlogPostForCreation, BlogPost>();

            CreateMap<BlogPost, BlogPostForGet>();
            CreateMap<BlogPostForGet, BlogPost>();
        }
    }
}