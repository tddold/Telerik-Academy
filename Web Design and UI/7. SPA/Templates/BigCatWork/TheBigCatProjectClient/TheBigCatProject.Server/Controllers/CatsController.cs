namespace TheBigCatProject.Server.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Extensions;
    using Models;

    public class CatsController : ApiController
    {
        private List<CatRequestModels> catsData = new List<CatRequestModels>
        {
            new CatRequestModels
            {
                Id=1,
                Name="Pesho",
                Age=3,
                Breed=CatBreed.Persian,
                Url="http://www.businessinsider.com/image/4f3433986bb3f7b67a00003c/cute-cat.jpg"
            },
            new CatRequestModels
            {
                Id=2,
                Name="Gosho",
                Age=2,
                Breed=CatBreed.Siamese,
                Url="https://i.ytimg.com/vi/mSFTRoBY99s/hqdefault.jpg"
            },
             new CatRequestModels
            {
                Id=3,
                Name="Ivan",
                Age=2,
                Breed=CatBreed.Street,
                Url="http://dogshome.com/wp-content/uploads/2012/03/cat-adoption.jpg"
            },
              new CatRequestModels
            {
                Id=4,
                Name="Rosen",
                Age=3,
                Breed=CatBreed.Street,
                Url="https://upload.wikimedia.org/wikipedia/commons/2/22/Turkish_Van_Cat.jpg"
            }
        };

        public IHttpActionResult Get([FromUri]CatFilterModel model)
        {
            var result = this.catsData
                .AsQueryable()
                .ToFilteredCats(model)
                .Take(10)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Post(CatRequestModels model)
        {
            if (model != null)
            {
                model.Id = catsData.Count + 1;
                catsData.Add(model);
            }

            return Ok(model.Id);
        }
    }
}
