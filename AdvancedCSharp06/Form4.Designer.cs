﻿namespace AdvancedCSharp06
{
  partial class Form4
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(138, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(605, 27);
      this.textBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(75, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Url";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(516, 76);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(227, 29);
      this.button1.TabIndex = 2;
      this.button1.Text = "Download";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(516, 111);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(227, 29);
      this.button2.TabIndex = 3;
      this.button2.Text = "Download (Async/Await)";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form4";
      this.Text = "Form4";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox textBox1;
    private Label label1;
    private Button button1;
    private Button button2;
  }
}