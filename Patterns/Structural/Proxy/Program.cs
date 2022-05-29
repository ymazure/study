using System;

namespace Proxy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      IUserService userService;

      userService = new UserService();

      // Added dynamically new functionality
      userService = new LazyUserServiceProxy(() => new UserService());

      // Added dynamically new functionality
      userService = new CachingUserServiceProxy(userService);
    }
  }
}
