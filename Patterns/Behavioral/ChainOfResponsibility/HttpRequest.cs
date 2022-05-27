using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
  internal class HttpRequest
  {
    public object[] Headers { get; private set; }

    public object[] Cookies { get; private set; }

    public string Uri { get; set; }

    public string IP { get; set; }

    public string Country { get; set; }
  }
}
