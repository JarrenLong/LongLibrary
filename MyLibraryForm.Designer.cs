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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.DataGridViewBookList = new System.Windows.Forms.DataGridView();
      this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelAuthor = new System.Windows.Forms.Label();
      this.labelTitle = new System.Windows.Forms.Label();
      this.pictureBoxCover = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.buttonAddNew = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
      this.tableLayoutPanel1.Controls.Add(this.DataGridViewBookList, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
      this.tableLayoutPanel1.TabIndex = 0;
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
      this.DataGridViewBookList.Location = new System.Drawing.Point(3, 35);
      this.DataGridViewBookList.Name = "DataGridViewBookList";
      this.DataGridViewBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGridViewBookList.Size = new System.Drawing.Size(266, 412);
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
      // panel1
      // 
      this.panel1.Controls.Add(this.labelAuthor);
      this.panel1.Controls.Add(this.labelTitle);
      this.panel1.Controls.Add(this.pictureBoxCover);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(275, 35);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(522, 412);
      this.panel1.TabIndex = 1;
      // 
      // labelAuthor
      // 
      this.labelAuthor.Location = new System.Drawing.Point(5, 215);
      this.labelAuthor.Name = "labelAuthor";
      this.labelAuthor.Size = new System.Drawing.Size(513, 21);
      this.labelAuthor.TabIndex = 2;
      this.labelAuthor.Text = "The Book\'s Author";
      this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // labelTitle
      // 
      this.labelTitle.Location = new System.Drawing.Point(5, 194);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(513, 21);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "The Book\'s Title";
      this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // pictureBoxCover
      // 
      this.pictureBoxCover.Location = new System.Drawing.Point(196, 21);
      this.pictureBoxCover.Name = "pictureBoxCover";
      this.pictureBoxCover.Size = new System.Drawing.Size(130, 170);
      this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxCover.TabIndex = 0;
      this.pictureBoxCover.TabStop = false;
      // 
      // panel2
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
      this.panel2.Controls.Add(this.buttonAddNew);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(794, 26);
      this.panel2.TabIndex = 2;
      // 
      // buttonAddNew
      // 
      this.buttonAddNew.Location = new System.Drawing.Point(336, 2);
      this.buttonAddNew.Name = "buttonAddNew";
      this.buttonAddNew.Size = new System.Drawing.Size(123, 23);
      this.buttonAddNew.TabIndex = 0;
      this.buttonAddNew.Text = "Add New Book(s)";
      this.buttonAddNew.UseVisualStyleBackColor = true;
      this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
      // 
      // MyLibraryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MyLibraryForm";
      this.Text = "MyLibrary";
      this.Shown += new System.EventHandler(this.MyLibrary_Shown);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBookList)).EndInit();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataGridView DataGridViewBookList;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label labelAuthor;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.PictureBox pictureBoxCover;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button buttonAddNew;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
  }
}