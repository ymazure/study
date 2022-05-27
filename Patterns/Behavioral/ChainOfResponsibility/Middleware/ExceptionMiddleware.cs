using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.PipelineItems
{
  internal class ExceptionMiddleware : IMiddleware
  {
    private IMiddleware _next;

    public ExceptionMiddleware(IMiddleware next)
    {
      _next = next;
    }
    public void Handle(HttpRequest request)
    {
      Console.WriteLine("Handling in ExceptionMiddleware.");

      // ...
      // ...
      // ...
      // ...

      if (_next == null)
        return;

      _next.Handle(request);

      Console.WriteLine("After handling in ExceptionMiddleware.");
    }
  }
}
