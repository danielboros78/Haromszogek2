using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  public class DHaromszog
  {
    private double aOldal;
    private double bOldal;
    private double cOldal;

    public double a
    {
      get => aOldal; 
      set
      {
        if (value > 0)
        {
          aOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'a\' oldal nem lehet negatív vagy nulla!");
        }
      }
    }

    public double b
    {
      get => bOldal;
      set
      {
        if (value > 0)
        {
          bOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'b\' oldal nem lehet negatív vagy nulla!");
        }
      }
    }

    public double c
    {
      get => cOldal;
      set
      {
        if (value > 0)
        {
          cOldal = value;
        }
        else
        {
          throw new OldalNemJoException("Az \'c\' oldal nem lehet negatív vagy nulla!");
        }
      }
    }

    private bool EllDerekszogu {
      get
      {
        return Math.Pow(aOldal, 2) + Math.Pow(bOldal, 2) == Math.Pow(cOldal, 2);
      } 
    }

    private bool EllMegszerkesztheto {
      get
      {
        return aOldal + bOldal > cOldal;
      } 
    }

    private bool EllNovekvoSorrend {
      get
      {
        return aOldal <= bOldal && bOldal <= cOldal;
      }
    }

    public double Kerulet { get => aOldal + bOldal + cOldal; }

    public double Terulet { get => aOldal * bOldal / 2; }

    public int SorSzama { get; set; }

    public DHaromszog(string[] sor, int sorSzam)
    {
      a = Convert.ToDouble(sor[0]);
      b = Convert.ToDouble(sor[1]);
      c = Convert.ToDouble(sor[2]);
      SorSzama = sorSzam;
      if (!EllNovekvoSorrend)
      {
        throw new NincsNovekvoSorrendben("Nincs növekvő sorrendben!");
      }
      if (!EllMegszerkesztheto)
      {
        throw new NemMegszerkesztheto("A háromszöget nem lehet megszerkeszteni!");
      }
      if (!EllDerekszogu)
      {
        throw new NemDerekszogu("A háromszög nem derékszögű!");
      }
    }
  }
}
