using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Games;

namespace Visitor
{
  internal interface IGameVisitor
  {
    void Visit(GameBase game)
    {
      game.Accept(this);
    }

    void Visit(Chess chess);
    void Visit(Checkers сheckers);
    void Visit(Go go);
  }
}
