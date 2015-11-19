namespace SourceControlSys.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Models.Projects;
    using SoureceControlSys.Common.Constants;
    using Services.Data.Constracts;
    using System.Web.Http.Cors;
    using AutoMapper.QueryableExtensions;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;

        public ProjectsController(IProjectsService projectsService)
        {
            this.projects = projectsService;
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {
            var result = this.projects
                .All(page: 1)
                .ProjectTo<SoftwareProjectDetailResponseModel>()
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
                pr.Name == id
                && (!pr.Private
                    || (pr.Private
                        && pr.Users.Any(c => c.UserName == this.User.Identity.Name))))
                .ProjectTo<SoftwareProjectDetailResponseModel>()
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectResponseModel model)
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
                  .ProjectTo<SoftwareProjectDetailResponseModel>()
                  .ToList();

            return this.Ok(result);
        }
    }
}
