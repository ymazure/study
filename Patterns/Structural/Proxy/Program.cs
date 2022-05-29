using System;

namespace Proxy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      IUserService userService;

      userService = new UserService();

      userService = new LazyUserServiceProxy(() => new UserService());

      userService = new CachingUserServiceProxy(new UserService());
    }
  }
}
