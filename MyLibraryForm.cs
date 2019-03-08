using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LongLibrary
{
  public partial class MyLibraryForm : Form
  {
    public MyLibraryForm()
    {
      InitializeComponent();
    }

    private void DataGridViewBookList_SelectionChanged(object sender, EventArgs e)
    {
      foreach (DataGridViewRow r in DataGridViewBookList.SelectedRows)
      {
        if (!r.IsNewRow && r.Selected)
        {
          var it = r.DataBoundItem;

          if (it != null)
          {
            int selId = ((Book)it).Id;

            using (var ctx = new LibraryContext())
            {
              var sel = ctx.Books.FirstOrDefault(x => x.Id == selId);
              labelTitle.Text = sel.Title;
              labelAuthor.Text = sel.AuthorString;

              if (sel.Cover != null)
              {
                try
                {
                  string tempImg = Path.GetTempFileName();
                  string toDl = "";

                  if (!string.IsNullOrEmpty(sel.Cover.Large))
                    toDl = sel.Cover.Large;
                  else if (!string.IsNullOrEmpty(sel.Cover.Medium))
                    toDl = sel.Cover.Medium;
                  else if (!string.IsNullOrEmpty(sel.Cover.Small))
                    toDl = sel.Cover.Small;

                  if (string.IsNullOrEmpty(toDl))
                    throw new Exception();

                  using (var wc = new WebClient())
                    wc.DownloadFile(toDl, tempImg);

                  pictureBoxCover.Image = Image.FromFile(tempImg);
                }
                catch { pictureBoxCover.Image = null; }
              }
            }
          }
        }
      }
    }

    private void MyLibrary_Shown(object sender, EventArgs e)
    {
      DataGridViewBookList.AutoGenerateColumns = false;

      using (var ctx = new LibraryContext())
        DataGridViewBookList.DataSource = ctx.Books.OrderBy(x => x.Title).ToList();
    }

    private void buttonAddNew_Click(object sender, EventArgs e)
    {
      using (var frm = new EnterISBNForm())
        frm.ShowDialog();

      using (var ctx = new LibraryContext())
        DataGridViewBookList.DataSource = ctx.Books.OrderBy(x => x.Title).ToList();
    }
  }
}
