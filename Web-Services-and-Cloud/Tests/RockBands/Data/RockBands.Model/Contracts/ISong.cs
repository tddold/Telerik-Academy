namespace RockBands.Model.Contracts
{
    public interface ISong
    {
        string Name { get; set; }

        string ImageUrl { get; set; }

        string Src { get; set; }

        int Raiting { get; set; }
    }
}
