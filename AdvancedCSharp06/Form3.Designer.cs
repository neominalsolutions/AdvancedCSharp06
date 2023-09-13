namespace AdvancedCSharp06
{
  partial class Form3
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
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnFill = new System.Windows.Forms.Button();
      this.listBox3 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(51, 83);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(698, 27);
      this.txtSearch.TabIndex = 14;
      // 
      // btnFill
      // 
      this.btnFill.Location = new System.Drawing.Point(51, 297);
      this.btnFill.Name = "btnFill";
      this.btnFill.Size = new System.Drawing.Size(698, 70);
      this.btnFill.TabIndex = 13;
      this.btnFill.Text = "Başlat";
      this.btnFill.UseVisualStyleBackColor = true;
      this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
      // 
      // listBox3
      // 
      this.listBox3.FormattingEnabled = true;
      this.listBox3.ItemHeight = 20;
      this.listBox3.Location = new System.Drawing.Point(528, 145);
      this.listBox3.Name = "listBox3";
      this.listBox3.Size = new System.Drawing.Size(221, 124);
      this.listBox3.TabIndex = 12;
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 20;
      this.listBox2.Location = new System.Drawing.Point(291, 145);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(221, 124);
      this.listBox2.TabIndex = 11;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(51, 145);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(221, 124);
      this.listBox1.TabIndex = 10;
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.btnFill);
      this.Controls.Add(this.listBox3);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Name = "Form3";
      this.Text = "Form3";
      this.Load += new System.EventHandler(this.Form3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox txtSearch;
    private Button btnFill;
    private ListBox listBox3;
    private ListBox listBox2;
    private ListBox listBox1;
  }
}