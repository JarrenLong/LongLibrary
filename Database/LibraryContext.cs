using System.Data.Entity;

namespace LongLibrary
{
  public partial class LibraryContext : DbContext
  {
    /// <summary>
    /// 
    /// </summary>
    public LibraryContext()
        : base(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;MultipleActiveResultSets=true", ".\\SQLEXPRESS", "LongLibrary"))
    {
      //Configuration.AutoDetectChangesEnabled = false;
      //Configuration.LazyLoadingEnabled = false;
      //Configuration.ProxyCreationEnabled = false;
    }

    public virtual DbSet<Unmatched> Unmatched { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<SubjectTime> SubjectTimes { get; set; }
    public virtual DbSet<PublishPlace> PublishPlaces { get; set; }
    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<SubjectPeople> SubjectPeople { get; set; }
    public virtual DbSet<Subject> Subjects { get; set; }
    public virtual DbSet<SubjectPlace> SubjectPlaces { get; set; }
    public virtual DbSet<Cover> Covers { get; set; }
    public virtual DbSet<Classifications> Classifications { get; set; }
    public virtual DbSet<Identifiers> Identifiers { get; set; }
    public virtual DbSet<Publisher> Publishers { get; set; }
    public virtual DbSet<LibraryMember> LibraryMembers { get; set; }
    public virtual DbSet<CheckoutLog> CheckoutLogs { get; set; }
    public virtual DbSet<Link> Links { get; set; }
    public virtual DbSet<Excerpt> Excerpts { get; set; }
    public virtual DbSet<EBook> EBooks { get; set; }
  }
}
