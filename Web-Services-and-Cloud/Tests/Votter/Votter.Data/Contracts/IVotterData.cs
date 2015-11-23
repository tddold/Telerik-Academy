namespace Votter.Data.Contracts
{
    using System;
    using System.Linq;
    using Votter.Models;

    public interface IVotterData : IDisposable
    {
        IGenericRepository<Picture> Pictures { get; }

        IGenericRepository<Category> Categories { get; }

        IGenericRepository<Vote> Votes { get; }

        int SaveChanges();
    }
}