using System.Data.Entity.Migrations;

namespace LongLibrary
{
  internal sealed class LibraryConfiguration : DbMigrationsConfiguration<LibraryContext>
  {
    public LibraryConfiguration()
    {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
      ContextKey = "LongLibrary.LibraryContext";
    }

    protected override void Seed(LibraryContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data.
    }
  }
}
