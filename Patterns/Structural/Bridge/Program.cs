using System;

namespace Bridge
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Instead of creating multiple types like OneDoorVacuumFreezerFridge, TwoDoorVacuumFreezerFridge,
      // OneDoorOrdinaryFreezerFridge, TwoDoorOrdinaryFreezerFridge, we use separate Freezer and Fridge types within composition

      IFridge fridge = null;
      fridge = new OneDoorFridge();
      fridge.Freezer = new VacuumFreezer();

      fridge = new TwoDoorFridge();
      fridge.Freezer = new OrdinaryFreezer();

      Console.Read();
    }
  }
}
