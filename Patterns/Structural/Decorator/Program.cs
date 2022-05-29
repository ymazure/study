using System;

namespace Decorator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      IMoneyService service;

      service = new MoneyService();

      service = new LoggingMoneyServiceDecorator(service);

      service = new PerformanceMoneyServiceDecorator(service);

      service.PayTax();

      Console.ReadLine();
    }
  }
}
