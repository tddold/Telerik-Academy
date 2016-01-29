using _06.TicTacToe.Web.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace _06.TicTacToe.Web.Models
{
    public class TicTacToeDbContext : IdentityDbContext<ApplicationUser>
    {
        public TicTacToeDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TicTacToeDbContext, Configuration>());
        }

        public static TicTacToeDbContext Create()
        {
            return new TicTacToeDbContext();
        }

        public IDbSet<Game> Games { get; set; }
    }
}