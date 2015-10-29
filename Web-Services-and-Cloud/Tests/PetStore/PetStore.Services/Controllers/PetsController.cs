namespace PetStore.Services.Controllers
{
   
    using PetStore.Models;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Data;
    using Models.Pets;

    public class PetsController : ApiController
    {
        PetStoreDbContext db = new PetStoreDbContext();

        public async Task<IHttpActionResult> Get()
        {
            var pets = await this.db
                .Pets
                .ToListAsync();

            return this.Ok(this.db.Pets.ToList());
        }

        public IHttpActionResult Post(int id, PetRequestModel pet)
        {

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var dbPet = new Pet
            {
                Name = pet.Name,
                Age = pet.Age
            };

            this.db.Pets.Add(dbPet);
            this.db.SaveChanges();

            return this.Ok(pet);
        }
    }
}