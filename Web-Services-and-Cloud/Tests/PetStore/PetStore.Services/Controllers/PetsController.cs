namespace PetStore.Services.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class PetsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return this.Ok();
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok();
        }

        public void Post()
        {

        }
    }
}