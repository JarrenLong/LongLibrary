using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LongLibrary
{
  public partial class MemberListForm : Form
  {
    private LibraryContext ctx = new LibraryContext();

    public MemberListForm()
    {
      InitializeComponent();
    }

    private void DataGridViewBookList_SelectionChanged(object sender, EventArgs e)
    {
      ctx.SaveChanges();
      textBoxEmail.DataBindings.Clear();
      textBoxPhone.DataBindings.Clear();
      textBoxLastName.DataBindings.Clear();
      textBoxFirstName.DataBindings.Clear();
      textBoxCity.DataBindings.Clear();
      textBoxZipcode.DataBindings.Clear();
      textBoxState.DataBindings.Clear();
      textBoxAddress2.DataBindings.Clear();
      textBoxAddress1.DataBindings.Clear();
      textBoxMemberNumber.DataBindings.Clear();

      foreach (DataGridViewRow r in DataGridViewBookList.SelectedRows)
      {
        if (!r.IsNewRow && r.Selected)
        {
          var it = r.DataBoundItem;

          if (it != null)
          {
            int selId = ((LibraryMember)it).Id;
            var sel = ctx.LibraryMembers.FirstOrDefault(x => x.Id == selId);
            //labelTitle.Text = sel.Title;
            //labelAuthor.Text = sel.AuthorString;
            if (sel != null)
            {
              textBoxEmail.DataBindings.Add(new Binding("Text", sel, "Email"));
              textBoxPhone.DataBindings.Add(new Binding("Text", sel, "Phone"));
              textBoxLastName.DataBindings.Add(new Binding("Text", sel, "LastName"));
              textBoxFirstName.DataBindings.Add(new Binding("Text", sel, "FirstName"));
              textBoxCity.DataBindings.Add(new Binding("Text", sel, "City"));
              textBoxZipcode.DataBindings.Add(new Binding("Text", sel, "Zipcode"));
              textBoxState.DataBindings.Add(new Binding("Text", sel, "State"));
              textBoxAddress2.DataBindings.Add(new Binding("Text", sel, "Address2"));
              textBoxAddress1.DataBindings.Add(new Binding("Text", sel, "Address1"));
              textBoxMemberNumber.DataBindings.Add(new Binding("Text", sel, "MemberNumber"));
            }
          }
        }
      }
    }

    private void MyLibrary_Shown(object sender, EventArgs e)
    {
      DataGridViewBookList.DataSource = ctx.LibraryMembers.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
    }

    private void toolStripButtonAddMember_Click(object sender, EventArgs e)
    {
      var sel = ctx.LibraryMembers.Add(new LibraryMember()
      {
        FirstName = "Member",
        LastName = "A New"
      });

      ctx.SaveChanges();
      DataGridViewBookList.DataSource = ctx.LibraryMembers.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      ctx.SaveChanges();
      textBoxEmail.DataBindings.Clear();
      textBoxPhone.DataBindings.Clear();
      textBoxLastName.DataBindings.Clear();
      textBoxFirstName.DataBindings.Clear();
      textBoxCity.DataBindings.Clear();
      textBoxZipcode.DataBindings.Clear();
      textBoxState.DataBindings.Clear();
      textBoxAddress2.DataBindings.Clear();
      textBoxAddress1.DataBindings.Clear();
      textBoxMemberNumber.DataBindings.Clear();
    }
  }
}
