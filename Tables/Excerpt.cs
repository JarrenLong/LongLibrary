using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LongLibrary
{
  public class Excerpt : DbTable
  {
    [JsonProperty("comment")]
    public string Comment { get; set; }
    [JsonProperty("text")]
    public string Text { get; set; }
    [JsonProperty("first_sentence")]
    public bool IsFirstSentence { get; set; }
  }
}
