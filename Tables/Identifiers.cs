using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LongLibrary
{
  public class Identifiers : DbTable
  {
    private List<string> _AlibrisID { get; set; }
    [JsonProperty("alibris_id"), NotMapped]
    public List<string> AlibrisID
    {
      get { return _AlibrisID; }
      set { _AlibrisID = value; }
    }
    public string AlibrisID_String
    {
      get { return _AlibrisID == null ? "" : string.Join("|", _AlibrisID); }
      set { _AlibrisID = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _LCCN { get; set; }
    [JsonProperty("lccn"), NotMapped]
    public List<string> LCCN
    {
      get { return _LCCN; }
      set { _LCCN = value; }
    }
    public string LCCN_String
    {
      get { return _LCCN == null ? "" : string.Join("|", _LCCN); }
      set { _LCCN = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _OpenLibrary { get; set; }
    [JsonProperty("openlibrary"), NotMapped]
    public List<string> OpenLibrary
    {
      get { return _OpenLibrary; }
      set { _OpenLibrary = value; }
    }
    public string OpenLibrary_String
    {
      get { return _OpenLibrary == null ? "" : string.Join("|", _OpenLibrary); }
      set { _OpenLibrary = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _ISBN_10 { get; set; }
    [JsonProperty("isbn_10"), NotMapped]
    public List<string> ISBN_10
    {
      get { return _ISBN_10; }
      set { _ISBN_10 = value; }
    }
    public string ISBN_10_String
    {
      get { return _ISBN_10 == null ? "" : string.Join("|", _ISBN_10); }
      set { _ISBN_10 = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _ISBN_13 { get; set; }
    [JsonProperty("isbn_13"), NotMapped]
    public List<string> ISBN_13
    {
      get { return _ISBN_13; }
      set { _ISBN_13 = value; }
    }
    public string ISBN_13_String
    {
      get { return _ISBN_13 == null ? "" : string.Join("|", _ISBN_13); }
      set { _ISBN_13 = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _OCLC { get; set; }
    [JsonProperty("oclc"), NotMapped]
    public List<string> OCLC
    {
      get { return _OCLC; }
      set { _OCLC = value; }
    }
    public string OCLC_String
    {
      get { return _OCLC == null ? "" : string.Join("|", _OCLC); }
      set { _OCLC = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _LibraryThing { get; set; }
    [JsonProperty("librarything"), NotMapped]
    public List<string> LibraryThing
    {
      get { return _LibraryThing; }
      set { _LibraryThing = value; }
    }
    public string LibraryThing_String
    {
      get { return _LibraryThing == null ? "" : string.Join("|", _LibraryThing); }
      set { _LibraryThing = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _ProjectGutenberg { get; set; }
    [JsonProperty("project_gutenberg"), NotMapped]
    public List<string> ProjectGutenberg
    {
      get { return _ProjectGutenberg; }
      set { _ProjectGutenberg = value; }
    }
    public string ProjectGutenberg_String
    {
      get { return _ProjectGutenberg == null ? "" : string.Join("|", _ProjectGutenberg); }
      set { _ProjectGutenberg = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _Goodreads { get; set; }
    [JsonProperty("goodreads"), NotMapped]
    public List<string> Goodreads
    {
      get { return _Goodreads; }
      set { _Goodreads = value; }
    }
    public string Goodreads_String
    {
      get { return _Goodreads == null ? "" : string.Join("|", _Goodreads); }
      set { _Goodreads = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }

    private List<string> _PaperbackSwap { get; set; }
    [JsonProperty("paperback_swap"), NotMapped]
    public List<string> PaperbackSwap
    {
      get { return _PaperbackSwap; }
      set { _PaperbackSwap = value; }
    }
    public string PaperbackSwap_String
    {
      get { return _PaperbackSwap == null ? "" : string.Join("|", _PaperbackSwap); }
      set { _PaperbackSwap = value == null ? new List<string>() : value.Split(new char[] { '|' }).ToList(); }
    }
  }
}
