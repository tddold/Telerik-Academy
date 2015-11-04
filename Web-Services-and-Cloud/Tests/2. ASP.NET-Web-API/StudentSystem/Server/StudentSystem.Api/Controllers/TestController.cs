namespace StudentSystem.Api.Controllers
{
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using StudentSystem.Api.Models;
    using StudentSystem.Models;

    public class TestController : BaseController
    {
        [HttpGet]
        public IQueryable<TestModel> All()
        {
            return this.StudentSystemData.Tests
                .All()
                .Select(TestModel.FromTest);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var test = this.GetMaterialModelById(id);

            if (test == null)
            {
                return this.NotFound();
            }

            return this.Ok(test);
        }

        [HttpPut]
        public IHttpActionResult Change(TestModel tetsModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var tets = this.StudentSystemData.Tests
                .Find(tetsModel.TestId);

            if (tets == null)
            {
                return this.NotFound();
            }

            try
            {
                tets.Id = tetsModel.TestId;
                tets.CourseId = tetsModel.CourseId;
                tets.Students = tetsModel.Students;

                this.StudentSystemData.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.TetsExists(tetsModel.TestId))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPost]
        public IHttpActionResult Create(Test test)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.StudentSystemData.Tests.Add(test);
            this.StudentSystemData.SaveChanges();

            return this.CreatedAtRoute("DefaultApi", new { id = test.Id }, test);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var test = this.StudentSystemData.Tests
                .Find(id);

            if (test == null)
            {
                return this.NotFound();
            }

            this.StudentSystemData.Tests.Delete(test);
            this.StudentSystemData.SaveChanges();

            return this.Ok(test);
        }

        private TestModel GetMaterialModelById(int id)
        {
            var test = this.StudentSystemData.Tests
                               .All()
                               .Select(TestModel.FromTest)
                               .FirstOrDefault(t => t.TestId == id);
            return test;
        }

        private bool TetsExists(int id)
        {
            return this.StudentSystemData.Tests
                .All()
                .Any(e => e.Id == id);
        }
    }
}
