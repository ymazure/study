using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
  internal class OneDoreFridge : IFridge
  {
    public IFreezer Freezer { get; set; }
  }
}
