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

      bool ret = LookupISBN(TextBoxISBN.Text);

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

    private bool LookupISBN(string isbn)
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
  }
}
