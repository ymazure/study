using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  internal class CachingUserServiceProxy : IUserService
  {
    private readonly IUserService _service;
    private Dictionary<string, ICollection<object>> cachedResponses = new Dictionary<string, ICollection<object>>();

    public CachingUserServiceProxy(IUserService service)
    {
      _service = service;
    }

    public ICollection<object> GetActiveUsers()
    {
      if (cachedResponses.TryGetValue(nameof(GetActiveUsers), out ICollection<object> cachedResult))
      {
        return cachedResult;
      }

      var result = _service.GetActiveUsers();
      cachedResponses.Add(nameof(GetActiveUsers), result);
      return result;
    }

    public ICollection<object> GetUsers()
    {
      if (cachedResponses.TryGetValue(nameof(GetUsers), out ICollection<object> cachedResult))
      {
        return cachedResult;
      }

      var result = _service.GetActiveUsers();
      cachedResponses.Add(nameof(GetUsers), result);
      return result;
    }

    public void InsertUser()
    {
      _service.InsertUser();
    }

    public void UpdateUser()
    {
      _service.UpdateUser();
    }
  }
}
