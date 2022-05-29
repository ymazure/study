using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  internal class LenovoCharger
  {
    public void PlugIn()
    {
      Console.WriteLine("Charging from Lenovo charger.");
    }
  }
}
