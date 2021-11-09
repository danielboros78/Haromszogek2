using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  class NemMegszerkesztheto : Exception
  {
    public NemMegszerkesztheto(string message) : base(message)
    {

    }
  }
}
