using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
  internal interface IUIFactory
  {
    IButton CreateButton();
    IWindow CreateWindow();
    ITextBox CreateTextBox();
  }
}
