namespace _06.TicTacToe.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_06.TicTacToe.Web.Models.TicTacToeDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "_06.TicTacToe.Web.Models.TicTacToeDbContext";
        }
       
    }
}
