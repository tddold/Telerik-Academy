﻿namespace SourceControlSystem.Services.Data.Contracts
{
    using Models;
    using Common.Constants;
    using System.Linq;
    public interface IProjectsService
    {
        IQueryable<SoftwareProject> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int Add(string name, string description, string creator, bool isPrivate = false);
    }
}
