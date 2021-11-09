
namespace Haromszogek
{
  partial class Form1
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
      this.btnAdatokBetoltese = new System.Windows.Forms.Button();
      this.lbHibak = new System.Windows.Forms.ListBox();
      this.lbDerekszogu = new System.Windows.Forms.ListBox();
      this.lbAdatok = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAdatokBetoltese
      // 
      this.btnAdatokBetoltese.Location = new System.Drawing.Point(12, 12);
      this.btnAdatokBetoltese.Name = "btnAdatokBetoltese";
      this.btnAdatokBetoltese.Size = new System.Drawing.Size(195, 42);
      this.btnAdatokBetoltese.TabIndex = 0;
      this.btnAdatokBetoltese.Text = "Adatok betöltése";
      this.btnAdatokBetoltese.UseVisualStyleBackColor = true;
      this.btnAdatokBetoltese.Click += new System.EventHandler(this.btnAdatokBetoltese_Click);
      // 
      // lbHibak
      // 
      this.lbHibak.FormattingEnabled = true;
      this.lbHibak.ItemHeight = 18;
      this.lbHibak.Location = new System.Drawing.Point(12, 73);
      this.lbHibak.Name = "lbHibak";
      this.lbHibak.Size = new System.Drawing.Size(649, 130);
      this.lbHibak.TabIndex = 1;
      // 
      // lbDerekszogu
      // 
      this.lbDerekszogu.FormattingEnabled = true;
      this.lbDerekszogu.ItemHeight = 18;
      this.lbDerekszogu.Location = new System.Drawing.Point(12, 243);
      this.lbDerekszogu.Name = "lbDerekszogu";
      this.lbDerekszogu.Size = new System.Drawing.Size(270, 364);
      this.lbDerekszogu.TabIndex = 2;
      this.lbDerekszogu.SelectedValueChanged += new System.EventHandler(this.lbDerekszogu_SelectedValueChanged);
      // 
      // lbAdatok
      // 
      this.lbAdatok.FormattingEnabled = true;
      this.lbAdatok.ItemHeight = 18;
      this.lbAdatok.Location = new System.Drawing.Point(305, 243);
      this.lbAdatok.Name = "lbAdatok";
      this.lbAdatok.Size = new System.Drawing.Size(356, 202);
      this.lbAdatok.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(223, 18);
      this.label1.TabIndex = 4;
      this.label1.Text = "Hibák a kiválasztott állományban";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(305, 232);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(289, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Kiválasztott derékszögű háromszög adatai";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 232);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(185, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Derékszögű háromszögek";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 627);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbAdatok);
      this.Controls.Add(this.lbDerekszogu);
      this.Controls.Add(this.lbHibak);
      this.Controls.Add(this.btnAdatokBetoltese);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Button btnAdatokBetoltese;
    public System.Windows.Forms.ListBox lbHibak;
    public System.Windows.Forms.ListBox lbDerekszogu;
    public System.Windows.Forms.ListBox lbAdatok;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

