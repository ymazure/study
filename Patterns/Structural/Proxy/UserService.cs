using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  internal class UserService : IUserService
  {
    public ICollection<object> GetActiveUsers()
    {
      return new List<object>();
    }

    public ICollection<object> GetUsers()
    {
      return new List<object>();
    }

    public void InsertUser()
    {
      
    }

    public void UpdateUser()
    {
      
    }
  }
}
