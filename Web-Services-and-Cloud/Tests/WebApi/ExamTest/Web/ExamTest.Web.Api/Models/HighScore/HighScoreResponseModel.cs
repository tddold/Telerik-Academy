namespace  ExamTest.Web.Api.Models.HighScore
{
    using System;
    using AutoMapper;
    using  ExamTest.Data.Models;
    using  ExamTest.Web.Api.Infrastruchtures.Mappings;

    public class HighScoreResponseModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string Username { get; set; }

        public int Rank { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, HighScoreResponseModel>()
                .ForMember(u => u.Username, opts => opts.MapFrom(u => u.Email));
        }
    }
}