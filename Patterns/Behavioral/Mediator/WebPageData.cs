using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  internal class WebPageData
  {
    private string _title;
    private string _textBox;
    private Mediator _mediator;

    public string Title
    {
      get => _title;
      set
      {
        _title = value;
        _mediator.WebPageTextBOxChanged(value);
      }
    }

    public string TextBox { 
      get => _textBox;
      set
      {
        _title = value;
        _mediator.WebPageTitleChanged(value);
      }
    }

    public WebPageData(Mediator mediator)
    {
      _mediator = mediator;
    }
  }
}
