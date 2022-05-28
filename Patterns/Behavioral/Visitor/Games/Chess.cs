﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Games
{
  internal class Chess : GameBase
  {
    public override void Accept(IGameVisitor visitor)
    {
      visitor.Visit(this);
    }
  }
}
