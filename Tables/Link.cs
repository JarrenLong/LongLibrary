using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class Link : DbTable
  {
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("url")]
    public string URL { get; set; }
  }
}
