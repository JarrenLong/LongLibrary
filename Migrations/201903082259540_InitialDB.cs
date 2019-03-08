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
            Subtitle = c.String(),
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
          "dbo.EBooks",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            CheckedOut = c.Boolean(nullable: false),
            PreviewURL = c.String(),
            BorrowURL = c.String(),
            Availability = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.Excerpts",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Comment = c.String(),
            Text = c.String(),
            IsFirstSentence = c.Boolean(nullable: false),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

      CreateTable(
          "dbo.Identifiers",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            AlibrisID_String = c.String(),
            LCCN_String = c.String(),
            OpenLibrary_String = c.String(),
            ISBN_10_String = c.String(),
            ISBN_13_String = c.String(),
            OCLC_String = c.String(),
            LibraryThing_String = c.String(),
            ProjectGutenberg_String = c.String(),
            Goodreads_String = c.String(),
            PaperbackSwap_String = c.String(),
          })
          .PrimaryKey(t => t.Id);

      CreateTable(
          "dbo.Links",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Title = c.String(),
            URL = c.String(),
            Book_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .Index(t => t.Book_Id);

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
          "dbo.CheckoutLogs",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            CheckedOutAt = c.DateTime(nullable: false),
            DueBackAt = c.DateTime(nullable: false),
            ReturnedAt = c.DateTime(nullable: false),
            Book_Id = c.Int(),
            LibraryMember_Id = c.Int(),
          })
          .PrimaryKey(t => t.Id)
          .ForeignKey("dbo.Books", t => t.Book_Id)
          .ForeignKey("dbo.LibraryMembers", t => t.LibraryMember_Id)
          .Index(t => t.Book_Id)
          .Index(t => t.LibraryMember_Id);

      CreateTable(
          "dbo.LibraryMembers",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            MemberNumber = c.String(),
            FirstName = c.String(),
            LastName = c.String(),
            Phone = c.String(),
            Email = c.String(),
            Address1 = c.String(),
            Address2 = c.String(),
            City = c.String(),
            State = c.String(),
            Zipcode = c.String(),
            MemberJoinedAt = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.Id);

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
      DropForeignKey("dbo.CheckoutLogs", "LibraryMember_Id", "dbo.LibraryMembers");
      DropForeignKey("dbo.CheckoutLogs", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.SubjectTimes", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Subjects", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.SubjectPlaces", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.SubjectPeoples", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.PublishPlaces", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Publishers", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Links", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Books", "Identifiers_Id", "dbo.Identifiers");
      DropForeignKey("dbo.Excerpts", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.EBooks", "Book_Id", "dbo.Books");
      DropForeignKey("dbo.Books", "Cover_Id", "dbo.Covers");
      DropForeignKey("dbo.Books", "Classifications_Id", "dbo.Classifications");
      DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
      DropIndex("dbo.CheckoutLogs", new[] { "LibraryMember_Id" });
      DropIndex("dbo.CheckoutLogs", new[] { "Book_Id" });
      DropIndex("dbo.SubjectTimes", new[] { "Book_Id" });
      DropIndex("dbo.Subjects", new[] { "Book_Id" });
      DropIndex("dbo.SubjectPlaces", new[] { "Book_Id" });
      DropIndex("dbo.SubjectPeoples", new[] { "Book_Id" });
      DropIndex("dbo.PublishPlaces", new[] { "Book_Id" });
      DropIndex("dbo.Publishers", new[] { "Book_Id" });
      DropIndex("dbo.Links", new[] { "Book_Id" });
      DropIndex("dbo.Excerpts", new[] { "Book_Id" });
      DropIndex("dbo.EBooks", new[] { "Book_Id" });
      DropIndex("dbo.Books", new[] { "Identifiers_Id" });
      DropIndex("dbo.Books", new[] { "Cover_Id" });
      DropIndex("dbo.Books", new[] { "Classifications_Id" });
      DropIndex("dbo.Authors", new[] { "Book_Id" });
      DropTable("dbo.Unmatcheds");
      DropTable("dbo.LibraryMembers");
      DropTable("dbo.CheckoutLogs");
      DropTable("dbo.SubjectTimes");
      DropTable("dbo.Subjects");
      DropTable("dbo.SubjectPlaces");
      DropTable("dbo.SubjectPeoples");
      DropTable("dbo.PublishPlaces");
      DropTable("dbo.Publishers");
      DropTable("dbo.Links");
      DropTable("dbo.Identifiers");
      DropTable("dbo.Excerpts");
      DropTable("dbo.EBooks");
      DropTable("dbo.Covers");
      DropTable("dbo.Classifications");
      DropTable("dbo.Books");
      DropTable("dbo.Authors");
    }
  }
}
