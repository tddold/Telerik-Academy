namespace SourceControlSystem.Api.Models.Projects
{
    using Infrastucture.Mapping;
    using SourceControlSystem.Models;
    using System;
    using System.Linq;
    using AutoMapper;

    public class SoftwareProjectDetailsResponseModel : IMapFrom<SoftwareProject>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateOn { get; set; }

        public int TotalUsers { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<SoftwareProject, SoftwareProjectDetailsResponseModel>()
                 .ForMember(s => s.TotalUsers, opts => opts.MapFrom(s => s.Users.Count()));
        }
    }
}