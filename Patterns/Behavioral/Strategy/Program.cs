using System;

namespace Strategy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      ISortStrategy<int> sortStrategy = new QuickSortStrategy<int>();

      var sorted = sortStrategy.Sort(new int[] { 3, 1, 3 });

      sortStrategy = new BubbleSortStrategy<int>();

      sorted = sortStrategy.Sort(new int[] { 3, 1, 3 });
    }
  }
}
