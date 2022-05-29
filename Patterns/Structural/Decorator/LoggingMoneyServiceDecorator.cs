using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  internal class LoggingMoneyServiceDecorator : IMoneyService
  {
    private readonly IMoneyService _moneyService;
    private readonly Logger _logger;

    public LoggingMoneyServiceDecorator(IMoneyService moneyService)
    {
      _moneyService = moneyService;
      _logger = new Logger();
    }

    public decimal PayTax()
    {
      var result = _moneyService.PayTax();

      _logger.Log($"Tax payed : {result}$");

      return result;
    }
  }

  internal class Logger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
}
