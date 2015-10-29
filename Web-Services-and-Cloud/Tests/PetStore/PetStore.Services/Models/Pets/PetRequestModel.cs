namespace PetStore.Services.Models.Pets
{
    using System.ComponentModel.DataAnnotations;

    public class PetRequestModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string Another { get; set; }

        public int Age { get; set; }
    }
}