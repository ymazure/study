using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  internal class SamsungLaptop
  {

    public void Charge(SamsungCharger charger)
    {
      charger.Connect();
    }
  }
}
