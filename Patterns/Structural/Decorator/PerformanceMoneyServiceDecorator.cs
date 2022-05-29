using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  internal class PerformanceMoneyServiceDecorator : IMoneyService
  {
    private readonly IMoneyService _moneyService;
    private readonly TelemetryService _telemetryService = new TelemetryService();

    public PerformanceMoneyServiceDecorator(IMoneyService moneyService)
    {
      _moneyService = moneyService;
    }

    public decimal PayTax()
    {
      Stopwatch s = Stopwatch.StartNew();

      var result = _moneyService.PayTax();

      _telemetryService.Send($"Execution time of {nameof(PayTax)}", s.ElapsedMilliseconds);

      return result;
    }

    internal class TelemetryService
    {
      public void Send(string key, object o)
      {
        Console.WriteLine($"Sent message:{key}, o: {o}");
      }
    }
  }
}
