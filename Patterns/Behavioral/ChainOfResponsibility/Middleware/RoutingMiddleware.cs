using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.PipelineItems
{
  internal class RoutingMiddleware : IMiddleware
  {
    private IMiddleware _next;

    public RoutingMiddleware(IMiddleware next)
    {
      _next = next;
    }
    public void Handle(HttpRequest request)
    {
      Console.WriteLine("Handling in RoutingMiddleware.");

      // ...
      // ...
      // ...
      // ...

      if (_next == null)
        return;

      _next.Handle(request);

      Console.WriteLine("After handling in RoutingMiddleware.");
    }
  }
}
