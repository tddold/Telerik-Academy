namespace TheBigCatProject.Server.Models
{
    public class CatRequestModels
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Url { get; set; }

        public CatBreed Breed { get; set; }
    }
}