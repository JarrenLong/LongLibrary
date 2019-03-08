using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LongLibrary
{
  public class Book : DbTable
  {
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("url")]
    public string URL { get; set; }
    [JsonProperty("notes")]
    public string Notes { get; set; }
    [JsonProperty("number_of_pages")]
    public int NumberOfPages { get; set; }
    [JsonProperty("pagination")]
    public string Pagination { get; set; }
    [JsonProperty("publish_date")]
    public string PublishDate { get; set; }
    [JsonProperty("by_statement")]
    public string ByStatement { get; set; }
    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("publishers")]
    public virtual List<Publisher> Publishers { get; set; }
    [JsonProperty("identifiers")]
    public virtual Identifiers Identifiers { get; set; }
    [JsonProperty("classifications")]
    public virtual Classifications Classifications { get; set; }
    [JsonProperty("cover")]
    public virtual Cover Cover { get; set; }
    [JsonProperty("subject_places")]
    public virtual List<SubjectPlace> SubjectPlaces { get; set; }
    [JsonProperty("subjects")]
    public virtual List<Subject> Subjects { get; set; }
    [JsonProperty("subject_people")]
    public virtual List<SubjectPeople> SubjectPeople { get; set; }
    [JsonProperty("authors")]
    public virtual List<Author> Authors { get; set; }
    [JsonProperty("publish_places")]
    public virtual List<PublishPlace> PublishPlaces { get; set; }
    [JsonProperty("subject_times")]
    public virtual List<SubjectTime> SubjectTimes { get; set; }

    [JsonIgnore, NotMapped]
    public string AuthorString { get { return Authors == null ? "" : string.Join(", ", Authors.Select(x => x.Name)); } }
  }
}
