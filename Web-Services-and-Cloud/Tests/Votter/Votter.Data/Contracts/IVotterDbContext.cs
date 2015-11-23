namespace Votter.Data.Contracts
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Votter.Models;

    public interface IVotterDbContext : IDbContext
    {
        IDbSet<Category> Categories { get; set; }

        IDbSet<Picture> Pictures { get; set; }

        IDbSet<Vote> Votes { get; set; }
    }
}