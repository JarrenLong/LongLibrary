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

      // Try checking Google Books API first
      bool ret = LookupISBN_GoogleBooks(TextBoxISBN.Text);
      if (!ret)
      {
        // If book was not found, check OpenLibrary API
        ret = LookupISBN_OpenLibrary(TextBoxISBN.Text);
        if (!ret)
        {
          // If we still haven't found a referene, store the ISBN for later use
          using (var ctx = new LibraryContext())
          {
            ctx.Unmatched.Add(new Unmatched() { Barcode = TextBoxISBN.Text });
            ctx.SaveChanges();
          }
        }
      }

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
        }
      }
      catch
      {
        ret = false;
      }

      return ret;
    }
  }
}
