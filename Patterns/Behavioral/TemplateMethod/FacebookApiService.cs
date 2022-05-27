using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
  internal class FacebookApiService : ApiService
  {
    private const string _facebookAuthCookie = "auth123";
    protected override void Authorize(Request request)
    {
      request.Cookies.Add(_facebookAuthCookie);
    }
  }
}
