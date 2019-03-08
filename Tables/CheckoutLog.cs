using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LongLibrary
{
  public class CheckoutLog : DbTable
  {
    public virtual Book Book { get; set; }
    public virtual LibraryMember LibraryMember { get; set; }
    public DateTime CheckedOutAt { get; set; }
    public DateTime DueBackAt { get; set; }
    public DateTime ReturnedAt { get; set; }

    [NotMapped]
    public bool CheckedOut { get { return CheckedOutAt >= ReturnedAt; } }
    [NotMapped]
    public bool IsPastDue { get { return DateTime.Now >= DueBackAt && CheckedOut; } }

    public CheckoutLog()
    {
      DateTime curTime = DateTime.Now;
      CheckedOutAt = curTime;
      ReturnedAt = curTime;
      DueBackAt = curTime.AddDays(30);
    }
  }
}
