using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
  internal class SamsungChargerAdapter : SamsungCharger
  {
    private LenovoCharger lenovoCharger;

    public SamsungChargerAdapter(LenovoCharger lenovoCharger)
    {
      this.lenovoCharger = lenovoCharger;
    }

    public override void Connect()
    {
      lenovoCharger.PlugIn();
    }
  }
}
