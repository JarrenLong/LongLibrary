namespace LongLibrary
{
  using System.Data.Entity.Migrations;

  /// <summary>
  /// 
  /// </summary>
  public partial class MemberCheckout : DbMigration
  {
    /// <summary>
    /// 
    /// </summary>
    public override void Up()
    {
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

    }

    /// <summary>
    /// 
    /// </summary>
    public override void Down()
    {
      DropForeignKey("dbo.CheckoutLogs", "LibraryMember_Id", "dbo.LibraryMembers");
      DropForeignKey("dbo.CheckoutLogs", "Book_Id", "dbo.Books");
      DropIndex("dbo.CheckoutLogs", new[] { "LibraryMember_Id" });
      DropIndex("dbo.CheckoutLogs", new[] { "Book_Id" });
      DropTable("dbo.LibraryMembers");
      DropTable("dbo.CheckoutLogs");
    }
  }
}
