using ChainOfResponsibility.PipelineItems;
using System;

namespace ChainOfResponsibility
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var routingMiddleware = new RoutingMiddleware(null);
      var authorizationMiddleware = new AuthorizationMiddleware(routingMiddleware);
      var rootMiddleware = new ExceptionMiddleware(authorizationMiddleware);

      var request = new HttpRequest();

      rootMiddleware.Handle(request);

      Console.ReadLine();
    }
  }
}
