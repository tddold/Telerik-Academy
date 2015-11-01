namespace SourceControlSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models.Projects;
    using SourceControlSystem.Models;
    using System;

    public class ProjectsController : ApiController
    {
        private readonly SourseControlSystemDbContext db;

        public ProjectsController()
        {
            this.db = new SourseControlSystemDbContext();
        }
        public IHttpActionResult Get()
        {
            var result = this.db
                .SoftwareProjects
                .OrderByDescending(pr => pr.CreateOn)
                .Take(10)
                .Select(SoftwareProjectDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.BadRequest("Project name cannot be null or empty.");
            }

            var result = this.db
                .SoftwareProject
                .Where(pr => pr.Name == id)
                .FirstOrDefault();

            if (result.Private &&
                result.Users.Any(u => u.UserName == this.User.Identity.Name))
            {
                return this.Unauthorized();
            }

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            var currentUser = this.db
                .Users
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var newProject = new SoftwareProject
            {
                Name = model.Name,
                Description = model.Description,
                Private = model.Private,
                CreateOn = DateTime.Now
            };

            newProject.Users.Add(currentUser);

            this.db.SoftwareProject.Add(newProject);
            this.db.SaveChanges();

            return this.Ok(newProject.Id);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page, int pageSize)
        {
            var result = this.db
           .SoftwareProjects
           .OrderByDescending(pr => pr.CreateOn)
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .Select(SoftwareProjectDetailsResponseModel.FromModel)
           .ToList();

            return this.Ok(result);
        }
    }
}
