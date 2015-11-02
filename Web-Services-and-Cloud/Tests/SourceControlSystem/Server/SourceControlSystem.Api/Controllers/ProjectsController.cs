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

    public class ProjectsController : ApiController
    {
        private readonly IRepository<SoftwareProject> projects;
        private readonly IRepository<User> users;

        public ProjectsController()
        {
            var db = new SourseControlSystemDbContext();
            this.projects = new EfGenericRepository<SoftwareProject>(db);
            this.users = new EfGenericRepository<User>(db);
        }
        public IHttpActionResult Get()
        {
            var result = this.projects
                .All()
                .OrderByDescending(pr => pr.CreatedOn)
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
            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var newProject = new SoftwareProject
            {
                Name = model.Name,
                Description = model.Description,
                Private = model.Private,
                CreatedOn = DateTime.Now
            };

            newProject.Users.Add(currentUser);
            this.projects.Add(newProject);
            //this.db.SaveChanges();

            try
            {
                this.projects.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

            return this.Ok(newProject.Id);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page, int pageSize = 10)
        {
            var result = this.projects
                 .All()
                 .OrderByDescending(pr => pr.CreatedOn)
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize)
                 .Select(SoftwareProjectDetailsResponseModel.FromModel)
                 .ToList();

            return this.Ok(result);
        }

    }
}
