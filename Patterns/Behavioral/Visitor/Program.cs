using System;
using System.Collections.Generic;
using Visitor.Games;

namespace Visitor
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<GameBase> games = new List<GameBase>() {
        new Chess(),
        new Checkers(),
        new Go()
      };

      IGameVisitor visitor = new StatisticsGameVisitor();

      foreach (GameBase game in games)
      {
        visitor.Visit(game);
      }

      visitor = new ReportingGameVisitor();

      foreach (GameBase game in games)
      {
        visitor.Visit(game);
      }

      visitor = new SerealizingGameVisitor();

      foreach (GameBase game in games)
      {
        visitor.Visit(game);
      }

      Console.ReadLine();
      
    }
  }
}
