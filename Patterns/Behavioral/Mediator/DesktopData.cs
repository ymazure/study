using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  internal class DesktopData
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
        _mediator.DesktopTitleChanged(value);
      }
    }

    public string TextBox { 
      get => _textBox;
      set
      {
        _textBox = value;
        _mediator.DesktopTextBOxChanged(value);
      }
    }

    public DesktopData(Mediator mediator)
    {
      _mediator = mediator;
    }
  }
}
