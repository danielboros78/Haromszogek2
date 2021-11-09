using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
  public partial class Form1 : Form
  {
    static List<DHaromszog> dhList = new List<DHaromszog>();
    public int sorSzama = 0;
    public double terulet = 0;
    public double kerulet = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("haromszogek.txt");
      while (!be.EndOfStream)
      {
        try
        {
          string[] sor = be.ReadLine().Split();
          sorSzama++;
          dhList.Add(new DHaromszog(sor, sorSzama));
        }
        catch (Exception ex)
        {
          lbHibak.Items.Add($"{sorSzama}. sor: {ex.Message}");
        }
      }
      be.Close();
    }

    private void btnAdatokBetoltese_Click(object sender, EventArgs e)
    {
      Beolvasas();
      foreach (DHaromszog dh in dhList)
      {
        lbDerekszogu.Items.Add($"{dh.SorSzama}. sor: a={dh.a} b={dh.b} c={dh.c}");
      }
    }

    private void lbDerekszogu_SelectedValueChanged(object sender, EventArgs e)
    {
      Console.WriteLine();
    }
  }
}
