using Iterator.BodyParts;
using System;

namespace Iterator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Human Jonny = new Human();

      foreach (IBodyPart bodyPart in Jonny)
      {
        Console.WriteLine(bodyPart.GetType());
      }
      Console.ReadLine();
    }
  }
}
