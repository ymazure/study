using System;

namespace Decorator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      InfoLogger infoLogger = new InfoLogger();

      ErrorLogger errorLogger = new ErrorLogger(infoLogger);

      errorLogger.LogInfo();

      // using added method

      errorLogger.LogError();

      Console.ReadLine();
    }
  }
}
