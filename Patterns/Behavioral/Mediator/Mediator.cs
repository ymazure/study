using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  internal class Mediator
  {

    private WebPageData _webPageData;
    private DesktopData _desktopData;

    public Action<string> WebPageTitleChanged;
    public Action<string> WebPageTextBOxChanged;
    public Action<string> DesktopTitleChanged;
    public Action<string> DesktopTextBOxChanged;

    public Mediator(WebPageData webPageData, DesktopData desktopData)
    {
      _webPageData = webPageData;
      _desktopData = desktopData;

      WebPageTitleChanged = s => _desktopData.Title = s;
      WebPageTextBOxChanged = s => _desktopData.TextBox = s;
      DesktopTitleChanged = s => _webPageData.Title = s;
      DesktopTextBOxChanged = s => _webPageData.TextBox = s;
    }

  }
}
