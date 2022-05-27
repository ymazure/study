using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  internal class BubbleSortStrategy<T> : ISortStrategy<T>
  {
    public IEnumerable<T> Sort(IEnumerable<T> items)
    {
      // bubble sort algorithm here
      return items;
    }
  }
}
