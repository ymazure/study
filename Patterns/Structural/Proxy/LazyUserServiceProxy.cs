using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  internal class LazyUserServiceProxy : IUserService
  {
    private IUserService _service;
    private readonly Func<IUserService> _realServiceFactory;

    public LazyUserServiceProxy(Func<IUserService> realServiceFactory)
    {
      _realServiceFactory = realServiceFactory;
    }

    public ICollection<object> GetActiveUsers()
    {
      Initialize();
      return _service.GetActiveUsers();
    }

    public ICollection<object> GetUsers()
    {
      Initialize();
      return _service.GetUsers();
    }

    public void InsertUser()
    {
      Initialize();
      _service.InsertUser();
    }

    public void UpdateUser()
    {
      Initialize();
      _service.UpdateUser();
    }

    private void Initialize()
    {
      if(_service == null)
      {
        _service  = _realServiceFactory();
      }
    }
  }
}
