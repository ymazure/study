using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
  internal abstract class ApiService
  {
    public void SendMessage(string message)
    {
      var request = new Request(message);

      Authorize(request);

      // Sendong autorized request
      // ..
      // ..
    }

    // template method
    protected abstract void Authorize(Request request);
  }

  public class Request
  {
    public string Message { get; set; }

    public List<object> Cookies { get; set; }

    public List<object> Headers { get; set; }

    public Request(string message = null)
    {
      Message = message;
    }
  }
}
