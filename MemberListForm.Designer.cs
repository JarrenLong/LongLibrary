namespace LongLibrary
{
  partial class MemberListForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberListForm));
      this.DataGridViewBookList = new System.Windows.Forms.DataGridView();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxFirstName = new System.Windows.Forms.TextBox();
      this.textBoxLastName = new System.Windows.Forms.TextBox();
      this.labelLastName = new System.Windows.Forms.Label();
      this.textBoxPhone = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxMemberNumber = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxCity = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxZipcode = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxState = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBoxAddress2 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.textBoxAddress1 = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddMember = new System.Windows.Forms.ToolStripButton();
      this.buttonSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // DataGridViewBookList
      // 
      this.DataGridViewBookList.AllowUserToAddRows = false;
      this.DataGridViewBookList.AllowUserToDeleteRows = false;
      this.DataGridViewBookList.AllowUserToOrderColumns = true;
      this.DataGridViewBookList.AllowUserToResizeRows = false;
      this.DataGridViewBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.DataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGridViewBookList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridViewBookList.Location = new System.Drawing.Point(0, 0);
      this.DataGridViewBookList.Name = "DataGridViewBookList";
      this.DataGridViewBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridViewBookList.Size = new System.Drawing.Size(261, 533);
      this.DataGridViewBookList.TabIndex = 0;
      this.DataGridViewBookList.SelectionChanged += new System.EventHandler(this.DataGridViewBookList_SelectionChanged);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Location = new System.Drawing.Point(0, 28);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.DataGridViewBookList);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxCity);
      this.splitContainer1.Panel2.Controls.Add(this.label6);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxZipcode);
      this.splitContainer1.Panel2.Controls.Add(this.label7);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxState);
      this.splitContainer1.Panel2.Controls.Add(this.label8);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxAddress2);
      this.splitContainer1.Panel2.Controls.Add(this.label9);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxAddress1);
      this.splitContainer1.Panel2.Controls.Add(this.label10);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxMemberNumber);
      this.splitContainer1.Panel2.Controls.Add(this.label5);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxEmail);
      this.splitContainer1.Panel2.Controls.Add(this.label4);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxPhone);
      this.splitContainer1.Panel2.Controls.Add(this.label3);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxLastName);
      this.splitContainer1.Panel2.Controls.Add(this.labelLastName);
      this.splitContainer1.Panel2.Controls.Add(this.textBoxFirstName);
      this.splitContainer1.Panel2.Controls.Add(this.label1);
      this.splitContainer1.Size = new System.Drawing.Size(784, 533);
      this.splitContainer1.SplitterDistance = 261;
      this.splitContainer1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "First Name";
      // 
      // textBoxFirstName
      // 
      this.textBoxFirstName.Location = new System.Drawing.Point(85, 27);
      this.textBoxFirstName.Name = "textBoxFirstName";
      this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
      this.textBoxFirstName.TabIndex = 1;
      // 
      // textBoxLastName
      // 
      this.textBoxLastName.Location = new System.Drawing.Point(287, 27);
      this.textBoxLastName.Name = "textBoxLastName";
      this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
      this.textBoxLastName.TabIndex = 3;
      // 
      // labelLastName
      // 
      this.labelLastName.AutoSize = true;
      this.labelLastName.Location = new System.Drawing.Point(223, 30);
      this.labelLastName.Name = "labelLastName";
      this.labelLastName.Size = new System.Drawing.Size(58, 13);
      this.labelLastName.TabIndex = 2;
      this.labelLastName.Text = "Last Name";
      // 
      // textBoxPhone
      // 
      this.textBoxPhone.Location = new System.Drawing.Point(85, 53);
      this.textBoxPhone.Name = "textBoxPhone";
      this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
      this.textBoxPhone.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(31, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Phone #";
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Location = new System.Drawing.Point(287, 53);
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
      this.textBoxEmail.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(208, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Email Address";
      // 
      // textBoxMemberNumber
      // 
      this.textBoxMemberNumber.Location = new System.Drawing.Point(85, 79);
      this.textBoxMemberNumber.Name = "textBoxMemberNumber";
      this.textBoxMemberNumber.Size = new System.Drawing.Size(302, 20);
      this.textBoxMemberNumber.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 82);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Member #";
      // 
      // textBoxCity
      // 
      this.textBoxCity.Location = new System.Drawing.Point(85, 157);
      this.textBoxCity.Name = "textBoxCity";
      this.textBoxCity.Size = new System.Drawing.Size(302, 20);
      this.textBoxCity.TabIndex = 19;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(55, 160);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(24, 13);
      this.label6.TabIndex = 18;
      this.label6.Text = "City";
      // 
      // textBoxZipcode
      // 
      this.textBoxZipcode.Location = new System.Drawing.Point(85, 209);
      this.textBoxZipcode.Name = "textBoxZipcode";
      this.textBoxZipcode.Size = new System.Drawing.Size(302, 20);
      this.textBoxZipcode.TabIndex = 17;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(57, 212);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(22, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Zip";
      // 
      // textBoxState
      // 
      this.textBoxState.Location = new System.Drawing.Point(85, 183);
      this.textBoxState.Name = "textBoxState";
      this.textBoxState.Size = new System.Drawing.Size(302, 20);
      this.textBoxState.TabIndex = 15;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(47, 186);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(32, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "State";
      // 
      // textBoxAddress2
      // 
      this.textBoxAddress2.Location = new System.Drawing.Point(85, 131);
      this.textBoxAddress2.Name = "textBoxAddress2";
      this.textBoxAddress2.Size = new System.Drawing.Size(302, 20);
      this.textBoxAddress2.TabIndex = 13;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(25, 134);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(54, 13);
      this.label9.TabIndex = 12;
      this.label9.Text = "Address 2";
      // 
      // textBoxAddress1
      // 
      this.textBoxAddress1.Location = new System.Drawing.Point(85, 105);
      this.textBoxAddress1.Name = "textBoxAddress1";
      this.textBoxAddress1.Size = new System.Drawing.Size(302, 20);
      this.textBoxAddress1.TabIndex = 11;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(25, 108);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(54, 13);
      this.label10.TabIndex = 10;
      this.label10.Text = "Address 1";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddMember});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(784, 25);
      this.toolStrip1.TabIndex = 3;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonAddMember
      // 
      this.toolStripButtonAddMember.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddMember.Image")));
      this.toolStripButtonAddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddMember.Name = "toolStripButtonAddMember";
      this.toolStripButtonAddMember.Size = new System.Drawing.Size(97, 22);
      this.toolStripButtonAddMember.Text = "Add &Member";
      this.toolStripButtonAddMember.Click += new System.EventHandler(this.toolStripButtonAddMember_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(204, 253);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(110, 23);
      this.buttonSave.TabIndex = 20;
      this.buttonSave.Text = "&Save Changes";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // MemberListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.splitContainer1);
      this.Name = "MemberListForm";
      this.Text = "MyLibrary";
      this.Shown += new System.EventHandler(this.MyLibrary_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView DataGridViewBookList;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TextBox textBoxEmail;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxPhone;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxLastName;
    private System.Windows.Forms.Label labelLastName;
    private System.Windows.Forms.TextBox textBoxFirstName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxCity;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxZipcode;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxState;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxAddress2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox textBoxAddress1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBoxMemberNumber;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddMember;
    private System.Windows.Forms.Button buttonSave;
  }
}