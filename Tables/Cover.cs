using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class Cover : DbTable
  {
    [JsonProperty("small")]
    public string Small { get; set; }
    [JsonProperty("medium")]
    public string Medium { get; set; }
    [JsonProperty("large")]
    public string Large { get; set; }
  }
}
