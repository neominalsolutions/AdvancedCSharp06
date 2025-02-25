namespace AdvancedCSharp06
{
  partial class Form2
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
      txtSearch = new TextBox();
      btnFill = new Button();
      listBox3 = new ListBox();
      listBox2 = new ListBox();
      listBox1 = new ListBox();
      SuspendLayout();
      // 
      // txtSearch
      // 
      txtSearch.Location = new Point(50, 57);
      txtSearch.Name = "txtSearch";
      txtSearch.Size = new Size(698, 27);
      txtSearch.TabIndex = 9;
      txtSearch.TextChanged += txtSearch_TextChanged;
      // 
      // btnFill
      // 
      btnFill.Location = new Point(50, 271);
      btnFill.Name = "btnFill";
      btnFill.Size = new Size(698, 70);
      btnFill.TabIndex = 8;
      btnFill.Text = "Başlat";
      btnFill.UseVisualStyleBackColor = true;
      btnFill.Click += btnFill_Click;
      // 
      // listBox3
      // 
      listBox3.FormattingEnabled = true;
      listBox3.ItemHeight = 20;
      listBox3.Location = new Point(527, 119);
      listBox3.Name = "listBox3";
      listBox3.Size = new Size(221, 124);
      listBox3.TabIndex = 7;
      // 
      // listBox2
      // 
      listBox2.FormattingEnabled = true;
      listBox2.ItemHeight = 20;
      listBox2.Location = new Point(290, 119);
      listBox2.Name = "listBox2";
      listBox2.Size = new Size(221, 124);
      listBox2.TabIndex = 6;
      // 
      // listBox1
      // 
      listBox1.FormattingEnabled = true;
      listBox1.ItemHeight = 20;
      listBox1.Location = new Point(50, 119);
      listBox1.Name = "listBox1";
      listBox1.Size = new Size(221, 124);
      listBox1.TabIndex = 5;
      // 
      // Form2
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(txtSearch);
      Controls.Add(btnFill);
      Controls.Add(listBox3);
      Controls.Add(listBox2);
      Controls.Add(listBox1);
      Name = "Form2";
      Text = "Form2";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtSearch;
    private Button btnFill;
    private ListBox listBox3;
    private ListBox listBox2;
    private ListBox listBox1;
  }
}