using System;

namespace Facade
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var converter = new VideoConverter();

      converter.ConvertVideo("SomeVideo", "mp4");

      Console.ReadLine();
    }
  }
}
