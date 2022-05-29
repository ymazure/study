using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  internal class ErrorLogger : IInfoLogger
  {
    private readonly IInfoLogger logger;

    public ErrorLogger(IInfoLogger logger)
    {
      this.logger = logger;
    }

    public void LogInfo()
    {
      logger.LogInfo();
    }

    public void LogError()
    {

    }
  }
}
