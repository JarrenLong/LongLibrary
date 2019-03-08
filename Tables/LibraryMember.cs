using System;

namespace LongLibrary
{
  public class LibraryMember : DbTable
  {
    public string MemberNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }

    public DateTime MemberJoinedAt { get; set; }

    public LibraryMember()
    {
      MemberJoinedAt = DateTime.Now;
    }
  }
}
