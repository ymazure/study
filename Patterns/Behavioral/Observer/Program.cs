using System;

namespace Observer
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Human Vasya = new Human();
      Human Petya = new Human();

      var magaz = new Magazine();

      magaz.StockUpdated += () =>
      {
        var newMag = magaz.GetWeeklyInstance();
        Vasya.Magazines.Add(newMag);
        Console.WriteLine($"Vasya has {Vasya.Magazines.Count} magazines.");
      };

      magaz.StockUpdated += () =>
      {
        var newMag = magaz.GetWeeklyInstance();
        Petya.Magazines.Add(newMag);
        Console.WriteLine($"Petya has {Petya.Magazines.Count} magazines.");
      };

      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
    }
  }
}
