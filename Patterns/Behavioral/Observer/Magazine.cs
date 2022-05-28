using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
  internal class Magazine
  {
    public event Action StockUpdated = () => { };
    private Stack<string> _magazines = new Stack<string>();

    public Magazine()
    {
      Task.Run(() => {
        while (true)
        {
          Thread.Sleep(TimeSpan.FromSeconds(7));
          Console.WriteLine("Stock updated. Notifying subscribers.");

          for (int i = 0; i < 10; i++)
          {
            _magazines.Push("Magazine from " + DateTime.Now.Date.ToString());
          }

          StockUpdated();
        }
      });
    }

    public string GetWeeklyInstance()
    {
      return _magazines.Pop();
    }
  }
}
