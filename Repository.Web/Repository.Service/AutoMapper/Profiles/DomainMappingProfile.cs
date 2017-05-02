using AutoMapper;
using Repository.Domain.Models;
using Repository.Service.ViewModels;
using System.Collections.Generic;

namespace Repository.Service.AutoMapper.Profiles
{
    public class DomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainMappingProfile";
            }
        }

        public DomainMappingProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<NewsViewModel, news>().ReverseMap();
            CreateMap<UserViewModel, user>().ReverseMap();
        }
    }
}