namespace LongLibrary
{
  partial class MyLibraryForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLibraryForm));
      this.DataGridViewBookList = new System.Windows.Forms.DataGridView();
      this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.labelAuthor = new System.Windows.Forms.Label();
      this.labelTitle = new System.Windows.Forms.Label();
      this.pictureBoxCover = new System.Windows.Forms.PictureBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddNewBook = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonViewMembers = new System.Windows.Forms.ToolStripButton();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGridViewCheckoutLog = new System.Windows.Forms.DataGridView();
      this.buttonCheckout = new System.Windows.Forms.Button();
      this.buttonCheckIn = new System.Windows.Forms.Button();
      this.checkBoxCheckedOut = new System.Windows.Forms.CheckBox();
      this.checkBoxPastDue = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckoutLog)).BeginInit();
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
      this.DataGridViewBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnAuthor});
      this.DataGridViewBookList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DataGridViewBookList.Location = new System.Drawing.Point(0, 0);
      this.DataGridViewBookList.Name = "DataGridViewBookList";
      this.DataGridViewBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridViewBookList.Size = new System.Drawing.Size(261, 536);
      this.DataGridViewBookList.TabIndex = 0;
      this.DataGridViewBookList.SelectionChanged += new System.EventHandler(this.DataGridViewBookList_SelectionChanged);
      // 
      // ColumnTitle
      // 
      this.ColumnTitle.DataPropertyName = "Title";
      this.ColumnTitle.HeaderText = "Title";
      this.ColumnTitle.Name = "ColumnTitle";
      this.ColumnTitle.Width = 52;
      // 
      // ColumnAuthor
      // 
      this.ColumnAuthor.DataPropertyName = "AuthorString";
      this.ColumnAuthor.HeaderText = "Author(s)";
      this.ColumnAuthor.Name = "ColumnAuthor";
      this.ColumnAuthor.Width = 74;
      // 
      // labelAuthor
      // 
      this.labelAuthor.Location = new System.Drawing.Point(109, 210);
      this.labelAuthor.Name = "labelAuthor";
      this.labelAuthor.Size = new System.Drawing.Size(300, 21);
      this.labelAuthor.TabIndex = 2;
      this.labelAuthor.Text = "The Book\'s Author";
      this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // labelTitle
      // 
      this.labelTitle.Location = new System.Drawing.Point(109, 189);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(300, 21);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "The Book\'s Title";
      this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pictureBoxCover
      // 
      this.pictureBoxCover.Location = new System.Drawing.Point(194, 16);
      this.pictureBoxCover.Name = "pictureBoxCover";
      this.pictureBoxCover.Size = new System.Drawing.Size(130, 170);
      this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxCover.TabIndex = 0;
      this.pictureBoxCover.TabStop = false;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddNewBook,
            this.toolStripButtonViewMembers});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(784, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonAddNewBook
      // 
      this.toolStripButtonAddNewBook.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddNewBook.Image")));
      this.toolStripButtonAddNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddNewBook.Name = "toolStripButtonAddNewBook";
      this.toolStripButtonAddNewBook.Size = new System.Drawing.Size(84, 22);
      this.toolStripButtonAddNewBook.Text = "Add &Books";
      this.toolStripButtonAddNewBook.Click += new System.EventHandler(this.toolStripButtonAddNewBook_Click);
      // 
      // toolStripButtonViewMembers
      // 
      this.toolStripButtonViewMembers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewMembers.Image")));
      this.toolStripButtonViewMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewMembers.Name = "toolStripButtonViewMembers";
      this.toolStripButtonViewMembers.Size = new System.Drawing.Size(105, 22);
      this.toolStripButtonViewMembers.Text = "View Members";
      this.toolStripButtonViewMembers.Click += new System.EventHandler(this.toolStripButtonViewMembers_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 25);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.DataGridViewBookList);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.checkBoxPastDue);
      this.splitContainer1.Panel2.Controls.Add(this.checkBoxCheckedOut);
      this.splitContainer1.Panel2.Controls.Add(this.buttonCheckIn);
      this.splitContainer1.Panel2.Controls.Add(this.buttonCheckout);
      this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCheckoutLog);
      this.splitContainer1.Panel2.Controls.Add(this.labelAuthor);
      this.splitContainer1.Panel2.Controls.Add(this.labelTitle);
      this.splitContainer1.Panel2.Controls.Add(this.pictureBoxCover);
      this.splitContainer1.Size = new System.Drawing.Size(784, 536);
      this.splitContainer1.SplitterDistance = 261;
      this.splitContainer1.TabIndex = 2;
      // 
      // dataGridViewCheckoutLog
      // 
      this.dataGridViewCheckoutLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewCheckoutLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCheckoutLog.Location = new System.Drawing.Point(3, 383);
      this.dataGridViewCheckoutLog.Name = "dataGridViewCheckoutLog";
      this.dataGridViewCheckoutLog.Size = new System.Drawing.Size(513, 150);
      this.dataGridViewCheckoutLog.TabIndex = 3;
      // 
      // buttonCheckout
      // 
      this.buttonCheckout.Location = new System.Drawing.Point(106, 354);
      this.buttonCheckout.Name = "buttonCheckout";
      this.buttonCheckout.Size = new System.Drawing.Size(150, 23);
      this.buttonCheckout.TabIndex = 4;
      this.buttonCheckout.Text = "Checkout Book";
      this.buttonCheckout.UseVisualStyleBackColor = true;
      this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
      // 
      // buttonCheckIn
      // 
      this.buttonCheckIn.Location = new System.Drawing.Point(262, 354);
      this.buttonCheckIn.Name = "buttonCheckIn";
      this.buttonCheckIn.Size = new System.Drawing.Size(150, 23);
      this.buttonCheckIn.TabIndex = 5;
      this.buttonCheckIn.Text = "Check In Book";
      this.buttonCheckIn.UseVisualStyleBackColor = true;
      this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
      // 
      // checkBoxCheckedOut
      // 
      this.checkBoxCheckedOut.AutoSize = true;
      this.checkBoxCheckedOut.Location = new System.Drawing.Point(331, 88);
      this.checkBoxCheckedOut.Name = "checkBoxCheckedOut";
      this.checkBoxCheckedOut.Size = new System.Drawing.Size(134, 17);
      this.checkBoxCheckedOut.TabIndex = 6;
      this.checkBoxCheckedOut.Text = "Is Book Checked Out?";
      this.checkBoxCheckedOut.UseVisualStyleBackColor = true;
      // 
      // checkBoxPastDue
      // 
      this.checkBoxPastDue.AutoSize = true;
      this.checkBoxPastDue.Location = new System.Drawing.Point(331, 111);
      this.checkBoxPastDue.Name = "checkBoxPastDue";
      this.checkBoxPastDue.Size = new System.Drawing.Size(115, 17);
      this.checkBoxPastDue.TabIndex = 7;
      this.checkBoxPastDue.Text = "Is Book Past Due?";
      this.checkBoxPastDue.UseVisualStyleBackColor = true;
      // 
      // MyLibraryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "MyLibraryForm";
      this.Text = "MyLibrary";
      this.Shown += new System.EventHandler(this.MyLibrary_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckoutLog)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView DataGridViewBookList;
    private System.Windows.Forms.Label labelAuthor;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.PictureBox pictureBoxCover;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddNewBook;
    private System.Windows.Forms.ToolStripButton toolStripButtonViewMembers;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dataGridViewCheckoutLog;
    private System.Windows.Forms.Button buttonCheckIn;
    private System.Windows.Forms.Button buttonCheckout;
    private System.Windows.Forms.CheckBox checkBoxPastDue;
    private System.Windows.Forms.CheckBox checkBoxCheckedOut;
  }
}