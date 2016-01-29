namespace FileSystem.Data
{
    using System.Data.Entity;
    using FileSystem.Models;
    using Migrations;
    public class FileSystemDbContext:DbContext
    {
        public FileSystemDbContext()
            :base("FileSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FileSystemDbContext, Configuration > ());
;        }

        public IDbSet<FileContent> FileContents { get; set; }
    }
}
