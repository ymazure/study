using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  internal class QuickSortStrategy<T> : ISortStrategy<T>
  {
    public IEnumerable<T> Sort(IEnumerable<T> items)
    {
      // quick sort algorithm here
      return items;
    }
  }
}
