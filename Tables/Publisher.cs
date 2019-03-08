using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class Publisher : DbTable
  {
    [JsonProperty("name")]
    public string Name { get; set; }
  }
}
