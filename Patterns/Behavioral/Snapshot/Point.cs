using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
  public partial class Point
  {
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public void ChangeState()
    {
      X = new Random().Next(0, 100);
      Y = new Random().Next(0, 100);
    }
  }
}
