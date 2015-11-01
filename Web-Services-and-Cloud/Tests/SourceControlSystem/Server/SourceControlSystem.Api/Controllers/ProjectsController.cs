namespace SourceControlSystem.Api.Controllers
{
    using Data;
    using System.Linq;
    using System.Web.Http;

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
                .OrderByDescending(pr => pr.CreatedOn)
                .Take(10)
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
                .SoftwareProjects
                .Where(pr => pr.Name == id)
                .FirstOrDefault();

            if (result.Private &&
                !result.Users.Any(u => u.UserName == this.User.Identity.Name))
            {
                return this.Unauthorized();
            }

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //public IHttpActionResult Post()
        //{

        //}

    }
}
