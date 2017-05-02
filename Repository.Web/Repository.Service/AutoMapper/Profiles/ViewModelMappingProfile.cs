using AutoMapper;
using Repository.Domain.Models;
using Repository.Service.ViewModels;
using System.Collections.Generic;

namespace Repository.Service.AutoMapper.Profiles
{
    public class ViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelMappingProfile";
            }
        }

        public ViewModelMappingProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<news, NewsViewModel>().ReverseMap();
            CreateMap<user, UserViewModel>().ReverseMap();
        }
    }
}