using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LongLibrary
{
  public partial class PickMemberForm : Form
  {
    private LibraryContext db = new LibraryContext();
    public int MemberId = 0;

    public PickMemberForm()
    {
      InitializeComponent();
    }

    private void PickMemberForm_Shown(object sender, EventArgs e)
    {
      comboBoxMembers.DataSource = db.LibraryMembers.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
      comboBoxMembers.DisplayMember = "LastName";
      comboBoxMembers.ValueMember = "Id";
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
      if (comboBoxMembers.SelectedValue == null)
        MessageBox.Show("Please select a member first.");
      else
      {
        MemberId = (int)comboBoxMembers.SelectedValue;
        DialogResult = DialogResult.OK;
      }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
