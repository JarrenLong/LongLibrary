using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LongLibrary
{
  public partial class MyLibraryForm : Form
  {
    private LibraryContext db = new LibraryContext();
    private Book currentBook = null;

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

            currentBook = db.Books.FirstOrDefault(x => x.Id == selId);
            if (currentBook == null)
            {
              dataGridViewCheckoutLog.DataSource = null;
              labelTitle.Text = "";
              labelAuthor.Text = "";
              pictureBoxCover.Image = null;
              checkBoxCheckedOut.Checked = false;
              checkBoxPastDue.Checked = false;
            }
            else
            {
              labelTitle.Text = currentBook.Title;
              labelAuthor.Text = currentBook.AuthorString;
              checkBoxCheckedOut.Checked = db.CheckoutLogs.Where(x => x.Book.Id == currentBook.Id && x.CheckedOutAt >= x.ReturnedAt).ToList().LastOrDefault() != null;
              DateTime now = DateTime.Now;
              checkBoxPastDue.Checked = db.CheckoutLogs.Where(x => x.Book.Id == currentBook.Id && x.DueBackAt <= now).ToList().LastOrDefault() != null; 

              if (currentBook.Cover != null)
              {
                try
                {
                  string tempImg = Path.GetTempFileName();
                  string toDl = "";

                  if (!string.IsNullOrEmpty(currentBook.Cover.Large))
                    toDl = currentBook.Cover.Large;
                  else if (!string.IsNullOrEmpty(currentBook.Cover.Medium))
                    toDl = currentBook.Cover.Medium;
                  else if (!string.IsNullOrEmpty(currentBook.Cover.Small))
                    toDl = currentBook.Cover.Small;

                  if (string.IsNullOrEmpty(toDl))
                    throw new Exception();

                  using (var wc = new WebClient())
                    wc.DownloadFile(toDl, tempImg);

                  pictureBoxCover.Image = Image.FromFile(tempImg);
                }
                catch { pictureBoxCover.Image = null; }
              }

              dataGridViewCheckoutLog.DataSource = db.CheckoutLogs.Where(x => x.Book.Id == currentBook.Id).OrderByDescending(x => x.CheckedOutAt).ToList();
            }
          }
        }
      }
    }

    private void MyLibrary_Shown(object sender, EventArgs e)
    {
      DataGridViewBookList.AutoGenerateColumns = false;

      DataGridViewBookList.DataSource = db.Books.OrderBy(x => x.Title).ToList();
    }

    private void toolStripButtonAddNewBook_Click(object sender, EventArgs e)
    {
      using (var frm = new EnterISBNForm())
        frm.ShowDialog();

      DataGridViewBookList.DataSource = db.Books.OrderBy(x => x.Title).ToList();
    }

    private void toolStripButtonViewMembers_Click(object sender, EventArgs e)
    {
      using (var frm = new MemberListForm())
        frm.ShowDialog();
    }

    private void buttonCheckout_Click(object sender, EventArgs e)
    {
      if (currentBook == null)
        return;

      if(db.CheckoutLogs.Where(x => x.Book.Id == currentBook.Id && x.CheckedOutAt >= x.ReturnedAt).ToList().LastOrDefault() != null)
      {
        MessageBox.Show("This book is already checked out!");
        return;
      }

      int memberId = 0;
      using (var frm = new PickMemberForm())
        if (frm.ShowDialog() == DialogResult.OK)
          memberId = frm.MemberId;

      if (memberId == 0)
        return;

      var member = db.LibraryMembers.FirstOrDefault(x => x.Id == memberId);
      db.CheckoutLogs.Add(new CheckoutLog()
      {
        Book = currentBook,
        LibraryMember = member
      });
      db.SaveChanges();

      checkBoxCheckedOut.Checked = !checkBoxCheckedOut.Checked;
    }

    private void buttonCheckIn_Click(object sender, EventArgs e)
    {
      if (currentBook == null)
        return;

      var lastCheckout = db.CheckoutLogs.Where(x => x.Book.Id == currentBook.Id && x.CheckedOutAt >= x.ReturnedAt).ToList().LastOrDefault();
      if (lastCheckout == null)
        MessageBox.Show("This book is not currently checked out!");
      else
      {
        lastCheckout.ReturnedAt = DateTime.Now;
        db.SaveChanges();

        MessageBox.Show("This book has been returned.");

        checkBoxCheckedOut.Checked = !checkBoxCheckedOut.Checked;
      }
    }
  }
}
