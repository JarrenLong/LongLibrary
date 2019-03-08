using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace LongLibrary
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      using (var ctx = new LibraryContext())
      {
        // Run a database migration, then store the new app version
        var configuration = new LibraryConfiguration();
        var migrator = new DbMigrator(configuration);
        migrator.Update();
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MyLibraryForm());
    }
  }
}
