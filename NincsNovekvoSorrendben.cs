using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
  class NincsNovekvoSorrendben : Exception
  {
    public NincsNovekvoSorrendben(string message) : base(message)
    {

    }
  }
}
