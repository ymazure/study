using System;

namespace Adapter
{
  internal class Program
  {
    static void Main(string[] args)
    {
      LenovoCharger lenovoCharger = new LenovoCharger();

      SamsungLaptop laptop = new SamsungLaptop();

      SamsungChargerAdapter adapter = new SamsungChargerAdapter(lenovoCharger);

      laptop.Charge(adapter);

      Console.ReadLine();

    }
  }
}
