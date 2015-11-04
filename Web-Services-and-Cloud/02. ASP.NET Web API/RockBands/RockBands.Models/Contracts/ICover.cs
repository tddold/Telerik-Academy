namespace RockBands.Models.Contracts
{
    public interface ICover
    {
        string Name { get; set; }

        string ImageUrl { get; set; }

        string Src { get; set; }

        int Rating { get; set; }
    }
}