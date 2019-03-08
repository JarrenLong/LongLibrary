using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class SubjectPeople : DbTable
  {
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("url")]
    public string URL { get; set; }
  }
}
