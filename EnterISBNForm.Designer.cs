namespace LongLibrary
{
  partial class EnterISBNForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.TextBoxISBN = new System.Windows.Forms.TextBox();
      this.ButtonLookup = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(304, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter the book\'s ISBN and press Lookup to add it to our library:";
      // 
      // TextBoxISBN
      // 
      this.TextBoxISBN.Location = new System.Drawing.Point(318, 12);
      this.TextBoxISBN.Name = "TextBoxISBN";
      this.TextBoxISBN.Size = new System.Drawing.Size(146, 20);
      this.TextBoxISBN.TabIndex = 1;
      this.TextBoxISBN.Text = "";
      this.TextBoxISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxISBN_KeyDown);
      // 
      // ButtonLookup
      // 
      this.ButtonLookup.Location = new System.Drawing.Point(470, 11);
      this.ButtonLookup.Name = "ButtonLookup";
      this.ButtonLookup.Size = new System.Drawing.Size(75, 23);
      this.ButtonLookup.TabIndex = 2;
      this.ButtonLookup.Text = "&Lookup";
      this.ButtonLookup.UseVisualStyleBackColor = true;
      this.ButtonLookup.Click += new System.EventHandler(this.ButtonLookup_Click);
      // 
      // EnterISBNForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ButtonLookup);
      this.Controls.Add(this.TextBoxISBN);
      this.Controls.Add(this.label1);
      this.Name = "EnterISBNForm";
      this.Text = "Long Library Catalog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TextBoxISBN;
    private System.Windows.Forms.Button ButtonLookup;
  }
}

