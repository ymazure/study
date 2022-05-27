using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  internal class BubbleSortStrategy : ISortStrategy<int>
  {
    public IEnumerable<int> Sort(IEnumerable<int> items)
    {
      // bubble sort algorithm here
      return items;
    }
  }
}
