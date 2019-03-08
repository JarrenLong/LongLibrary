using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LongLibrary
{
  public class DbTable
  {
    [Key, JsonIgnore]
    public int Id { get; set; }
  }
}
