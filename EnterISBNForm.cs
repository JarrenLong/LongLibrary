using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LongLibrary
{
  public partial class EnterISBNForm : Form
  {
    public EnterISBNForm()
    {
      InitializeComponent();
    }

    private void ButtonLookup_Click(object sender, EventArgs e)
    {
      labelStatus.Text = "Looking up ...";
      labelStatus.ForeColor = Color.Blue;

      bool ret = LookupISBN_GoogleBooks(TextBoxISBN.Text);

      if (!ret)
      {
        labelStatus.Text = "Error!";
        labelStatus.ForeColor = Color.Red;
      }
      else
      {
        labelStatus.Text = "Added!";
        labelStatus.ForeColor = Color.Green;
      }

      TextBoxISBN.Text = "";
      TextBoxISBN.Focus();
    }

    private void TextBoxISBN_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        ButtonLookup_Click(null, EventArgs.Empty);
    }

    private bool LookupISBN_OpenLibrary(string isbn)
    {
      string jsonTopLevelKey = "ISBN:" + isbn;
      string req = "https://openlibrary.org/api/books?bibkeys=" + jsonTopLevelKey + "&jscmd=data&format=json";
      string json = "";
      bool ret = false;

      using (var ctx = new LibraryContext())
      {
        // Make the API request
        using (var wc = new WebClient())
          json = wc.DownloadString(req);

        // If we couldn't find anything, abort now
        if (string.IsNullOrEmpty(json))
          return false;

        // Convert the response into an object we can use
        var rsp = JsonConvert.DeserializeObject<Dictionary<string, Book>>(json);

        if (rsp != null && rsp.Count > 0)
        {
          // Save the new book(s) to the database
          foreach (var b in rsp.Select(x => x.Value))
            ctx.Books.Add(b);

          ret = true;
        }

        if (!ret)
        {
          // Could not find a match, store it for later
          ctx.Unmatched.Add(new Unmatched() { Barcode = isbn });
        }

        ctx.SaveChanges();
      }

      return ret;
    }

    public static bool LookupISBN_GoogleBooks(string isbn)
    {
      bool ret = false;

      try
      {
        string json = "";

        using (var ctx = new LibraryContext())
        {
          // Make the API request
          using (var wc = new WebClient())
            json = wc.DownloadString("https://www.googleapis.com/books/v1/volumes?q=isbn:" + isbn);

          // If we couldn't find anything, abort now
          if (string.IsNullOrEmpty(json))
            return ret;

          // Convert the response into an object we can use
          var rsp = JsonConvert.DeserializeObject<RootObject>(json);

          if (rsp != null && rsp.items.Count > 0)
          {
            var vols = rsp.items.Select(x => x.volumeInfo);
            foreach (var v in vols)
            {
              Book buf = new Book();
              buf.Title = v.title;
              buf.Subtitle = v.subtitle;
              buf.URL = v.canonicalVolumeLink;
              buf.Notes = v.description;
              buf.NumberOfPages = v.pageCount;
              buf.Pagination = v.printType;
              buf.PublishDate = v.publishedDate;
              buf.ByStatement = "";
              buf.Key = "";

              buf.Publishers.Add(new Publisher() { Name = v.publisher });

              foreach (var a in v.authors)
                buf.Authors.Add(new Author() { Name = a });

              buf.Identifiers = new Identifiers();
              foreach (var id in v.industryIdentifiers)
              {
                switch (id.type.ToLower())
                {
                  case "isbn_10": buf.Identifiers.ISBN_10.Add(id.identifier); break;
                  case "isbn_13": buf.Identifiers.ISBN_13.Add(id.identifier); break;
                  case "alibris_id": buf.Identifiers.AlibrisID.Add(id.identifier); break;
                  case "lccn": buf.Identifiers.LCCN.Add(id.identifier); break;
                  case "openlibrary": buf.Identifiers.OpenLibrary.Add(id.identifier); break;
                  case "oclc": buf.Identifiers.OCLC.Add(id.identifier); break;
                  case "librarything": buf.Identifiers.LibraryThing.Add(id.identifier); break;
                  case "project_gutenberg": buf.Identifiers.ProjectGutenberg.Add(id.identifier); break;
                  case "goodreads": buf.Identifiers.Goodreads.Add(id.identifier); break;
                  case "paperback_swap": buf.Identifiers.PaperbackSwap.Add(id.identifier); break;
                }
              }

              buf.Links.Add(new Link() { Title = "Preview", URL = v.previewLink });
              buf.Links.Add(new Link() { Title = "Info", URL = v.infoLink });

              buf.Cover = new Cover()
              {
                Small = v.imageLinks.smallThumbnail,
                Large = v.imageLinks.thumbnail
              };

              ctx.Books.Add(buf);

              ret = true;
            }

            ctx.SaveChanges();
          }

          if (!ret)
          {
            // Could not find a match, store it for later
            ctx.Unmatched.Add(new Unmatched() { Barcode = isbn });
          }
        }
      }
      catch
      {
        ret = false;
      }

      return ret;
    }
  }

  #region Google Books API

  public class IndustryIdentifier
  {
    public string type { get; set; }
    public string identifier { get; set; }
  }

  public class ReadingModes
  {
    public bool text { get; set; }
    public bool image { get; set; }
  }

  public class PanelizationSummary
  {
    public bool containsEpubBubbles { get; set; }
    public bool containsImageBubbles { get; set; }
  }

  public class ImageLinks
  {
    public string smallThumbnail { get; set; }
    public string thumbnail { get; set; }
  }

  public class VolumeInfo
  {
    public string title { get; set; }
    public string subtitle { get; set; }
    public List<string> authors { get; set; }
    public string publisher { get; set; }
    public string publishedDate { get; set; }
    public string description { get; set; }
    public List<IndustryIdentifier> industryIdentifiers { get; set; }
    public ReadingModes readingModes { get; set; }
    public int pageCount { get; set; }
    public string printType { get; set; }
    public List<string> categories { get; set; }
    public double averageRating { get; set; }
    public int ratingsCount { get; set; }
    public string maturityRating { get; set; }
    public bool allowAnonLogging { get; set; }
    public string contentVersion { get; set; }
    public PanelizationSummary panelizationSummary { get; set; }
    public ImageLinks imageLinks { get; set; }
    public string language { get; set; }
    public string previewLink { get; set; }
    public string infoLink { get; set; }
    public string canonicalVolumeLink { get; set; }
  }

  public class SaleInfo
  {
    public string country { get; set; }
    public string saleability { get; set; }
    public bool isEbook { get; set; }
  }

  public class Epub
  {
    public bool isAvailable { get; set; }
  }

  public class Pdf
  {
    public bool isAvailable { get; set; }
  }

  public class AccessInfo
  {
    public string country { get; set; }
    public string viewability { get; set; }
    public bool embeddable { get; set; }
    public bool publicDomain { get; set; }
    public string textToSpeechPermission { get; set; }
    public Epub epub { get; set; }
    public Pdf pdf { get; set; }
    public string webReaderLink { get; set; }
    public string accessViewStatus { get; set; }
    public bool quoteSharingAllowed { get; set; }
  }

  public class SearchInfo
  {
    public string textSnippet { get; set; }
  }

  public class Item
  {
    public string kind { get; set; }
    public string id { get; set; }
    public string etag { get; set; }
    public string selfLink { get; set; }
    public VolumeInfo volumeInfo { get; set; }
    public SaleInfo saleInfo { get; set; }
    public AccessInfo accessInfo { get; set; }
    public SearchInfo searchInfo { get; set; }
  }

  public class RootObject
  {
    public string kind { get; set; }
    public int totalItems { get; set; }
    public List<Item> items { get; set; }
  }
  #endregion
}
