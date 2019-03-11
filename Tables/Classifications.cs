using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LongLibrary
{
  public class Classifications : DbTable
  {
    public Classifications()
    {
      DeweyDecimal = new List<string>();
      LC = new List<string>();
    }


    private List<string> _DeweyDecimal { get; set; }
    [JsonProperty("dewey_decimal_class"), NotMapped]
    public List<string> DeweyDecimal
    {
      get { return _DeweyDecimal; }
      set { _DeweyDecimal = value; }
    }
    public string DeweyDecimal_String
    {
      get { return _DeweyDecimal == null ? "" : string.Join("|", _DeweyDecimal); }
      set { _DeweyDecimal = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _LC { get; set; }
    [JsonProperty("lc_classifications"), NotMapped]
    public List<string> LC
    {
      get { return _LC; }
      set { _LC = value; }
    }
    public string LC_String
    {
      get { return _LC == null ? "" : string.Join("|", _LC); }
      set { _LC = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }
  }
}
