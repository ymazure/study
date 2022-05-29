using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
  internal class OneDoorFridge : IFridge
  {
    public IFreezer Freezer { get; set; }
  }
}
