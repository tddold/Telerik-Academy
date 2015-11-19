namespace SourceControlSys.Api.Models.Projects
{
    using System;
    using SourceControlSys.Models;
    using Infrastructure.Mapping;
    using AutoMapper;

    public class SoftwareProjectDetailResponseModel : IMapFrom<SoftwareProject>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<SoftwareProject, SoftwareProjectDetailResponseModel>()
                .ForMember(s => s.TotalUsers, opts => opts.MapFrom(s => s.Users.Count));
        }
    }
}