using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  internal sealed class MoneyService : IMoneyService
  {
    public decimal PayTax()
    {
      return 10;
    }
  }
}
