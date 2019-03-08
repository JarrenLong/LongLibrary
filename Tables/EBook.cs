using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class EBook : DbTable
  {
    [JsonProperty("checkedout")]
    public bool CheckedOut { get; set; }
    // public object Formats {get;set;} // TODO
    [JsonProperty("preview_url")]
    public string PreviewURL { get; set; }
    [JsonProperty("borrow_url")]
    public string BorrowURL { get; set; }
    [JsonProperty("availability")]
    public string Availability { get; set; }
  }
}
