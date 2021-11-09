using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  class NemDerekszogu : Exception
  {
    public NemDerekszogu(string message) : base(message)
    {

    }
  }
}
