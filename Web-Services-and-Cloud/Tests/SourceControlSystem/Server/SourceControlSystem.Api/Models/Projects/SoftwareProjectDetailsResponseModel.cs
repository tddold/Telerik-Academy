namespace SourceControlSystem.Api.Models.Projects
{
    using SourceControlSystem.Models;
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public class SoftwareProjectDetailsResponseModel
    {
        public static Expression<Func<SoftwareProject, SoftwareProjectDetailsResponseModel>> FromModel
        {
            get
            {
                return pr => new SoftwareProjectDetailsResponseModel
                {
                    Id = pr.Id,
                    Name = pr.Name,
                    CreateOn = pr.CreateOn,
                    TotalUsers = pr.Users.Count()
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateOn { get; set; }

        public int TotalUsers { get; set; }
    }
}