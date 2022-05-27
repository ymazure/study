using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  internal interface ISortStrategy<T>
  {
    IEnumerable<T> Sort(IEnumerable<T> items);
  }
}
