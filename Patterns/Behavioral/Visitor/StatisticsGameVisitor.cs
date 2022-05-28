using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Games;

namespace Visitor
{
  internal class StatisticsGameVisitor : IGameVisitor
  {
    public void Visit(Chess chess)
    {
      Console.WriteLine(this.ToString() + " visited " + chess.ToString());
    }

    public void Visit(Checkers сheckers)
    {
      Console.WriteLine(this.ToString() + " visited " + сheckers.ToString());
    }

    public void Visit(Go go)
    {
      Console.WriteLine(this.ToString() + " visited " + go.ToString());
    }
  }
}
