using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  internal interface IUserService
  {
    ICollection<object> GetUsers();

    ICollection<object> GetActiveUsers();

    void InsertUser();

    void UpdateUser();
  }
}
