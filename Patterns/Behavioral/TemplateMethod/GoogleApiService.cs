using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
  internal class GoogleApiService : ApiService
  {
    private const string _googleAuthHeader = "someInportantHeader";
    protected override void Authorize(Request request)
    {
      request.Headers.Add(_googleAuthHeader);
    }
  }
}
