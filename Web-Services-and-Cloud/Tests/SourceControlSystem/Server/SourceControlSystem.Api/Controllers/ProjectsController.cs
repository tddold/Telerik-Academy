namespace SourceControlSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models.Projects;
    using SourceControlSystem.Models;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using Common.Constants;
    using Services.Data.Contracts;
    using Services.Data;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;

        public ProjectsController()
        {
            var db = new SourseControlSystemDbContext();
            this.projects = new ProjectsService();
        }
        public IHttpActionResult Get()
        {
            var result = this.projects
                .All(page: 1)
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

            var result = this.projects
                .All()
                .Where(pr =>
                    pr.Name == id &&
                    (!pr.Private ||
                        (pr.Private &&
                            pr.Users.Any(u => u.UserName == this.User.Identity.Name))))
                    .Select(SoftwareProjectDetailsResponseModel.FromModel)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = this.projects.Add(
                model.Name,
                model.Description,
                this.User.Identity.Name,
                model.Private);

            return this.Ok(createdProjectId);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.projects
                 .All(page, pageSize)
                 .Select(SoftwareProjectDetailsResponseModel.FromModel)
                 .ToList();

            return this.Ok(result);
        }

    }
}
