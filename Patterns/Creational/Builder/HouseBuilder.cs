using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
  public partial class House
  {
    public class HouseBuilder
    {
      private House _h = new House();

      public HouseBuilder()
      {

      }

      public HouseBuilder(House h)
      {
        _h = h;
      }

      public void Reset()
      {
        _h = new House();
      }

      public HouseBuilder BuildWindows() { return this; }
      public HouseBuilder BuildDors() { return this; }
      public HouseBuilder BuildPool() { return this; }
      public HouseBuilder BuildKitchen() { return this; }
      public HouseBuilder BuildBedroom() { return this; }
      public HouseBuilder BuildBathroom() { return this; }
      public HouseBuilder BuildRoof() { return this; }
      public HouseBuilder BuildGarage() { return this; }
      public HouseBuilder BuildLivingroom() { return this; }

      public House GetHouse()
      {
        var result = _h;
        this.Reset();
        return result;
      }
    }
  }
}
