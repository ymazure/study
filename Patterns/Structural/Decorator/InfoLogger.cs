using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
  internal class InfoLogger : IInfoLogger
  {
    public InfoLogger()
    {
    }

    public void LogInfo()
    {

    }
  }

  internal interface IInfoLogger
  {
    void LogInfo();
  }
}
