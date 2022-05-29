using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  internal class SamsungCharger
  {
    public virtual void Connect() {
      Console.WriteLine("Charging from Samsung charger.");
    }
  }
}
