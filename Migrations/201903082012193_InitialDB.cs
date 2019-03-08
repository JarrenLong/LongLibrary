namespace LongLibrary
{
  using System.Data.Entity.Migrations;

  /// <summary>
  /// 
  /// </summary>
  public partial class InitialDB : DbMigration
  {
    /// <summary>
    /// 
    /// </summary>
    public override void Up()
    {
      CreateTable(
          "dbo.Authors",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.Books",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Title = c.String(),
            URL = c.String(),
            Notes = c.String(),
            NumberOfPages = c.Int(nullable: false),
            Pagination = c.String(),
            PublishDate = c.String(),
            ByStatement = c.String(),
            Key = c.String(),
            Classifications_Id = c.Int(),
            Cover_Id = c.Int(),
            Identifiers_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Classifications", t => t.Classifications_Id)
          .ForeignKey("dbo.Covers", t => t.Cover_Id)
          .ForeignKey("dbo.Identifiers", t => t.Identifiers_Id)
          .Index(t => t.Classifications_Id)
          .Index(t => t.Cover_Id)
          .Index(t => t.Identifiers_Id);

      CreateTable(
          "dbo.Classifications",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            DeweyDecimal_String = c.String(),
            LC_String = c.String(),
          })
          .PrimaryKey(t => t.Id);

      CreateTable(
          "dbo.Covers",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Small = c.String(),
            Medium = c.String(),
            Large = c.String(),
          })
          .PrimaryKey(t => t.Id);

      CreateTable(
          "dbo.Identifiers",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            LCCN_String = c.String(),
            OpenLibrary_String = c.String(),
            ISBN_10_String = c.String(),
            OCLC_String = c.String(),
            LibraryThing_String = c.String(),
            ProjectGutenberg_String = c.String(),
            Goodreads_String = c.String(),
          })
          .PrimaryKey(t => t.Id);

      CreateTable(
          "dbo.Publishers",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.PublishPlaces",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.SubjectPeoples",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.SubjectPlaces",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.Subjects",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.SubjectTimes",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.Unmatcheds",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Barcode = c.String(),
          })
          .PrimaryKey(t => t.Id);

    }

    /// <summary>
    /// 
    /// </summary>
    public override void Down()
    {
      DropForeignKey("dbo.SubjectTimes", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Subjects", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.SubjectPlaces", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.SubjectPeoples", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.PublishPlaces", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Publishers", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Books", "Identifiers_Id", "dbo.Identifiers");
      DropForeignKey("dbo.Books", "Cover_Id", "dbo.Covers");
      DropForeignKey("dbo.Books", "Classifications_Id", "dbo.Classifications");
      DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
      DropIndex("dbo.SubjectTimes", new[] { "Book_Id" });
      DropIndex("dbo.Subjects", new[] { "Book_Id" });
      DropIndex("dbo.SubjectPlaces", new[] { "Book_Id" });
      DropIndex("dbo.SubjectPeoples", new[] { "Book_Id" });
      DropIndex("dbo.PublishPlaces", new[] { "Book_Id" });
      DropIndex("dbo.Publishers", new[] { "Book_Id" });
      DropIndex("dbo.Books", new[] { "Identifiers_Id" });
      DropIndex("dbo.Books", new[] { "Cover_Id" });
      DropIndex("dbo.Books", new[] { "Classifications_Id" });
      DropIndex("dbo.Authors", new[] { "Book_Id" });
      DropTable("dbo.Unmatcheds");
      DropTable("dbo.SubjectTimes");
      DropTable("dbo.Subjects");
      DropTable("dbo.SubjectPlaces");
      DropTable("dbo.SubjectPeoples");
      DropTable("dbo.PublishPlaces");
      DropTable("dbo.Publishers");
      DropTable("dbo.Identifiers");
      DropTable("dbo.Covers");
      DropTable("dbo.Classifications");
      DropTable("dbo.Books");
      DropTable("dbo.Authors");
    }
  }
}
