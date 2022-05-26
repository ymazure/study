using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  internal class Sun
  {
    private static Sun _instance;

    private static object _syncRoot = new object();

    public static Sun Instance
    {
      get
      {
        if (_instance == null)
        {
          lock (_syncRoot)
          {
            if (_instance == null)
            {
                _instance = new Sun();
            }
          }
        }

        return _instance;
      }
    }

    private Sun()
    {
    }
  }
}
