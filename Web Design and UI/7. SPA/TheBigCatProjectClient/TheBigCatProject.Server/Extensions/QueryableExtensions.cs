namespace TheBigCatProject.Server.Extensions
{
    using Models;
    using System.Linq;

    public static class QueryableExtentions
    {
        public static IQueryable<CatRequestModels> ToFilteredCats(this IQueryable<CatRequestModels> query, CatFilterModel filters)
        {
            if (filters == null)
            {
                return query;
            }

            if (!string.IsNullOrWhiteSpace(filters.Name))
            {
                query = query
                    .Where(c => c.Name.ToLower().Contains(filters.Name.ToLower()));
            }

            if (filters.Age != null)
            {
                query = query
                    .Where(c => c.Age == filters.Age);
            }

            if (filters.Breed != null)
            {
                query = query
                    .Where(c => c.Breed == filters.Breed);
            }

            var skip = (filters.Page - 1) * 3;
            var take = 3;

            query = query
                .OrderByDescending(c => c.Id)
                .Skip(skip)
                .Take(take);

            return query;
        }
    }
}